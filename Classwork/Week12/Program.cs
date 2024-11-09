﻿namespace Week12;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using DotNetEnv;
class Program
{

    static void Main(string[] args)
    {
        Env.Load("../../.env");
        // Connect to MySQL database with .Net and DotNetEnv
        string connectDB = ($"server={Env.GetString("DB_SERVER")};user={Env.GetString("DB_USERNAME")};database={Env.GetString("DATABASE")};port={Env.GetString("DB_PORT")};password={Env.GetString("DB_PASSWORD")}"); // connection string
        MySqlConnection conn = new MySqlConnection(connectDB);
        try
        {
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();
            Console.WriteLine("Connected Successfully!");

            // // ? Example 1
            // Console.WriteLine("Selecting all users with role Engineering");
            // // Select all the rows from the User table where the role is Engineering
            // string sqlSelectByRole_Engineering = "SELECT username, password, role FROM User WHERE role='Engineering'";
            // // the SQL query to be executed is passed to the MySqlCommand along with the connection object
            // MySqlCommand cmd1 = new MySqlCommand(sqlSelectByRole_Engineering, conn);

            // // ExecuteReader to query the database.
            // // MySqlDataReader object contains the results generated by the SQL executed on the MySqlCommand object.
            // MySqlDataReader rdr1 = cmd1.ExecuteReader(); //cmd.ExecuteReader() returns the response from the database

            // // the information stored in MySqlReader is printed out by a while loop
            // while (rdr1.Read())
            // { //rdr1.Read() reads the next row of data from the MySqlDataReader object
            //     Console.WriteLine($"Username: {rdr1[0]} -- Password: {rdr1[1]} -- Role: {rdr1[2]}");
            // }
            // // MySqlReader object is disposed of by invoking the Close method
            // rdr1.Close(); //rdr1.Close() closes the MySqlDataReader object
            // Console.WriteLine("Completed task 1");

            // // ? Example 2
            // Console.WriteLine("Selecting all users by input role");
            // //  Select username and role from user table where role is @role
            // string sqlSelectByRole = "SELECT username, role FROM User WHERE role=@role";
            // MySqlCommand cmd2 = new MySqlCommand(sqlSelectByRole, conn);

            // // get the role from the user with Console.ReadLine()
            // Console.WriteLine("Enter the role e.g. Engineering, Support, Services, Training");
            // string? input_user_role = Console.ReadLine();
            // // add the role to the command object
            // cmd2.Parameters.AddWithValue("@role", input_user_role);
            // MySqlDataReader rdr2 = cmd2.ExecuteReader();
            // while (rdr2.Read())
            // {
            //     Console.WriteLine($"Username: {rdr2["Username"]} -- Role: {rdr2["Role"]}");
            // }
            // rdr2.Close();
            // Console.WriteLine("Completed task 2");

            // // ? Example 3
            // Console.WriteLine("Insert a new user");
            // // Insert a new user into the User table
            // string sqlInsertUser = "INSERT INTO User (username, password, role) VALUES (@username, @password, @role)";
            // MySqlCommand cmd3 = new MySqlCommand(sqlInsertUser, conn);
            // // get the username, password and role from the user with Console.ReadLine()
            // Console.WriteLine("Enter username");
            // string? input_username = Console.ReadLine();
            // //cmd.Parameters.AddWithValue() is used to add the parameter to the SQL command
            // cmd3.Parameters.AddWithValue("@username", input_username);
            // Console.WriteLine("Enter password");
            // string? input_password = Console.ReadLine();
            // cmd3.Parameters.AddWithValue("@password", input_password);
            // Console.WriteLine("Enter role");
            // string? input_role = Console.ReadLine();
            // cmd3.Parameters.AddWithValue("@role", input_role);

            // cmd3.ExecuteNonQuery(); //cmd.ExecuteNonQuery() is used to execute the SQL command
            // Console.WriteLine("Completed task 3");

            // ? Example 4
            Console.WriteLine("Login with user input");
            // Login with user input
            string sqlLoginUser = @"SELECT COUNT(*) AS countUser FROM User 
                                        WHERE 
                                            username=@username 
                                        AND 
                                            password=@password;";
            MySqlCommand cmd4 = new MySqlCommand(sqlLoginUser, conn);
            Console.WriteLine("Enter username");
            string? input_login_username = Console.ReadLine();
            cmd4.Parameters.AddWithValue("@username", input_login_username);
            Console.WriteLine("Enter password");
            string? input_login_password = Console.ReadLine();
            cmd4.Parameters.AddWithValue("@password", input_login_password);
            MySqlDataReader rdr4 = cmd4.ExecuteReader();
            while (rdr4.Read())
            {
                //if countUser equals 1, it means property of User is found in the database
                if (rdr4["countUser"].ToString() == "1")
                {
                    Console.WriteLine("Login Successfully!");
                }
                else
                {
                    Console.WriteLine("Login Failed!");
                }
            }
            // get the username and password from the user with Console.ReadLine()


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            conn.Close();
            Console.WriteLine("Done.");
        } // end of finally
    }
}