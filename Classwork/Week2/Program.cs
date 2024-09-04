using System.ComponentModel;

namespace Week2;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Please input your name: ");

        string? user_name = Console.ReadLine();

        Console.WriteLine("Please input your age: ");
        string? user_age = Console.ReadLine();
        // convert user age from string to int

        int age_int = Convert.ToInt32(user_age);
        int currentYear = DateTime.Now.Year;
        int birth_year = currentYear - age_int;

        if (age_int >= 18)
        {
            Console.WriteLine($"Welcome, {user_name}, you were born in {birth_year}");

        }
        else
        {
            Console.WriteLine($"Sorry, {user_name} the age requirement is 18+ years.");
            Console.WriteLine($"Still {18 - age_int} more years to go");
        }
        */
        
        /*
        double double_num = 90.2123124155661234567;
        float float_num = (float)double_num;
        Console.WriteLine($"double: {double_num} converted to float: {float_num}");

        int x = 30;
        int y = 10;

        Console.WriteLine(x < y ? $"x = {x}, y = {y}\n x<y: {x < y}" : $"x: {x} is greater than y: {y}");

        Console.WriteLine("if else statement");

        int c = 30, d = 10;
        Console.WriteLine($"c: {c}, d: {d}");
        string user_name2 = "alice";
        Console.WriteLine(" Please input username");
        string? input_username = Console.ReadLine();
        Console.WriteLine(input_username == user_name2 ? "Login successfully" : "Login failed");
        if (c >= d)
        {
            Console.WriteLine($"if-block, c>=d : {c >= d}");
        }
        else
        {
            Console.WriteLine($"else-block, c>=d: {c >= d}");
        }
        */
        Console.WriteLine("Please input a value");
        string? num3 = Console.ReadLine();
        int x_int = Convert.ToInt16(num3);

        // check for negative or positive x val
        Console.WriteLine(x_int > 0 ? "X is positive" : "X is negative");

        if ( x_int>= 0) {
            Console.WriteLine("X is positive");
        } else if (x_int == 0) {
            Console.WriteLine("X is zero");
        } else {
            Console.WriteLine("X is negative");
        }

        // check for even or odd x val
        Console.WriteLine(x_int % 2 == 0 ? "X is even" : "X is odd");

        // if/else statement
        Console.WriteLine("Please input a point grade");
        string? point = Console.ReadLine();
        int point_int = Convert.ToInt16(point);

        if (point_int >= 90) {
            Console.WriteLine("Letter Grade: A");
        } else if ( point_int >= 80) {
            Console.WriteLine("Letter Grade: B");
        } else if (point_int >= 70) {
            Console.WriteLine("Letter Grade: C"); 
        } else if (point_int >= 60) {
            Console.WriteLine("Letter Grade: D");
        } else {
            Console.WriteLine("Letter Grade: F");
        }

        // Switch statement
        int day = 5;
        switch(day){
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3: 
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break; 
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day of week");
                break;
        }

    }
}
