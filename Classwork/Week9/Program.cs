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
        // 2D array is a matrix, arr1 is a 3x3 matrix meaning it has 3 rows and 3 columns
        int[,] two_d_array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        int[,] arr1 = { { 1, 2, 3, 4 }, { 4, 5, 6, 8 }, { 7, 8, 9, 1 } };
        Console.WriteLine("2D Array");
        PrintLoopArray(arr1);

        // jagged array: is an array of arrays
        Console.WriteLine("Jagged Array");
        int[][] jagged_array = new int[][] {
            new int[] { 1, 2, 3, 4 },
            new int[] { 5, 6 },
            new int[] { 7, 8, 9 }
        };

        int num = jagged_array[2][1];

        Console.WriteLine($"jagged_array[2][1] is {num}");
        foreach (int[] arr in jagged_array)
        {
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }



    }

    static void PrintLoopArray(int[,] arr_2d)
    {
        foreach (int val in arr_2d)
        {
            if (val % 2 == 0)
            {
                Console.Write(val + " ");
            }
        }
        Console.WriteLine("\n-----------------------------------\n");
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                if (arr_2d[row, col] % 2 == 0)
                {
                    Console.Write(arr_2d[row, col] + " ");
                }
            }
            // Console.WriteLine();
        }

    }
}
