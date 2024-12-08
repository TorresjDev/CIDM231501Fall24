# Buff Hotel Management System Documentation

### **Project Overview**

The Buff Hotel Management System is a terminal-based application designed to manage hotel reservations and room statuses efficiently. This application features user authentication and dynamic room management capabilities.

---

### **Getting Started**

1. **Access Credentials**:

   - **Username**: `alice`
   - **Password**: `alice123`

2. **Running the Program**:
   - Clone the repository and navigate to the project directory.
   - Modify env credentials.
   - Build and run the project:
     ```bash
     dotnet build
     dotnet run
     ```

---

### **Features and Menu Options**

1. **Show Available Rooms**:

   - Lists all rooms currently available for reservation.

2. **Check-In**:

   - Enter room capacity and reserve customer to an available room.

3. **Show Active Reservations**:

   - Displays all ongoing reservations.

4. **Check-Out**:

   - Processes customer check-out and updates the room's availability.

5. **Show All Rooms**:

   - Displays a complete list of rooms grouped by their status.

6. **Show Completed Reservations**:

   - Lists all past reservations marked as completed.

7. **Show All Reservations**:

   - Displays a comprehensive list of all reservations (active and completed).

8. **Log Out**:
   - Exits the system securely.

---

### **Key Components**

1. **Authentication**:

   - Ensures DB access is limited to authorized personnel.

2. **Dynamic Room and Reservation Management**:

   - Allows real-time updates for room availability and reservation statuses.

3. **Error Handling**:

   - Provides clear feedback for invalid inputs or system errors.

4. **Extensibility**:
   - Modular design supports future enhancements and new features.

---

### **Developer Notes**

1. **Code Organization**:

   - Core classes:
   - `DBConnect`: Manages database connectivity.
   - `Service`: Manages database interactions for rooms and reservations.
   - `HotelController`: Integrates user input with system operations.

2. **Testing**:
   - Use DB mock data for testing all menu options and workflows.
   - Validate Hotel services for room availability and reservation processes.

---

### **Troubleshooting**

1. **Common Errors**:

   - _Database connection issues_: Verify `.env` settings must be hardcoded when debugging.
   - _Stored procedure errors_: Ensure all SQL scripts exists and are executing in the database.
   - _Login failures_: Confirm the hardcoded credentials.

2. **Debugging**:
   - Set breakpoints in `Program.cs`, `Controller.cs` and `Service.cs` for detailed debugging.
   - Check console output for error messages.

---

### **Contact**

For assistance or feedback, contact the project developer: **Jesus Torres**.
