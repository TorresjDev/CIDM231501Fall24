using MySql.Data.MySqlClient;
using DotNetEnv;

/*
DBConnect class is used to establish a connection to the database. 
It contains methods to open and close the connection, and to retrieve the username and password stored within
*/
public class DBConnect
{
   public required MySqlConnection _connection { get; set; }
   private string username = string.Empty;
   private string password = string.Empty;

   // This constructor initializes the connection
   public DBConnect()
   {
      try
      {
         Env.Load("./.env"); // Load the .env file
         username = Env.GetString("LOGINUSER");
         password = Env.GetString("LOGINPASSWORD");
         string connectDB = $"server={Env.GetString("DB_SERVER")};user={Env.GetString("DB_USERNAME")};database={Env.GetString("DATABASE")};port={Env.GetString("DB_PORT")};password={Env.GetString("DB_PASSWORD")}";
         _connection = new MySqlConnection(connectDB); // Initialize the connection
      }
      catch (MySqlException ex)
      {
         Console.WriteLine($"Error: Unable to connect to the database\nError: {ex.ToString()}");
      }
   }

   // This method opens the connection
   public bool OpenConnection()
   {
      try
      {
         _connection?.Open();
         Console.WriteLine("Connection Successful!");
         return true;
      }
      catch (MySqlException ex)
      {
         Console.WriteLine($"Connection failed... \nFound Error: {ex.ToString()}");
         return false;
      }
   }

   // This method closes the connection
   public void CloseConnection()
   {
      _connection?.Close();
      Console.WriteLine("Connection Closed Successfully!");
   }

   // This method returns the username
   public string GetUsername()
   {
      return username;
   }

   // This method returns the password
   public string GetPassword()
   {
      return password;
   }

   // This method returns the connection
   public MySqlConnection GetConnection()
   {
      return _connection;
   }
}