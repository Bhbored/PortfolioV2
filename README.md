# Portfolio

A personal portfolio website built with **Blazor WebAssembly** and **.NET 10**. Features a dark-themed landing page with smooth GSAP animations, plus a full admin panel for managing all portfolio content.

## 🛠️ Tech Stack

- **Blazor WebAssembly** (.NET 10)
- **Tailwind CSS** for styling
- **GSAP** (ScrollTrigger, ScrollToPlugin) for animations
- **Material Symbols** for icons
- **JSON files** as the data store

## ✨ Features

### 🌐 Landing Page

- Hero section with animated intro
- Skills, Projects, Certificates, Education, and Experience sections
- Smooth scroll navigation and scroll-spy
- Responsive design (mobile, tablet, desktop)

### 🔒 Admin Panel

A private `/admin` section for managing all portfolio content. Each page supports inline editing, adding new entries, deleting, and exporting the updated JSON file with a "Save Changes" button.

- **Dashboard** — Overview with stats and recent data tables
- **Personal Info** — Profile details, social links, and languages
- **Skills** — Full CRUD with icon picker (searchable dropdown), category & certificate assignment, mastery slider, and detail tags
- **Categories** — Manage skill categories
- **Projects** — Manage projects with tech stacks, features, and links
- **Experience** — Work history with bullet-point descriptions
- **Education** — Academic entries
- **Certificates** — Professional certifications with associated skills

#### 📸 Admin Panel Screenshots

| Dashboard | Personal Info | Skills |
|:---:|:---:|:---:|
| ![Dashboard](https://github.com/Bhbored/PortfolioV2/blob/master/Screenshots/Screenshot%202026-04-14%20151820.png) | ![Personal Info](https://github.com/Bhbored/PortfolioV2/blob/master/Screenshots/Screenshot%202026-04-14%20151839.png) | ![Skills](https://github.com/Bhbored/PortfolioV2/blob/master/Screenshots/Screenshot%202026-04-14%20151923.png) |

| Categories | Projects | Experience |
|:---:|:---:|:---:|
| ![Categories](https://github.com/Bhbored/PortfolioV2/blob/master/Screenshots/Screenshot%202026-04-14%20151949.png) | ![Projects](https://github.com/Bhbored/PortfolioV2/blob/master/Screenshots/Screenshot%202026-04-14%20152004.png) | ![Experience](https://github.com/Bhbored/PortfolioV2/blob/master/Screenshots/Screenshot%202026-04-14%20152032.png) |

| Education | Certificates |
|:---:|:---:|:---:|
| ![Education](https://github.com/Bhbored/PortfolioV2/blob/master/Screenshots/Screenshot%202026-04-14%20152043.png) | ![Certificates](https://github.com/Bhbored/PortfolioV2/blob/master/Screenshots/Screenshot%202026-04-14%20152059.png) | *Empty* |

### 📦 Data Workflow

All data lives in `wwwroot/data/` as JSON files. The admin panel edits data in-memory, then downloads an updated JSON file. You manually replace the file in `wwwroot/data/` — no backend or database needed.

## 🚀 Getting Started

```bash
# Install Node dependencies
npm install

# Run the app
dotnet run --project Portfolio
```

Tailwind CSS and GSAP are built automatically on each `dotnet build`.

## 📂 Project Structure

```
Portfolio/
├── Components/       # Landing page sections (Hero, Skills, Projects, etc.)
├── Contracts/        # Service interfaces
├── Models/           # Data models and enums
├── Pages/
│   ├── Admin/        # Admin panel pages (CRUD + JSON export)
│   └── Home.razor    # Landing page
├── Services/         # Data access and admin utilities
├── Styles/           # Tailwind input (input.css)
└── wwwroot/
    ├── data/         # JSON data files
    └── js/           # GSAP + app.js helpers
```

## 🎨 Styling

- Dark theme with cyan (`#00f0ff`) and orange (`#ff4d00`) accents
- Ubuntu font (Light for body, Bold for headings)
- Tailwind utilities + scoped CSS overrides in `.razor.css` files

## ⚙️ Build Tooling

Tailwind and GSAP are wired into the .NET build pipeline so you never have to think about them manually.

### `.csproj` — MSBuild Integration

The `Portfolio.csproj` hooks into `BeforeBuild` to run two npm scripts automatically:

```xml
<Target Name="BuildTailwind" BeforeTargets="BeforeBuild">
  <Exec Command="npm run build:css" />
  <Exec Command="npm run build:gsap" />
</Target>
```

Every `dotnet build` compiles Tailwind and copies GSAP before the app builds.

### `package.json` — NPM Scripts

```json
{
  "scripts": {
    "build:css": "postcss Styles/input.css -o wwwroot/Styles/tailwind.css",
    "watch:css": "postcss Styles/input.css -o wwwroot/Styles/tailwind.css --watch",
    "build:gsap": "copyfiles -f ../node_modules/gsap/dist/gsap.min.js wwwroot/js/",
    "build:all": "npm run build:css && npm run build:gsap"
  }
}
```

| Script       | What it does                                                                                    |
| ------------ | ----------------------------------------------------------------------------------------------- |
| `build:css`  | Processes `Styles/input.css` through PostCSS + Tailwind → outputs `wwwroot/Styles/tailwind.css` |
| `watch:css`  | Same as above, but watches for changes during development                                       |
| `build:gsap` | Copies GSAP minified files from root `node_modules/` into `wwwroot/js/`                         |
| `build:all`  | Runs both in sequence                                                                           |

### Dev Dependencies

- **tailwindcss** + **postcss** + **autoprefixer** — CSS pipeline
- **copyfiles** — copies GSAP from root to `wwwroot/js/`

## 🔐 Admin Access

The admin panel is protected by a simple password gate. Click the 🔒 icon in the top nav bar to unlock.

- Password is stored in `wwwroot/appsettings.json` under the `AdminKey` setting
- When logged in, the icon changes to ⚙️ and clicking it takes you straight to `/admin`
- A **Logout** button lives at the bottom of the admin sidebar

## 🌍 Making This Yours

Want to use this as your own portfolio? Here's what to change:

### 1. Update Your Data

Edit the JSON files in `wwwroot/data/` with your own info, or use the admin panel to manage everything visually and download the updated files.

### 2. Set Your Admin Password

Edit `wwwroot/appsettings.json`:

```json
{
  "AdminKey": "your-secret-password-here"
}
```

. This overrides `appsettings.json` in production so your password isn't in the repo

> **Note:** This is a soft gate — it stops casual visitors but isn't cryptographically secure. Since it's all client-side, a determined person could inspect the network tab. For a personal portfolio, this is fine.

### 3. Swap the Assets

- Replace profile images in `wwwroot/images/`
- Update the font links in `wwwroot/index.html` if you want different fonts
- Change the meta tags (title, description, favicon) to match your branding
