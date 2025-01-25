# SGBD Project - Frontend web application


## Table of Contents
- [Description](#description)
- [Dependencies](#dependencies)
  - [Build Tools](#build-tools)
  - [Core Dependencies](#core-dependencies)
  - [State Management](#state-management)
  - [Form Handling and Validation](#form-handling-and-validation)
  - [Networking](#networking)
  - [Utility Libraries](#utility-libraries)
  - [Internationalization](#internationalization)
  - [UI and Animations](#ui-and-animations)
  - [Testing](#testing)
  - [Linting and Formatting](#linting-and-formatting)
  - [Storybook](#storybook)

---

## Description

This web application aims to consume and manage the business logic of the SGBD project. This project leverages a modern frontend stack with React, Vite, Redux Toolkit, and Storybook to provide an efficient development environment. The tools and libraries used ensure code quality, scalability, and maintainability across the application.

---

## CLI Commands

* Download the project:
```sh
git clone https://github.com/nikoden-io/sgbd-project
```

* Install dependencies:
```sh
cd project/clone/path
npm install
```

* Run the development server:
```sh
npm run dev
```

* Run Storybook (components library manager):
```sh
npm run storybook
```

--- 

## Dependencies


### Build Tools

#### TypeScript
- **`typescript`**
    - Adds static type-checking to JavaScript for better maintainability.
- **`ts-jest`**
    - TypeScript preprocessor for Jest testing.

#### Vite
- **`vite`**
    - Fast build tool and development server.
- **`vite-tsconfig-paths`**
    - Enables support for TypeScript path aliases in Vite.
- **`@vitejs/plugin-react`**
    - Vite plugin to optimize React support.

--- 

### Core Dependencies

#### React
- **`react`, `react-dom`**
    - Provides the core functionality to build the user interface components and manage component rendering.

--- 

### State Management

#### Redux Toolkit
- **`@reduxjs/toolkit`**
    - Official Redux package offering opinionated state management solutions with simplified API.
- **`react-redux`**
    - React bindings for Redux, enabling efficient state connection in components.
- **`redux-persist`**
    - Provides persistence functionality to store and rehydrate Redux state.
- **`redux-persist-transform-encrypt`**
    - Adds encryption layer to persisted Redux state.

----

### Form Handling and Validation

#### React Hook Form
- **`react-hook-form`**
    - Provides performant, flexible, and extensible form handling for React applications.

#### Yup
- **`yup`**
    - Schema validation library often used in conjunction with form handling solutions.

--- 

### Networking

#### Axios
- **`axios`**
    - Promise-based HTTP client for making API requests in the application.

---

### Utility Libraries

#### date-fns
- **`date-fns`**
    - Provides utility functions to manipulate and format dates efficiently.

#### Lodash
- **`lodash`**
    - Utility library offering various helper functions for data manipulation and functional programming.

--- 

### Internationalization

#### react-i18next
- **`react-i18next`**
    - Internationalization framework for React, providing language translations and localization features.
    - 
--- 

### UI and Animations

#### react-icons
- **`react-icons`**
    - Icon library that provides a wide range of vector icons for UI design.

#### lottie-react
- **`lottie-react`**
    - Library to render Lottie animations in React applications.

--- 

### Testing

#### Jest
- **`jest`**
    - JavaScript testing framework designed to ensure code reliability through unit tests.

#### ts-jest
- **`ts-jest`**
    - Jest preset to support testing TypeScript code.

#### Vitest
- **`vitest`**
    - Vite-native testing framework offering fast and lightweight unit testing.

--- 

### Linting and Formatting

#### ESLint
- **`eslint`**
    - Linter tool to enforce code quality and consistency.

##### ESLint Plugins
- **`eslint-config-prettier`** - Disables conflicting ESLint rules when using Prettier.
- **`eslint-plugin-import`** - Ensures consistent imports.
- **`eslint-plugin-jsx-a11y`** - Checks for accessibility best practices in JSX.
- **`eslint-plugin-prettier`** - Integrates Prettier with ESLint.
- **`eslint-plugin-react`** - Enforces React best practices.
- **`eslint-plugin-react-hooks`** - Ensures correct usage of React hooks.
- **`eslint-plugin-storybook`** - Enforces Storybook-specific linting rules.

#### Prettier
- **`prettier`** code style.

--- 

### Storybook

- **`storybook`** - Component-driven UI development environment.
- **`@storybook/react`** - Storybook integration for React.
- **`@storybook/react-vite`** - Optimized Storybook setup for Vite.
- **`@storybook/addon-essentials`** - Collection of essential addons for Storybook.
- **`@storybook/addon-interactions`** - Enables testing component interactions.
- **`@storybook/addon-onboarding`** - Provides onboarding experience for new developers.
- **`@storybook/blocks`** - Block-based design components for documentation.
- **`@storybook/test`** - Testing utilities for Storybook components.
- **`@chromatic-com/storybook`** - Visual testing tool integration with Storybook.

---
