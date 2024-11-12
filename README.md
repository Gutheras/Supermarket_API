# 🛒 Supermarket API

A **RESTful API** for managing supermarket products and categories. This API is designed as a practice project to showcase CRUD operations (Create, Read, Update, Delete) for categories and products. Built using **C#**, the API is fully documented and testable via **Swagger** and tools like **Postman**.

---

## ✨ Features
- **Categories**:
  - Add new categories (e.g., "Dairy").
  - Retrieve a list of all categories.
  - Update existing categories.
  - Delete categories.

- **Products**:
  - Add products to specific categories (e.g., "Milk" under "Dairy").
  - Retrieve a list of all products.
  - Update product details.
  - Delete products.

- **RESTful Operations**:
  - Supports HTTP methods: `GET`, `POST`, `PUT`, and `DELETE`.
  - Fully compliant with REST principles.

## 🛠️ Technology Stack
  - C# (.NET 8)
  - API Documentation & Testing: Swagger UI
  - Alternative Testing Tool: Postman
  - Database: In-memory or any configured database (e.g., SQL Server or SQLite)
    
## 📂 Endpoints Overview
-**Categories**
  - Method	Endpoint	Description
  - GET	/api/categories	Retrieve all categories
  - POST	/api/categories	Add a new category
  - PUT	/api/categories/{id}	Update a category by ID
  - DELETE	/api/categories/{id}	Delete a category by ID
-**Products**
  - Method	Endpoint	Description
  - GET	/api/products	Retrieve all products
  - POST	/api/products	Add a new product
  - PUT	/api/products/{id}	Update a product by ID
  - DELETE	/api/products/{id}

## 📖 Usage
-**Testing with Swagger**
  - Launch the application and open Swagger UI (http://localhost:5000/swagger).
  - Use the interactive UI to send GET, POST, PUT, and DELETE requests to the API.
  - Swagger will auto-generate input fields and example requests for each endpoint.
-**Testing with Postman**
  - Open Postman and create a new collection.
  - Use the following request examples:
  - Adding a Category:
  - Method: POST
  - URL: https://localhost:44360/api/categories
  - Body:
```json
{
  "name": "Dairy"
}```
-**Adding a Product:**
  - Method: POST
  - URL: https://localhost:44360/api/products
Body:
```json{
  "name": "Milk",
  "quantityInPackage": 15,
  "unitOfMeasurement": 5,
  "categoryId": 1
}```
-**Retrieving All Categories:**
  - Method: GET
  - URL: https://localhost:44360/api/categories
-**Updating a Product:**
  - Method: PUT
  - URL: https://localhost:44360/api/products/1
Body:
```json
Copy code
{
  "name": "Low-fat Milk",
  "categoryId": 1
}```
-**Deleting a Category:**
  - Method: DELETE
  - URL: https://localhost:44360/api/categories/1
    
    
