namespace Strings;

class Program
{
    static void Main(string[] args)
    {


        // string a = "some text";
        // Console.WriteLine(a[2]);
        // Console.WriteLine(a.Length);
        // //Outputs 9

        // Console.WriteLine(a.IndexOf('t'));
        // //Outputs 5

        // a = a.Insert(0, "This is ");
        // Console.WriteLine(a);
        // //Outputs "This is some text"

        // a = a.Replace("This is", "I am");
        // Console.WriteLine(a);
        // //Outputs "I am some text"

        // if (a.Contains("some"))
        //     Console.WriteLine("found");
        // //Outputs "found"

        // a = a.Remove(4);
        // Console.WriteLine(a);
        // //Outputs "I am"

        // a = a.Substring(2);
        // Console.WriteLine(a);
        // //Outputs "am"    
        // // string s = "SoloLearn is awesome";

        // // Console.Write(s.IndexOf('e'));

        // string text = "This is some text about a dog. The word dog appears in this text a number of times. This is the end.";
        // text = text.Replace("dog", "cat");
        // text = text.Substring(0, text.IndexOf(".") + 1);

        // Console.WriteLine(text);

        // string s = "SoloLearn";

        // int x = s.Length;

        // int y = s.IndexOf("e");

        // Console.Write(x % y);

        string[] words = { "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"};

        Console.WriteLine("Enter a word to search for: ");
        string letter = Console.ReadLine() ?? string.Empty;

        int count = 0;

        foreach (string word in words)
        {
            if (word.Contains(letter))
            {
                Console.WriteLine(word);
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No match");
        }

    }
}
