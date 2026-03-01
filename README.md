# 🛡️ Strict Data Entry System
**A robust Desktop Application built with a focus on data integrity, clean architecture, and decoupled design.**

---

## 🚀 Project Overview
This system is designed for high-precision data entry, ensuring that all inputs follow strict business rules before reaching the database. It features a responsive WinForms GUI and a scalable backend.

### 🛠️ Stack & Technologies
**Core:** C# | WinForms | SQL Server  
**Architecture:** 3-Tier Architecture (Presentation, Business Logic, Data Access)  
**ORM:** Entity Framework Core (with Manual DbContext Injection)

### 🧩 Design Patterns & Principles
* **Repository Pattern:** Decouples the data access logic from the business logic.
* **Specification Pattern:** Encapsulates query logic into reusable, testable classes (e.g., `GetByVehicleNumWithTrackingSpec`).
* **Manual Dependency Injection:** Handled manually to maintain control over the DbContext lifecycle without a DI container.
* **Unit of Work (Implicit):** Managed through the Repository for consistent data transactions.

---

## 🏗️ Architecture Visualization


The project is structured to ensure a **Separation of Concerns**:
1.  **DAL:** Contains Entities, Migrations, and the Generic Repository implementation.
2.  **BLL:** Contains Business Services and the Specific Specifications.
3.  **PL:** The WinForms UI that interacts only with the BLL.

---

## 🔒 Security & Integrity
* **Strict Validation:** Multi-level validation at the UI and Database levels.
* **Tracking Management:** Explicit control over EF Core Change Tracking for performance and data consistency.
