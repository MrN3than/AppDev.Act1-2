using System.Runtime.InteropServices;

Console.WriteLine("String Manipulation Toolkit");
Console.WriteLine("[1] String Reversal \n [2] Word Count \n [3] Character Count \n [4] Lower Case Converter [5] Upper Case Converter");
Console.Write("Enter your choice (1-5) \n > ");

while (true){
    string input = Console.ReadLine();
    if (!int.TryParse(input, out int intChoice)){
        Console.Write("Invalid input. Please enter a valid number (1-5) \n > ");
        continue;
    }

    switch (intChoice) {
        case 1:
            Console.WriteLine("String Reversal");
            Console.Write("Enter a string that you want to reverse:\n > ");
            String strInputReversal = Console.ReadLine(); ;
            string result = StringReversal(strInputReversal);
            Console.WriteLine($"Result: {result}");
            break;
        case 2:
            Console.WriteLine("Word Count");
            Console.Write("Enter a string to count its words:\n > ");
            string strInputWordCount = Console.ReadLine();
            WordCount(strInputWordCount);
            break;
        case 3:
            Console.WriteLine("Character Count");
            Console.Write("Enter a string to count its characters:\n > ");
            string strInputCharCount = Console.ReadLine();
            CharCount(strInputCharCount);
            break;
        case 4:
            Console.WriteLine("Lower Case Converter");
            Console.WriteLine("--- Lower Case Converter ---");
            Console.Write("Enter a string to convert to lowercase:\n > ");
            string strInputLower = Console.ReadLine();
            Console.WriteLine($"Result: {strInputLower.ToLower()}");
            break;
        case 5:
            Console.WriteLine("Upper Case Converter");
            Console.WriteLine("--- Upper Case Converter ---");
            Console.Write("Enter a string to convert to uppercase:\n > ");
            string strInputUpper = Console.ReadLine();
            Console.WriteLine($"Result: {strInputUpper.ToUpper()}");
            break;
        default:
            Console.WriteLine("Invalid input. Please enter a number between 1-5.");
            continue;
    }

    static string StringReversal(string strInputReverse)
    {
        string strContainerReversal = "";
        for (int i = strInputReverse.Length - 1; i >= 0; i--)
        {
            strContainerReversal += strInputReverse[i];
        }
        return strContainerReversal;
    }

    static void WordCount(string strInputWordCount)
    {
        strInputWordCount = strInputWordCount.Trim();
        if (strInputWordCount.Length == 0)
        {
            Console.WriteLine("Number Of Words: 0");
            return;
        }

        int intWordCount = 1;
        for (int i = 0; i < strInputWordCount.Length - 1; i++)
        {
            if (strInputWordCount[i] == ' ' && strInputWordCount[i + 1] != ' ')
            {
                intWordCount++;
            }
        }
        Console.WriteLine($"Number Of Words In \"{strInputWordCount}\" Is {intWordCount}");
    }

    static void CharCount(string strInputCharCount)
    {
        int count = 0;
        for (int i = 0; i < strInputCharCount.Length; i++)
        {
            if (strInputCharCount[i] != ' ')
            {
                count++;
            }
        }
        Console.WriteLine($"Number Of Characters In \"{strInputCharCount}\" Is {count}");
    }

}

