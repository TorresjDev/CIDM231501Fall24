namespace Week10;
using System.Linq; //Linq: adds data querying capabilities to .NET languages

class Program
{
    static void Main(string[] args)
    {
        //! Week 10 Part I
        // ? Array Properties and Methods
        int[] int_1D_array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[,] int_2D_array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[][] int_jagged_array = {
            new int[] { 1, 2, 3, 4 },
            new int[] { 5, 6 },
            new int[] { 7, 8, 9 }
        };

        string[] name = { "Alice", "Bob", "Cathy", "Tom", "Jack" };
        string[] car = { "Toyota", "Honda", "Ford", "Chevy", "BMW" };

        Console.WriteLine("***Array Length Property!***");
        // Length property: returns the number of elements in the array
        ArrayLength(int_1D_array, int_2D_array, int_jagged_array);

        Console.WriteLine("\n***Array Rank Property!***");
        // Rank property: returns the number of dimensions in the array
        ArrayRank(int_1D_array, int_2D_array, int_jagged_array);

        Console.WriteLine("\n***Array Sort Property!***");
        // Sort property: sorts the elements in the array
        ArraySort(int_1D_array, name);

        Console.WriteLine("\n***Array IndexOf!***");
        // IndexOf property: returns the index of the first occurrence of a value in the array
        Console.WriteLine($"The index of Ford in car array is {Array.IndexOf(car, "Ford")}");

        Console.WriteLine("\n***GetLength Property!***");
        // GetLength property: returns the number of elements in the specified dimension of the array
        Console.WriteLine($"The length of car array is {car.GetLength(0)}");
        Console.WriteLine($"The number of rows in int_2D_array is {int_2D_array.GetLength(0)}");
        Console.WriteLine($"The number of columns in int_2D_array is {int_2D_array.GetLength(1)}");
        for (int idx = 0; idx < int_2D_array.GetLength(0); idx++)
        {
            Console.WriteLine($"row: {idx}  ");
            for (int jdx = 0; jdx < int_2D_array.GetLength(1); jdx++)
            {
                Console.Write($" column: {jdx} value: {int_2D_array[idx, jdx]} ");
            }
            Console.WriteLine();
        }

        // Exercise 1
        int[] int_array = { 1, 23, 44, 552, 34, 88, 91, 256, 22, 31, 45 };
        PartIMethod(int_array);

        // ? String: Properties and Methods
        // String: is a sequence of characters
        string str = "This is a string containing a lot of characters (char values).";
        Console.WriteLine($"Print first char value of str: {str[0]}, its datatype is {str[0].GetType()}");
        // str.Length: returns the number of characters in the string
        Console.WriteLine($"The length of str is {str.Length}");
        // str.IndexOf(value): returns the index of the first occurrence of a value in the string
        Console.WriteLine($"The index of \"is\": {str.IndexOf("is")}");
        // str.Insert(index, value): inserts a value into the string at the specified index
        string insert_str = str.Insert(0, "Hello! ");
        Console.WriteLine($"String after insert: {insert_str}");
        // str.Remove(index, length): removes a specified number of characters from the string at the specified index
        string remove_str = str.Remove(str.IndexOf("char"));
        Console.WriteLine($"String after remove: {remove_str}");
        // str.Replace(old value, new value): replaces a specified value in the string with a new value
        string replace_str = str.Replace("characters", "CHARACTERS");
        Console.WriteLine($"String after replace: {replace_str}");
        // str.Substring(index, length): extracts a specified number of characters from the string starting at the specified index
        string substring_str = str.Substring(str.IndexOf("a"), 5);
        Console.WriteLine($"String after substring: {substring_str}");
        // str.Contains(value): returns a boolean indicating whether a specified value is contained in the string
        bool contains = str.Contains("char");
        Console.WriteLine($"Does str contain \"char\"? {contains}");

    }

    //* Array Length Property Method
    static void ArrayLength(int[] int_id_array, int[,] int_2D_array, int[][] int_jagged_array)
    {
        Console.WriteLine($"The length of 1D array: {int_id_array.Length}");
        Console.WriteLine($"Iterate values in array based on array length using for loop");
        for (int idx = 0; idx < int_id_array.Length; idx++)
        {
            Console.WriteLine($"The value of index {idx} is {int_id_array[idx]}");
        }

        Console.WriteLine($"The length of 2D array: {int_2D_array.Length}");
        Console.WriteLine($"The length of jagged array: {int_jagged_array.Length}");
    }

    //* Array Rank Property Method
    static void ArrayRank(int[] int_id_array, int[,] int_2D_array, int[][] int_jagged_array)
    {
        Console.WriteLine($"The dimension of 1D array: {int_id_array.Rank}");
        Console.WriteLine($"The dimension of 2D array: {int_2D_array.Rank}");
        Console.WriteLine($"The dimension of jagged array: {int_jagged_array.Rank}");
    }

    //* Array Sort Property Method
    static void ArraySort(int[] int_1D_array, string[] name)
    {
        Console.WriteLine("Original Order of int_1D_array");
        foreach (int val in int_1D_array)
        {
            Console.Write($"{val} ");
        }
        Array.Sort(int_1D_array);
        Console.WriteLine("\nSorted Order of int_1D_array");
        foreach (int val in int_1D_array)
        {
            Console.Write($"{val} ");
        }
        Console.WriteLine("\n-----------------------------------");
        Console.WriteLine("Original Order of name array: ");
        foreach (string name_val in name)
        {
            Console.Write($"{name_val} ");
        }
        Array.Sort(name);
        Console.WriteLine("\nSorted Order of name array: ");
        foreach (string name_val in name)
        {
            Console.Write($"{name_val} ");
        }
    }

    //* Exercise 1 method
    static void PartIMethod(int[] arr)
    {
        Console.WriteLine($"The length of array: {arr.Length}");
        Console.WriteLine($"The dimension of array: {arr.Rank}");
        Console.WriteLine($"Max value of array: {arr.Max()}");
        Console.WriteLine($"Min value of array: {arr.Min()}");
        Console.WriteLine($"Average value of array: {arr.Average()}");
        Console.WriteLine($"Sum value of array: {arr.Sum()}");
    }
}
