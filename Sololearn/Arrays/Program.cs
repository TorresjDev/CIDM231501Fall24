namespace Sololearn;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Arrays");

        string[] names = new string[3] { "jimmy", "joe", "john" };
        Console.WriteLine(names[0]);
        double[] ages = new double[3] { 1.1, 2.1, 3.1 };
        Console.WriteLine(ages[0]);
        // string[] lastNames = new string[] { "frank", "longhorn", "jones" };
        // double[] prices = { 3.6, 9.8, 6.4, 5.9 };
        int[] numbersArray = new int[15];
        for (int i = 0; i < numbersArray.Length; i++)
        {
            numbersArray[i] = i + 1;
            Console.Write(numbersArray[i] + " ");
        }
        foreach (int d in numbersArray)
        {
            Console.WriteLine($"foreach loop: d: {d} && {numbersArray[d]}");
        }
        Console.WriteLine("");
        Console.WriteLine("Multidimensional Arrays"); // 2D array type[,] arrayName = new type[size1, size2];
        int[,] x = new int[3, 4];

        int[,] someNums = { { 2, 3 }, { 5, 6 }, { 7, 8 } }; //has 2 dimensions 
        // for (int k = 0; k < 3; k++)
        // {
        //     Console.Write(someNums[k] + " ");
        // }
        Console.WriteLine();

        Console.WriteLine("Jagged Arrays"); // is an array of arrays
        // int[][] jaggedArr = new int[3][];

        int[][] jaggedArr = new int[][] {
            new int[] {1,8,2,7,9},
            new int[] {2,4,6},
            new int[] {33,42}
        };
        for (int i = 0; i < jaggedArr.Length; i++)
        {
            int[] innerArray = jaggedArr[i];
            // array length and rank
            Console.WriteLine($"Rank: {innerArray.Rank} Length: {innerArray.Length}, ");
            // array methods
            Console.WriteLine($"Array Methods:  Max: {innerArray.Max()} Min: {innerArray.Min()} Sum: {innerArray.Sum()} Average: {innerArray.Average()} ");
            for (int j = 0; j < innerArray.Length; j++)
            {
                Console.Write(innerArray[j] + " ");
            }
            Console.WriteLine();
        }

    }


}
