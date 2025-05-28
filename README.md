# Todo API

A minimal RESTful API for managing todo items, built using Domain-Driven Design (DDD) principles.

## About

This project implements a simple backend for a todo application using ASP.NET Core and Domain-Driven Design (DDD). The application is structured around clearly separated concerns such as domain entities, application services, and API controllers. It supports standard CRUD operations for managing todo items, including status updates.

## Table of Contents

* [About](#about)
* [Getting Started](#getting-started)
* [Usage](#Usage)
* [Contributing](#Contributing)
* [Licensing](#Licensing)

## Getting Started

### Prerequisites

* [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download)

### Install

Clone the repository:

```bash
git clone https://github.com/your-username/todo-api.git
cd todo-api
```

### Run

To run the API locally:

```bash
dotnet run --project Todo.Api
```

## Usage

### Test with Swagger

Once the app is running, navigate to:

```
http://localhost:8080/swagger-ui/index.html
```

Use Swagger UI to interact with the endpoints.

### Endpoints

| Method | Endpoint                | Description                       |
| ------ | ----------------------- | --------------------------------- |
| GET    | `/api/item`             | Retrieves all todo items          |
| GET    | `/api/item/{id}`        | Retrieves a specific todo item    |
| POST   | `/api/item`             | Creates a new todo item           |
| PUT    | `/api/item/{id}/status` | Changes the status of a todo item |
| PUT    | `/api/item/{id}`        | Deletes a todo item               |

### Example

Creating a new item:

```http
POST /api/item
Content-Type: application/json

{
  "title": "Buy groceries",
  "description": "Milk, Bread, Eggs"
}
```

## Contributing
If you’d like to contribute, feel free to open an issue or submit a pull request. All contributions are welcome!

## Licensing
This project is licensed under the MIT License. See the [LICENSE](./LICENSE) file for details.