# Week 6 – Microservices

## Overview
This folder contains the mandatory hands-on exercises completed for Week 6 of the Cognizant Digital Nurture 4.0 .NET FSE Program.

The hands-on demonstrates the implementation of JWT (JSON Web Token) Authentication in an ASP.NET Core Web API.

---

## Hands-on Completed

### JWT Authentication API

#### Objective
Implement JWT-based authentication for a Web API to securely authenticate users and generate access tokens.

#### Features Implemented
- ASP.NET Core Web API
- JWT Token Generation
- User Login Endpoint
- Token-Based Authentication
- Swagger API Documentation
- Configuration using appsettings.json

---

## Project Structure

```
Microservices
│
├── JwtAuthenticationApi
│   ├── Controllers
│   ├── Models
│   ├── Properties
│   ├── Services
│   ├── appsettings.json
│   ├── Program.cs
│   └── JwtAuthenticationApi.csproj
│
└── README.md
```

---

## Technologies Used

- ASP.NET Core Web API (.NET 10)
- C#
- JWT Authentication
- Swagger (OpenAPI)
- Visual Studio Code

---

## API Endpoint

### Login

**POST**

```
/api/Auth/login
```

Sample Request

```json
{
  "username": "admin",
  "password": "admin123"
}
```

Sample Response

```json
{
  "token": "<JWT_TOKEN>"
}
```

---

## Outcome

Successfully implemented JWT Authentication and verified token generation using Swagger UI.

---

## Status

✅ Mandatory Hands-on Completed