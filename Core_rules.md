# `01_CLEAN_ARCHITECTURE.md`

# 🏗️ Clean Architecture & Lifecycle Rules

This document defines the structural and behavioral standards for the Blazor WASM Portfolio. Adherence to these rules is **mandatory** for all generated code.

## 1. Core Principles

### 1.1 Separation of Concerns

- **UI Components (`.razor`):** Responsible **only** for rendering markup, handling user input events, and displaying state. They must not contain business logic, data transformation, or direct API calls.
- **Service Layer (`Services/`):** All business logic, data fetching, state management, and GSAP coordination must reside in injected services.
- **Models:** Use DTOs (Data Transfer Objects) for UI binding. Do not expose database entities directly to the UI.

### 1.2 Dependency Injection (DI)

- All dependencies (Services, `IJSRuntime`, `HttpClient`) must be injected via `[Inject]` or constructor injection.
- **Prohibited:** Instantiating services manually (e.g., `new MyService()`).

### 1.3 Asynchronous Programming

- All I/O operations (JS Interop, HTTP, LocalStorage) must be `async/await`.
- Avoid `.Result` or `.Wait()` to prevent deadlocks in WASM.
- UI states (Loading/Error) must be managed during async operations.

## 2. Component Structure & Lifecycle

### 2.1 Standard Component Template

Every `.razor` component must follow this structure:

```razor
@inject IMyService Service
@implements IAsyncDisposable

<!-- Markup -->
<div class="...">...</div>

<!-- Code -->
@code {
    // 1. Fields
    private bool _isLoading;
    private IJSObjectReference? _jsModule;

    // 2. Lifecycle
    protected override async Task OnInitializedAsync() { ... }
    protected override async Task OnAfterRenderAsync(bool firstRender) { ... }

    // 3. Event Handlers
    private async Task OnClick() { ... }

    // 4. Cleanup (MANDATORY for JS/GSAP)
    public async ValueTask DisposeAsync() { ... }
}
```

### 2.2 JS Interop & GSAP Lifecycle Safety

**Critical:** Blazor WASM does not automatically clean up JavaScript references. Failure to dispose leads to memory leaks and console errors during navigation.

- **Rule:** Any component using `IJSRuntime` or GSAP **must** implement `IAsyncDisposable`.
- **Rule:** GSAP timelines/tweens must be killed before component disposal.
- **Rule:** `IJSObjectReference` must be disposed via `.DisposeAsync()`.

**Example (Correct):**

```csharp
public async ValueTask DisposeAsync()
{
    if (_jsModule is not null)
    {
        await _jsModule.InvokeVoidAsync("destroyAnimations"); // Custom JS cleanup
        await _jsModule.DisposeAsync();
    }
}
```

## 3. Folder Structure Enforcement

```text
/MyPortfolio
  ├── /wwwroot             # Static assets (css, js, images)
  ├── /Services            # C# Service Layer (Logic)
  ├── /Models              # DTOs and ViewModels
  ├── /Components          # Reusable UI Components
  │     ├── /Layout        # MainLayout, NavMenu
  │     ├── /Sections      # Hero, About, Projects
  │     └── /Shared        # Buttons, Cards, Inputs
  ├── /Pages               # Routable Pages (/ , /about)
  └── /docs                # Architecture rules (This file)
```

## 4. Error Handling

- **UI Level:** Use `ErrorBoundary` components for critical sections.
- **Service Level:** Wrap HTTP/JS calls in `try/catch` blocks. Log errors and return a safe state (e.g., empty list) rather than crashing the UI.

---

# `02_THEMING_AND_STYLING.md`

# 🎨 Centralized Theming & Tailwind Architecture

This document addresses the styling strategy. It resolves the "Custom CSS Fear" by defining a **Token-First** approach. We use CSS Variables **only** for definitions, and Tailwind Utilities **only** for application.

## 1. The 95/5 Rule

- **95% Tailwind Utilities:** Layout, spacing, typography, effects, and color application must use Tailwind classes (e.g., `bg-primary`, `p-4`, `text-lg`).
- **5% Custom CSS:** Reserved **strictly** for:
  1.  Defining CSS Variables (Tokens) in `input.css`.
  2.  Global resets (body, html).
  3.  GSAP-specific utility classes (if absolutely necessary).
  4.  Component-specific overrides in `.razor.css` (Scoped).

**❌ Prohibited:** Writing custom CSS classes for styling individual elements (e.g., `.my-card { padding: 20px; }`).

## 2. The Token Chain Architecture

We do not hardcode colors. We follow this chain:

1.  **CSS Variables (`input.css`):** Define the actual color values (RGB).
2.  **Tailwind Config (`tailwind.config.js`):** Map semantic names (e.g., `primary`) to those variables.
3.  **Blazor Components:** Use semantic names (e.g., `bg-primary`).

### 2.1 Step 1: Define Tokens (`wwwroot/css/input.css`)

This is the **Single Source of Truth** for themes.

```css
@layer base {
  :root {
    /* LIGHT THEME */
    --color-primary: 59 130 246; /* RGB without commas */
    --color-background: 255 255 255;
    --font-heading: "Inter", sans-serif;
  }

  .dark {
    /* DARK THEME OVERRIDES */
    --color-primary: 96 165 250;
    --color-background: 17 24 39;
  }

  [data-accent="purple"] {
    /* ACCENT THEME OVERRIDES */
    --color-primary: 168 85 247;
  }
}
```

### 2.2 Step 2: Map Tokens (`tailwind.config.js`)

```javascript
theme: {
  extend: {
    colors: {
      primary: 'var(--color-primary)', // Maps bg-primary to the variable
      background: 'var(--color-background)',
    },
    fontFamily: {
      heading: 'var(--font-heading)',
    }
  }
}
```

### 2.3 Step 3: Apply in Blazor (`Component.razor`)

```razor
<!-- ✅ CORRECT: Uses semantic tokens -->
<div class="bg-background text-primary font-heading">
    <h1 class="text-4xl">Hello</h1>
</div>

<!-- ❌ WRONG: Hardcoded values -->
<div class="bg-white text-[#3b82f6]" style="font-family: 'Inter'">
    <h1 style="font-size: 36px">Hello</h1>
</div>
```

## 3. Theme Switching Mechanics

### 3.1 Dark Mode

- **Mechanism:** Toggle the `.dark` class on the `<html>` element.
- **Implementation:** Handled via `ThemeService` + JS Interop.
- **Persistence:** State must be saved in `localStorage`.
- **FOUC Prevention:** A small inline script in `index.html` `<head>` must apply the class before the body renders.

### 3.2 Accent Themes

- **Mechanism:** Toggle `data-accent="name"` attribute on the `<html>` element.
- **Usage:** Allows switching color palettes (Blue, Purple, Green) without changing layout.
- **CSS:** Defined in `input.css` under `[data-accent="..."]` selectors.

## 4. Scoped CSS Rules (`.razor.css`)

Custom CSS is allowed **only** in scoped files for component-specific isolation.

- **Allowed:** Complex selectors that Tailwind cannot handle cleanly (e.g., specific third-party library overrides).
- **Allowed:** Using CSS Variables defined in `input.css`.
- **Prohibited:** Redefining colors (hex codes) inside scoped CSS. Use `var(--color-primary)` instead.

**Example (`HeroSection.razor.css`):**

```css
/* ✅ CORRECT */
.hero-gradient {
  background: linear-gradient(
    to right,
    var(--color-primary),
    var(--color-secondary)
  );
}

/* ❌ WRONG */
.hero-gradient {
  background: linear-gradient(to right, #3b82f6, #0ea5e9);
}
```

## 5. Animation & Transition Rules

- **Tailwind:** Use `transition-colors`, `duration-300` for simple state changes (Hover, Theme Switch).
- **GSAP:** Use for entrance animations, scroll triggers, and complex sequences.
- **Conflict:** Do not animate the same property (e.g., `opacity`) with both Tailwind transitions and GSAP simultaneously.
- **Performance:** Add `will-change-transform` via Tailwind (`will-change-transform`) only to elements actively being animated by GSAP.

## 6. Agent Checklist for Styling

Before generating any UI code, verify:

- [ ] Are colors using semantic names (`bg-primary`)?
- [ ] Are fonts using semantic names (`font-heading`)?
- [ ] Is there any hardcoded hex/pixel value? (If yes, refactor).
- [ ] Is custom CSS kept in `input.css` (globals) or `.razor.css` (scoped)?
- [ ] Is dark mode supported via `dark:` variants?
