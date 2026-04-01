# Rules

## Architecture & Code Quality

1. **Separation of Concerns**: Razor components handle only markup, input, and display. All business logic, data fetching, and state management must reside in injected services.
2. **Dependency Injection**: All services must be injected via `[Inject]` or constructor. Never instantiate services manually (`new MyService()`).
3. **Async/Await**: All I/O operations (JS Interop, HTTP, LocalStorage) must use `async/await`. Never use `.Result` or `.Wait()`.
4. **JS Interop Cleanup**: Any component using `IJSRuntime` or GSAP must implement `IAsyncDisposable` and properly dispose references to prevent memory leaks.
5. **GSAP Lifecycle Safety**: GSAP timelines/tweens must be killed before component disposal.
6. **Error Handling**: Wrap all service calls in `try/catch`. Display user-friendly error states; never crash the UI.

## Styling & Design System

7. **Token-First Styling**: Use Tailwind utilities (95%) for styling. Custom CSS (5%) is reserved for CSS variables, global resets, and scoped overrides only.
8. **No Hardcoded Values**: Never use hardcoded hex colors or pixel values. Use semantic Tailwind classes mapped to CSS variables.
9. **Scoped CSS Rules**: Custom CSS must use CSS variables (`var(--color-primary)`), not hardcoded colors. Keep in `.razor.css` files.
10. **Animation Conflict**: Do not animate the same property with both Tailwind transitions and GSAP simultaneously.

## Developer Noir Design System

11. **Color Palette**: Use the defined theme colors:
    - Background: `#0a0a0f` (Primary), `#141419` (Secondary), `#050508` (Tertiary)
    - Accent: `#00f0ff` (Electric Cyan), `#ff4d00` (Magma Orange)
    - Text: `#ffffff` (Primary), `#a1a1aa` (Secondary), `#71717a` (Tertiary)
    - Border: `rgba(255,255,255,0.1)` default, `rgba(0,240,255,0.5)` hover

12. **Typography**: Space Grotesk font family with defined scale:
    - Hero: 120px/700/-0.04em | H1: 64px/700 | H2: 48px/600 | H3: 32px/600
    - Body: 16px/400/1.6 | Caption: 14px/400

13. **Spacing Scale**: Use consistent spacing tokens: xs(4px), sm(8px), md(16px), lg(24px), xl(32px), 2xl(48px), 3xl(64px), 4xl(96px).

14. **Effects**: Apply defined effects consistently:
    - Glassmorphism: bg-opacity-5, backdrop-blur-xl, border-white/10
    - Glow: `box-shadow: 0 0 20px rgba(0,240,255,0.3)`
    - Gradient: `linear-gradient(135deg, #00f0ff 0%, #ff4d00 100%)`

15. **Component States**: Implement all states:
    - Hover: Lift -4px, border glow, scale 1.02
    - Active: Scale 0.98, inset shadow
    - Focus: Cyan outline, 2px offset

16. **Responsive Design**: Support all breakpoints with adaptation rules:
    - Mobile (375px): Single column, 60% type scale, hamburger menu
    - Tablet (768px): 2-column grids, 80% type scale, 44px min touch targets
    - Desktop (1440px): Full layouts, hover interactions, maximum visual impact.

17. Follow the structure of the folder I laid for you.

18. Use Tailwind for simple animation (e.g. slide fade), GSAP for complex animation which are yet to be defined - I will provide them later.

19. Don't touch the app.css - leave it clean. The theme variables and global custom CSS are to be added to input.css.

20. For the fonts use Ubuntu-light for the normal text and Ubuntu-bold for the titles. I already added the CSS code in input.css and the links in the index.html.

21. Sometimes I will paste code for you to make the UI based on it - override the colors, fonts, and sizes based on what's written in the rules and apply the rest.

22. alwasy make the componenet responsive for different screens sizes
