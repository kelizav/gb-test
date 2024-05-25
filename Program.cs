using System;

class Program
{
    static void Main()
    {
        string[] initialArray = { "Russia", "aaa", "bb", "Italy", "11", "Kazakhstan" };

        int count = 0;
        foreach (string currentString in initialArray)
        {
            if (currentString.Length <= 3)
            {
                count++;
            }
        }

        string[] outputArray = new string[count];

        int index = 0;
        foreach (string currentString in initialArray)
        {
            if (currentString.Length <= 3)
            {
                outputArray[index] = currentString;
                index++;
            }
        }

        Console.WriteLine("Output:");
        foreach (string currentString in outputArray)
        {
            Console.WriteLine(currentString);
        }
    }
}