# Exercise 2: Employee Management System – Stored Procedures

## 👨‍💻 Developer Info
- **Name**: Dhruv Kushwaha  
- **Assignment**: Cognizant Digital Nurture 4.0  
- **Skill**: SQL – Stored Procedures  
- **Week**: 2

---

## 🧠 Problem Statement

You are tasked with building stored procedures for an **Employee Management System** to manage employee data by department.

---

## ✅ Objectives

- Create tables: `Departments` and `Employees`
- Insert sample data into both tables
- Write and test stored procedures:
  - `sp_InsertEmployee` — to insert new employee records
  - `sp_GetEmployeesByDepartment` — to retrieve employees by department

---

## 🏗️ Table Schema

### 🔸 Departments

| Column         | Type         |
|----------------|--------------|
| DepartmentID   | INT (PK)     |
| DepartmentName | VARCHAR(100) |

### 🔸 Employees

| Column       | Type               |
|--------------|--------------------|
| EmployeeID   | INT (PK, Identity) |
| FirstName    | VARCHAR(50)        |
| LastName     | VARCHAR(50)        |
| DepartmentID | INT (FK)           |
| Salary       | DECIMAL(10,2)      |
| JoinDate     | DATE               |

## 📸 Output Screenshots

**ROW_NUMBER:**

![Output](./Output/Output.jpg)

## 🛠️ How to Run

### 📍 Setup Instructions:
1. Open **SQL Server Management Studio (SSMS)**.
2. Select or create a database named `EmployeeDB`.
3. Copy and run the script from [`employee_procedures.sql`](./employee_procedures.sql) to:
   - Create tables
   - Insert sample data
   - Define stored procedures

### ▶️ To Test Execution:
Run the following queries in SSMS after setup:

```sql
EXEC sp_InsertEmployee
    @FirstName = 'Rahul',
    @LastName = 'Sharma',
    @DepartmentID = 2,
    @Salary = 7200.00,
    @JoinDate = '2023-04-01';

EXEC sp_GetEmployeesByDepartment @DepartmentID = 2;
