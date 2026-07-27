# Lab 5 - JWT Authentication in ASP.NET Core Web API

## Objective

Implement JSON Web Token (JWT) Authentication in an ASP.NET Core Web API to secure API endpoints and allow only authenticated users to access protected resources.

---

## Technologies Used

- ASP.NET Core Web API (.NET 10)
- C#
- JWT (JSON Web Token)
- Swagger
- Postman
- Visual Studio Code

---

## Project Structure

```
EmployeeSecureApi
│
├── Controllers
│   ├── AuthController.cs
│   └── TestController.cs
│
├── Models
│   ├── LoginModel.cs
│   └── TokenResponse.cs
│
├── Program.cs
├── appsettings.json
└── README.md
```

---

## Features

- JWT Authentication
- Token Generation
- Protected API using `[Authorize]`
- Swagger Integration
- Postman Testing

---

## API Endpoints

### 1. Login

**POST**

```
/api/Auth/login
```

Request

```json
{
  "username": "admin",
  "password": "admin123"
}
```

Success Response

```json
{
  "token": "JWT_TOKEN"
}
```

---

### 2. Protected API

**GET**

```
/api/Test
```

Authorization

```
Bearer <JWT_TOKEN>
```

Response

```
Protected API Access Granted
```

---

## JWT Configuration

Configured in **appsettings.json**

```json
"Jwt": {
  "Key": "ThisIsMySecretKeyForJwtAuthentication12345",
  "Issuer": "EmployeeSecureApi",
  "Audience": "EmployeeSecureApi",
  "ExpiryInMinutes": 60
}
```

---

## Authentication Flow

```
User Login
      │
      ▼
POST /api/Auth/login
      │
      ▼
Generate JWT Token
      │
      ▼
Client stores Token
      │
      ▼
Bearer Token
      │
      ▼
GET /api/Test
      │
      ▼
JWT Validation
      │
      ▼
Protected API Access Granted
```

---

## Testing

### Swagger

1. Run the project

```
dotnet run
```

2. Open

```
http://localhost:5034/swagger
```

3. Login using

```
admin
admin123
```

4. Copy the generated JWT Token.

5. Click **Authorize** in Swagger.

6. Enter

```
Bearer <JWT_TOKEN>
```

7. Access the protected endpoint.

---

### Postman

#### Login

```
POST
http://localhost:5034/api/Auth/login
```

Body

```json
{
  "username": "admin",
  "password": "admin123"
}
```

#### Protected API

```
GET
http://localhost:5034/api/Test
```

Authorization

```
Bearer Token
```

Paste the generated JWT Token.

---

## Expected Output

Login API

```
200 OK
```

```json
{
  "token": "<Generated JWT Token>"
}
```

Protected API

```
200 OK
```

```
Protected API Access Granted
```

---

## Learning Outcomes

- Understanding JWT Authentication
- Securing ASP.NET Core Web APIs
- Token Generation and Validation
- Using Authorization Middleware
- Testing Secure APIs with Swagger and Postman

---

## Author

**Nazia Quadri**

Cognizant DotNet FSE Training