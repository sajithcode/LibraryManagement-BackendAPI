# LibraryManagement-BackendAPI

A .NET 8 ASP.NET Core Web API for managing a library system, including user authentication and book CRUD operations.

## Description

This backend API provides endpoints for user registration, login, and managing books in a library. It uses JWT for authentication, SQLite as the database, and Entity Framework Core for ORM. The API is designed to work with a React frontend for a complete library management system.

## Features

- User registration and login with JWT authentication
- CRUD operations for books (Create, Read, Update, Delete)
- SQLite database with Entity Framework migrations
- Swagger/OpenAPI documentation
- CORS enabled for frontend integration
- Secure API with Bearer token authentication

## Prerequisites

- .NET 8 SDK
- SQLite (included with .NET)

## Installation

1. Clone the repository:

   ```
   git clone https://github.com/sajithcode/LibraryManagement-BackendAPI.git
   ```
2. Navigate to the `LibraryManagement-BackendAPI`:

   ```
   cd LibraryManagement-BackendAPI
   ```

3. Restore the dependencies:

   ```
   dotnet restore
   ```

4. Apply database migrations:
   ```
   dotnet ef database update
   ```

## Running the Application

1. Start the application:

   ```
   dotnet run
   ```

2. The API will be available at `https://localhost:7107` (or the port specified in `launchSettings.json`).

3. In development mode, Swagger UI is available at `https://localhost:7107/swagger`.

## API Endpoints

### Authentication

- `POST /api/auth/register` - Register a new user
- `POST /api/auth/login` - Login and receive JWT token

### Books (Requires Authentication)

- `GET /api/books` - Get all books
- `GET /api/books/{id}` - Get book by ID
- `POST /api/books` - Create a new book
- `PUT /api/books/{id}` - Update a book
- `DELETE /api/books/{id}` - Delete a book

## Database

The application uses SQLite with the database file `library.db` in the project root. Migrations are handled via Entity Framework Core.

To create a new migration (if schema changes):

```
dotnet ef migrations add MigrationName
```

To update the database:

```
dotnet ef database update
```

## Configuration

Configuration is managed via `appsettings.json`:

- Database connection string
- JWT settings (key, issuer, audience, expiration)
- Logging levels

For development, use `appsettings.Development.json` to override settings.

## Authentication

The API uses JWT Bearer tokens for authentication. After logging in, include the token in the `Authorization` header as `Bearer {token}` for protected endpoints.

## Testing

Use tools like Postman or the included Swagger UI to test the endpoints. The `.http` file in the project root contains sample requests.

## CORS

CORS is configured to allow requests from `http://localhost:5173` (default Vite dev server port for the frontend).

## Dependencies

- ASP.NET Core
- Entity Framework Core with SQLite
- JWT Bearer Authentication
- Swagger
