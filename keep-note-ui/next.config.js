/** @type {import('next').NextConfig} */
const nextConfig = {
  env: {
    apiURL: 'https://keepnoteapi.barissamur.com/api/notes',
  },
  output: 'export'
}

module.exports = nextConfig
