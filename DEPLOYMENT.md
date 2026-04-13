# Deployment Guide — Netlify

## Project Overview

This is a **Blazor WebAssembly (WASM) SPA** portfolio site built on .NET 10. It uses:
- **Tailwind CSS** — compiled via PostCSS CLI (build-time)
- **GSAP** — copied from node_modules to `wwwroot/js/` (build-time)
- **Static JSON data** — served from `wwwroot/data/`
- **No server-side API** — fully static, deploys to any CDN/host

---

## Before Deploying — Checklist

### 1. Update Data Files
All portfolio content lives in `Portfolio/wwwroot/data/`. Update these before going live:

| File | What to Change |
|------|---------------|
| `Person.json` | Your name, title, email, phone, location, summary, headline, profile image URL, social links, languages |
| `Educations.json` | Your education history (title, institution, year) |
| `Experiences.json` | Your work experience (title, company, period, description bullets) |
| `Projects.json` | Your projects (title, description, image URL, category enum number, tech stack, GitHub/live URLs, features, screenshots) |
| `Certificates.json` | Your certificates (title, issuer, year, link, top skills) |
| `SkillCategories.json` | Skill categories (id, category name) |
| `Skills.json` | Individual skills (title, icon enum number, category ID, certificate ID, mastery %, isNew flag, details) |

### 2. Replace Placeholder Images
- `Portfolio/wwwroot/images/` — replace any placeholder images with your own
- Update `ProfileImage` in `Person.json` to point to your actual photo
- Update `ImageUrl` in `Projects.json` to match your project screenshots
- Update `Screenshots` arrays to point to real image paths

### 3. Update `index.html`
- `<title>` tag — change from "BH DEVELOPER NOIR" to your name/brand
- Optionally update the meta viewport, description, and any social/meta tags
- The loading screen title "BH" / "DEVELOPER NOIR" is hardcoded in `index.html` inside the `#app` div

### 4. Update `favicon.png` and `icon-192.png`
- Replace the default Blazor icons in `Portfolio/wwwroot/` with your own

### 5. No `Portfolio.csproj` Changes Needed
The `.csproj` is already configured correctly for static deployment:
```xml
<Target Name="BuildTailwind" BeforeTargets="BeforeBuild">
    <Exec Command="npm run build:css" />
    <Exec Command="npm run build:gsap" />
</Target>
```
This ensures Tailwind and GSAP are built automatically on every `dotnet publish`.

### 6. Ensure `npm install` Ran
Before building, make sure `node_modules` is populated in the `Portfolio/` directory:
```bash
cd Portfolio
npm install
```
Or if deploying via CI/CD, add `npm install` to the build pipeline.

---

## Build Command

Run from the **`Portfolio/`** directory (the one containing the `.csproj`):

```bash
cd Portfolio
dotnet publish -c Release -o ../publish
```

This will:
1. Run `npm run build:css` → compiles Tailwind from `Styles/input.css` → `wwwroot/Styles/tailwind.css`
2. Run `npm run build:gsap` → copies GSAP files from `../node_modules/` → `wwwroot/js/`
3. Publish the Blazor WASM app to `../publish/wwwroot/`

The **output folder for deployment** is: `publish/wwwroot/`

---

## `netlify.toml`

Place this file in the **root** of your repository (same level as `Portfolio.slnx`):

```toml
[build]
  base = "Portfolio"
  command = "dotnet publish -c Release -o ../publish"
  publish = "../publish/wwwroot"

[build.environment]
  # .NET 10 SDK
  DOTNET_VERSION = "10.0.x"

# SPA routing — serve index.html for all client-side routes
[[redirects]]
  from = "/*"
  to = "/index.html"
  status = 200

# Security headers
[[headers]]
  for = "/*"
  [headers.values]
    X-Frame-Options = "DENY"
    X-Content-Type-Options = "nosniff"
    Referrer-Policy = "strict-origin-when-cross-origin"

# Cache static assets aggressively
[[headers]]
  for = "/_framework/*"
  [headers.values]
    Cache-Control = "public, max-age=31536000, immutable"

[[headers]]
  for = "/*.js"
  [headers.values]
    Cache-Control = "public, max-age=86400"

[[headers]]
  for = "/*.css"
  [headers.values]
    Cache-Control = "public, max-age=86400"

[[headers]]
  for = "/data/*.json"
  [headers.values]
    Cache-Control = "public, max-age=3600"
```

---

## Deploying via GitHub → Netlify

### Option A: Netlify UI
1. Go to [app.netlify.com](https://app.netlify.com)
2. Click **"Add new site"** → **"Import an existing project"**
3. Connect your GitHub repo
4. Netlify will auto-detect the `netlify.toml` in the root
5. Click **"Deploy site"**

### Option B: Netlify CLI
```bash
npm install -g netlify-cli
netlify login
netlify init       # link repo
netlify deploy      # deploy preview
netlify deploy --prod   # deploy to production
```

### Option C: GitHub Actions
If you prefer a CI/CD pipeline, create `.github/workflows/deploy.yml`:

```yaml
name: Deploy to Netlify

on:
  push:
    branches: [main]

jobs:
  deploy:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4

      - name: Setup .NET
        uses: actions/setup-dotnet@v4
        with:
          dotnet-version: '10.0.x'

      - name: Install Node
        uses: actions/setup-node@v4
        with:
          node-version: '20'

      - name: Install npm deps
        working-directory: Portfolio
        run: npm install

      - name: Publish
        working-directory: Portfolio
        run: dotnet publish -c Release -o ../publish

      - name: Deploy to Netlify
        uses: nwtgck/actions-netlify@v3
        with:
          publish-dir: './publish/wwwroot'
          production-deploy: true
          github-token: ${{ secrets.GITHUB_TOKEN }}
          enable-commit-comment: false
        env:
          NETLIFY_AUTH_TOKEN: ${{ secrets.NETLIFY_AUTH_TOKEN }}
          NETLIFY_SITE_ID: ${{ secrets.NETLIFY_SITE_ID }}
```

---

## Post-Deployment Verification

1. **Check all routes work** — refresh any page to ensure SPA routing handles it
2. **Verify data loads** — check browser DevTools Network tab for `data/*.json` files (should return 200)
3. **Check Tailwind compiled** — inspect any element to verify CSS classes are applied (not showing raw Tailwind utility names)
4. **Test GSAP animations** — scroll through all sections, check horizontal sliding works on Projects/Skills/Certificates/Education
5. **Mobile responsive** — test on phone viewport, verify horizontal scroll works on skills/certificates/education

---

## Troubleshooting

| Issue | Fix |
|-------|-----|
| Tailwind styles not showing | Run `cd Portfolio && npm install && npm run build:css` manually, check `wwwroot/Styles/tailwind.css` exists |
| GSAP not loading | Run `npm run build:gsap`, verify `wwwroot/js/gsap.min.js` exists |
| JSON data returns 404 | Ensure `wwwroot/data/*.json` files exist in the published output |
| Blank page after deploy | Check browser console for .NET WASM boot errors, verify `_framework/blazor.webassembly.js` is present |
| Page not found on refresh | Ensure `netlify.toml` redirect rule (`/*` → `/index.html`) is active |
