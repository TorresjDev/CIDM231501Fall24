namespace Week9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Week 9 Arrays Part I");
        int[] int_array = { 10, 15, 20, 25, 30 };
        int[] int_array2 = { 10, 15, 20, 25, 30 };
        // Console.WriteLine(int_array[4]);
        // int_array[4] = 100;
        // Console.WriteLine(int_array[4]);
        // for (int idx = 0; idx < 5; idx++)
        // {
        //     Console.WriteLine(int_array2[idx]);
        //     int_array2[idx] = int_array2[idx] * 3;
        // }

        // for (int idx = 0; idx < 5; idx++)
        // {
        //     Console.WriteLine(int_array2[idx]);
        // }

        // foreach (int val in int_array)
        // {
        //     Console.WriteLine($"use foreach to iterate int_array: {val}");
        // }

        string[] name_array = { "Alice", "Bob", "Cathy", "Tom", "Jack" };

        Console.WriteLine(name_array[1]);
        Console.WriteLine(name_array[3]);
        name_array[4] = "David";

        foreach (string name in name_array)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("Week 9 Arrays Part II");
        // 2D array: [,] is the syntax to declare a 2D array, new int[3, 3] is the size of the 2D array 
        int[,] two_d_array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        // for loop to iterate through the 2D array
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(arr1[row, col] + " ");
            }
            Console.WriteLine();
        }
        // foreach loop to iterate through the 2D array
        foreach (int val in arr1)
        {
            Console.Write(num + " ");
        }



    }
}
