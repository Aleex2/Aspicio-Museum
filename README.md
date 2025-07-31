# Aspicio Museum Application

## Description
Aspicio Museum Application is a Windows Forms application for managing an art gallery database. It allows you to manage exhibitions, artists, paintings, clients, and orders, with various queries to analyze sales, exhibitions, and artist statistics.

## Features
* Exhibition Management: Add, update, delete, and display exhibitions.
* Artist & Painting Queries: Run predefined queries showing artists, their paintings, sales, and clients.
* Complex Reports: Generate advanced reports like top-selling artists, clients attending popular exhibitions, and exhibitions filtered by theme or year.
* User-friendly UI: Interactive forms with DataGridViews and combo boxes for easy data selection.

## Structural and Functional Architecture

### 1. Presentation Layer (Windows Forms)

- **Form1:** Handles user login and authentication.
- **Form4:** Main menu/dashboard that opens other modules within an embedded panel.
- **Form5:** Manages CRUD operations on the `Artisti` (artists) table.
- Other forms (Form6, Form7, Form8, Form9) handle exhibitions, sales queries, artist/exhibition queries, and advanced reports respectively.

### 2. Data Access Layer

- Uses ADO.NET classes (`SqlConnection`, `SqlCommand`, `SqlDataAdapter`) for database communication.
- Employs parameterized SQL commands to securely perform CRUD operations.
- Data is bound to UI controls such as DataGridViews for real-time display.

### 3. Database Layer
- SQL Server database named `Arta`.
- Core tables include:
  - `Artisti` – artist information
  - `Expozitii` – exhibitions
  - `Clienti` – clients
  - `Comenzi`, `Bilete`, `Sali`, `Organizare` – orders, tickets, rooms, and event organization details.
- Relationships enforce data integrity and support complex queries.




