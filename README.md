# Currency_App

## Introduction

**Currency App** is a WPF application designed to display currency-related information in a dynamic and modular way. The application is built with maintainability and scalability in mind, using modern software architecture principles like the **MVVM pattern** and **Dependency Injection (DI)**.

The interface is composed of interchangeable user controls (such as `NavBarView` and `SideBarView`) that are dynamically loaded into the main window through user interaction.

---

## Requirements

- [.NET 8.0 or later](https://dotnet.microsoft.com/)
- Visual Studio 2022 or later (with WPF and .NET Desktop Development workload)
- [MahApps.Metro](https://github.com/MahApps/MahApps.Metro) (for styling)

---

## MVVM Pattern

This project follows the **Model-View-ViewModel (MVVM)** pattern to separate the concerns of UI (View), logic (ViewModel), and data (Model):

- **Model**: Encapsulates the business logic and data (e.g., navigation links, currency models).
- **View**: XAML files (e.g., `MainWindow`, `NavBarView`, `SideBarView`) responsible for displaying UI components.
- **ViewModel**: Bridges the View and Model. It exposes data and commands to the UI through data binding (e.g., `MainWindowViewModel`, `NavBarMenuViewModel`).

This pattern promotes:
- Better separation of concerns
- Improved testability
- Easier code maintenance and scalability

---

## Dependency Injection (DI)

The project uses **Microsoft.Extensions.DependencyInjection** to manage dependencies:

- All **ViewModels** and **Views** are registered in the `Bootstrapper` class.
- `App.xaml.cs` initializes the DI container during the `OnStartup()` method and stores the `ServiceProvider`.
- Views and ViewModels are injected wherever needed, especially when dynamically loading components into the UI.
  
Example of service registration:

```csharp
services.AddSingleton<MainWindowViewModel>();
services.AddTransient<NavBarView>();
services.AddTransient<SideBarView>();
