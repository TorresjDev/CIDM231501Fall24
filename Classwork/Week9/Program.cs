namespace Week9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Week 9 Arrays");
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
    }
}
