# Copilot Instructions for CSharp3Template

## Project Overview
- This repository is a template for Czechitas C#/.NET courses, supporting both sandbox exercises and a final project (ToDoList).
- Main folders:
  - `/ToDoList`: Final project (see `ToDoList/Readme.md` for structure: `/data`, `/docs`, `/src`, `/tests`).
  - `/sandbox`: Practice area, contains katas and exercises (see `sandbox/Readme.md`).
  - `/wiki`: Course wiki and reference materials (start at `wiki/00 StartHere.md`).
  - `/manuals`: Keyboard shortcuts, workflow guides, and course manuals.

## Architecture & Patterns
- Projects are organized by solution folders, e.g. `FizzBuzz.01/FizzBuzz.sln` for exercises.
- C# code follows standard .NET conventions, but project structure is tailored for learning:
  - Each kata/exercise is self-contained (solution, project, code, and test folders).
  - Final project (`ToDoList`) is split into clear subfolders for code, data, docs, and tests.
- Example pattern: `FizzBuzz` class in `FizzBuzz.cs` with a public method called from `Program.cs`.

## Workflows
- **Build/Run:**
  - Use `dotnet build` and `dotnet run` in the relevant project folder.
  - For exercises, open the solution folder and run commands as shown in `FizzBuzz.01/00 StartHere.md`.
- **Testing:**
  - Test projects use xUnit (`dotnet new xunit`).
  - Add test projects to solution with `dotnet sln add <TestProject>`.
- **VS Code Profile:**
  - Import `csharp3.code-profile` for recommended editor settings.
- **Formatting:**
  - `.editorconfig` enforces code style.

## Conventions & Integration
- All code should be in English, comments may be in Czech for learning purposes.
- Data access uses Entity Framework Core (see wiki and `ToDoList/02 EntityFrameworkSetup.md`).
- SQLite is the default database for projects.
- Web projects use ASP.NET Core and Blazor (see wiki for references).
- Version control: Use branches for assignments, follow guides in `manuals/Jak odevzdat domácí úkol/`.

## Key References
- `README.md` (repo overview)
- `ToDoList/Readme.md` (final project structure)
- `sandbox/Readme.md` (practice area)
- `wiki/00 StartHere.md` (course reference)
- `FizzBuzz.01/00 StartHere.md` (example workflow)

---
For unclear workflows or missing conventions, check the relevant `Readme.md` or wiki page first. If a pattern is not documented, prefer standard .NET/C# practices.
