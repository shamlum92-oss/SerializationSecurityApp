# Serialization & Security App (.NET 10)

A secure backend utility project focused on robust data serialization, cryptographic hashing, and safe data transfer patterns in C#.

## 🚀 Key Features
* **Secure Hashing:** Implements SHA256 cryptographic hashing to ensure data integrity and verification.
* **Safe Serialization:** Utilizes `System.Text.Json` for structured and reliable object serialization and deserialization.
* **Security Controls:** Validates data sources and request payloads to protect against common injection vulnerabilities.
* **API Architecture:** Structured routing via dedicated controllers (`SecureTransactionController.cs`) and robust request models.

## 🛠️ Tech Stack
* **Language:** C# 12 / .NET 10
* **Framework:** ASP.NET Core Web API
* **Security & Cryptography:** `System.Security.Cryptography`

## 📂 Project Structure
* `Program.cs` - Application configuration, middleware, and service pipeline setup.
* `controller/` - Contains API endpoints (e.g., `SecureTransactionController.cs`).
* `model/` - Defines secure transaction request schemas and data transfer objects.
* `Properties/launchSettings.json` - Local execution and environment profiles.

## ⚙️ Getting Started
1. Clone the repository:
   ```bash
   git clone [https://github.com/shamlum92-oss/SerializationSecurityApp.git](https://github.com/shamlum92-oss/SerializationSecurityApp.git)
