# Changelog - SGBD Project - University Schedule Manager

All notable changes to the Dcare Web Client project will be documented in this file.

## Table of Contents

- [Unreleased](#unreleased)
- [Released](#released)
    - [v0.1.0 - 2025-25-01](#v010---2025-25-01)

## Unreleased


## Released

### v0.1.0 - 2025-25-01

- Demo environment
  - Create demo environment with slice, pages with minimal business logic to demonstrate the use of the application
- Initial setup
    - Configure **Provider** component to instantiate all required providers and router in one place
    - Configure **router** that will handle routing operation and loading data for some routes
    - Add *HttpClient** gateways (including Axios, and fetch implementation)
  - Internationalisation:
      - Configure **i18next** / **react-i18next** to handle internationalisation
      - Add browser language detection
      - Add translation file for **en** / **fr** / **nl** languages
  - UI
      - Add **themeExtension** to start extending Chakra UI theme
      - Add **NavBar** component
      - Add **SideBar** component
  - Create **ViteJS** project in Typescript
  - Configure linting tools
  - Configure state manager **Redux toolkit** with persistance using **Redux persist**
  - Install and configure **Storybook** for component development and testing
  - Testing
      - Install **Vitest**
      - Create state builder
      - Create state builder provider
      - Create **demo** slice and first unit test to demonstrate use of testing flow
  - Install 3rd-party libraries
    - See **package.json** content for more details
