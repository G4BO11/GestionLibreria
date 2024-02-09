/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    './Pages/**/*.cshtml',
    './Views/**/*.cshtml'
],
  theme: {
    extend: {
      fontFamily:{
        sans: ['Dm Sans','sans-serif']
      }
    },
  },
  plugins: [],
}

