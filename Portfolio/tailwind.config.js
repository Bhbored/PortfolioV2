/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./**/*.{razor,cshtml,html,js}",
    "!./node_modules/**"
  ],
  theme: {
    extend: {
      colors: {
        'primary': '#00f0ff',
        'primary-container': '#00d0e0',
        'secondary': '#ff4d00',
        'secondary-container': '#ff571a',
        'accent-cyan': '#00f0ff',
        'accent-orange': '#ff4d00',
        'outline-variant': '#3b494b',
        'surface-container-high': '#141419',
        'surface-container-highest': '#1a1a24',
        'surface-container-low': '#1b1b20',
        'background': '#0a0a0f',
        'on-surface': '#ffffff',
        'on-surface-variant': '#a1a1aa',
        'on-secondary': '#ffffff',
      },
      fontFamily: {
        'headline': ['Ubuntu', 'sans-serif'],
        'body': ['Ubuntu', 'sans-serif'],
        'label': ['Ubuntu', 'sans-serif'],
      },
      boxShadow: {
        'glow-cyan': '0 0 20px rgba(0, 240, 255, 0.3)',
        'glow-orange': '0 0 20px rgba(255, 77, 0, 0.3)',
      },
      scale: {
        '102': '1.02',
      },
    },
  },
  plugins: [],
}
