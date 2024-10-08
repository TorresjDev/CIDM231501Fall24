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
        string[] lastNames = new string[] { "frank", "longhorn", "jones" };

        double[] prices = { 3.6, 9.8, 6.4, 5.9 };

        int[] numbersArray = new int[15];
        for (int i = 0; i < numbersArray.Length; i++)
        {
            numbersArray[i] = i + 1;
            Console.WriteLine(numbersArray[i]);
        }
        foreach (int x in numbersArray)
        {
            Console.WriteLine($"foreach loop: x: {x} && {numbersArray[x]}");
        }

    }
}
