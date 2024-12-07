using System.Data;
using MySql.Data.MySqlClient;
using DotNetEnv;

/* DBConnect class is used to handle the database connection.
 * Contains:
 * 3 fields: _connection, username, and password.
 * 1 constructor: DBConnect
 * 5 methods: GetConnection, EnsureConnection, CloseConnection, GetUsername, and GetPassword.
*/
public class DBConnect
{
   // _connection represents the connection to the database.
   private MySqlConnection _connection { get; set; }

   // username is used for validating user login username.
   private string username = string.Empty;

   // password is used for validating user login password.
   private string password = string.Empty;

   // DBConnect constructor initializes an instance of MySqlConnection.
   public DBConnect()
   {
      try
      { // Load the .env file and assign the values to the fields.
         Env.Load("./.env"); // Load the .env file
         username = Env.GetString("LOGINUSER");
         password = Env.GetString("LOGINPASSWORD");
         string connectDB = $"server={Env.GetString("DB_SERVER")};user={Env.GetString("DB_USERNAME")};database={Env.GetString("DATABASE")};port={Env.GetString("DB_PORT")};password={Env.GetString("DB_PASSWORD")}";

         _connection = new MySqlConnection(connectDB);
      }
      catch (MySqlException ex)
      {
         Console.WriteLine($"Error: Unable to connect to the database\nError: {ex?.ToString()}");
         throw;
      }
   }

   // GetConnection method returns the connection to the database.
   public MySqlConnection GetConnection()
   {
      return _connection;
   }

   // EnsureConnection method returns a boolean value based on database connection valid and open.
   public bool EnsureConnection()
   {
      try
      {
         if (_connection.State != ConnectionState.Open)
         { // Open the connection
            _connection.Open();
            Console.WriteLine("Connection Successful!");
         }
         if (_connection == null || _connection.State == ConnectionState.Closed)
         { // Check if the connection is null or closed
            Console.WriteLine("Error: Unable to connect to the database");
            return false;
         }
      }
      catch (MySqlException ex)
      {
         Console.WriteLine($"Connection failed... \nError: Unable to establish or validate connection\nDetails: {ex.Message}");
         return false;
      }
      return true;
   }

   // CloseConnection method closes the connection to the database.
   public void CloseConnection()
   {
      _connection?.Close();
      Console.WriteLine("Connection Closed Successfully!");
   }

   // GetUsername method returns the username
   public string GetUsername()
   {
      return username;
   }

   // GetPassword method returns the password
   public string GetPassword()
   {
      return password;
   }
}