using System;

class MainClass
{
    public static string FirstReverse(string str)
    {
        string sol = "";
            foreach (char c in str)
            {
                sol = c + sol;
            }
        return sol;
    }

    static void Main()
    {
        Console.WriteLine(FirstReverse(Console.ReadLine()));
    }

}