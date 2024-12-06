# Changelog - Domend


## Table of Contents

- [Unreleased](#unreleased)
- [Released](#released)
    - [v0.1.0 - 2024-12-06](#v010---2024-12-06)

## Unreleased

## Released

### v0.1.0 - 2024-12-06

- Controllers
  - Add **AdministrationController** with a full set of CRUD endpoints for:
    - **Courses**
    - **Groups**
    - **Sites**
    - **Universities**
- Features
  - Create CRUD commands and queries for entities:
    - **Courses**
    - **Groups**
    - **Sites**
    - **Universities**
- Middlewares
  - Add **ExceptionHandlingMiddleware** that creates **ApiResponse** to wrap internal errors
- Project initialize
  - Create main entities and DTOs
    - **AcademicYear**
    - **Classroom**
    - **Course**
    - **CourseGroup**
    - **CourseSite**
    - **Group**
    - **Holiday**
    - **Schedule**
    - **Site**
    - **SiteSchedule**
    - **TravelTime**
    - **University**
  - Create dotnet solution and add projects:
    - **SgbdProject.Api**
    - **SgbdProject.Application**
    - **SgbdProject.Domain**
    - **SgbdProject.Infrastructure**
  - Database management
    - Create **ApplicationDbContext**
    - Apply initial migrations
    - Update database (Docker SQL hosted)