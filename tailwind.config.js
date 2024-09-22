/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./Pages/**/*.{html,js,razor}"],
  theme: {
    extend: {
      colors: {
        primary: {
          DEFAULT: '#0A855F',
          dark: '#0A855F',
          accentuation: '#0AA072',
        },
        secondary: {
          DEFAULT: '#512BD4',
          dark: '#3B12C8',
          accentuation: '#7352E7',
        },
        tertiary: {
          DEFAULT: '#EBC006',
          dark: '#B79918',
          accentuation: '#F9D32C',
        },
      },
    },
  },
  plugins: [],
}