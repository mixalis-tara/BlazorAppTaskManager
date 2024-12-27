# Task Management Web Application

## Overview

This is a **Task Management Web Application** built using **Blazor** and **ASP.NET Core 9.0**. The application allows users to manage their tasks, with features like task creation, updating, deletion, and filtering. The data is stored in a Microsoft SQL Server database using **Entity Framework Core**, and the application follows a clean architecture with separate layers for **Data**, **Services**, and **Main Application**.

## Features

- **Task Management**: Create, read, update, and delete tasks.
- **Task Filtering**: Filter tasks by priority and status.
- **Task Form**: A reusable form for creating and updating tasks.
- **Confirmation Modal**: Confirm deletion of tasks before removal.
- **Responsive UI**: Built with Bootstrap for responsive design.
- **Task Prioritization and Status Tracking**: Assign priority and status to tasks.

## Technologies Used

### Backend
- **ASP.NET Core 9.0**: Framework for building the API and web application.
- **Entity Framework Core**: ORM for database interactions.
- **Blazor**: Framework for building interactive web UIs.
  
### Database
- **MSSQL Server**: Relational database to store task data.
- **EF Tools**: Used for migrations and database updates.

### Frontend
- **Blazor Components**: Task forms, task lists, and modals are implemented as Blazor components.
- **Bootstrap**: Used for responsive and styled UI components.

## Folder Structure

- **Data**: Contains the database context (`ApplicationDbContext`) and any related models.
- **Models**: Contains the `TodoTask` model and enums for task priority and status.
- **Services**: Contains the `ITaskService` interface and `TaskService` implementation for interacting with the database.
- **Pages**: Contains the Blazor pages like `Tasks.razor` where the tasks are managed.
- **Components**: Contains reusable components like `TaskForm` and `ConfirmationModal`.

## Usage

### Task Management

- **Create, Read, Update, Delete (CRUD)**:
  - Tasks can be added, edited, or deleted through the task form and the task list UI.
  - Tasks are stored in a SQL Server database and can be filtered by priority and status.

### Task Filtering

- **Priority Filter**: Filter tasks by their assigned priority (Low, Medium, High, Urgent).
- **Status Filter**: Filter tasks by their current status (Todo, InProgress, Complete, OnHold).
- **Reset Filters**: Reset the filters to show all tasks.

### Task Form

- **Create New Task**: Add a new task by entering a title, description, priority, and status.
- **Update Task**: Edit an existing task's title, description, priority, or status.

### Confirmation Modal

- **Task Deletion**: Confirm task deletion before removing it from the database.

### Responsive UI

- The UI is built using **Bootstrap** for a clean, responsive design across devices.

## Customization

### TaskForm Component

- The `TaskForm` component can be customized to include additional task attributes or validation rules as needed.

### TaskService

- The `TaskService` handles CRUD operations for tasks and can be extended to include additional task management functionality or integrate with other services.

### Task Status and Priority

- The `TodoTaskStatus` and `PriorityLevel` enums can be updated to include additional statuses or priority levels as per your application's needs.

## Technologies & Libraries

- **Blazor**: For building interactive web UIs.
- **ASP.NET Core 8.0**: Framework for building the web application and APIs.
- **Entity Framework Core**: ORM for database interactions.
- **Bootstrap**: For responsive UI components.
- **MSSQL Server**: Relational database for storing tasks.
- **EF Tools**: For applying migrations and updating the database.
