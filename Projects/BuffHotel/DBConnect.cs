using MySql.Data.MySqlClient;
using DotNetEnv;

public class DBConnect
{
   private MySqlConnection _connection;
   public string username = string.Empty;
   public string password = string.Empty;

   public DBConnect()
   {
      Env.Load("./.env");
      username = Env.GetString("LOGINUSER");
      password = Env.GetString("LOGINPASSWORD");
      string connectDB = ($"server={Env.GetString("DB_SERVER")};user={Env.GetString("DB_USERNAME")};database={Env.GetString("DATABASE")};port={Env.GetString("DB_PORT")};password={Env.GetString("DB_PASSWORD")}");
      _connection = new MySqlConnection(connectDB);
   }

   public bool OpenConnection()
   {
      try
      {
         _connection.Open();
         Console.WriteLine("Connection Successful!");
         return true;
      }
      catch (MySqlException ex)
      {
         Console.WriteLine("Connection failed... \nError: {0}", ex.ToString());
         return false;
      }
   }

   public void CloseConnection()
   {
      _connection.Close();
      Console.WriteLine("Connection Closed Successfully!");
   }

   // Use this method to return the connection object
   public MySqlConnection GetConnection()
   {
      return _connection;
   }
}