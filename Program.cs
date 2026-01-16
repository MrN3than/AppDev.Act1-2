using System.Runtime.InteropServices;
while (true)
{
    Console.WriteLine("\nString Manipulation Toolkit");
    Console.WriteLine("[1] String Reversal \n [2] Word Count \n [3] Character Count \n [4] Lower Case Converter \n [5] Upper Case Converter \n [6] Palindrome Checker \n [0] Exit");
    Console.Write("Enter your choice (0-6) \n > ");

    string input = Console.ReadLine();
    int intChoice;
    if (!int.TryParse(input, out intChoice))
    {
        intChoice = -1;
    }

    switch (intChoice)
    {
        case 0:
            Console.Write("Are you sure you want to exit? (Y = Yes | N = No) \n > ");
            string confirm = Console.ReadLine() ?? "";
            if (confirm.ToUpper() == "Y")
            {
                Console.WriteLine("Exiting program...");
                return;
            }
            else
            {
                Console.WriteLine("Exit cancelled. Returning to menu...");
                continue;
            }
        case 1:
            Console.WriteLine("\n------String Reversal------");
            Console.Write("Enter a string that you want to reverse:\n > ");
            String strInputReversal = Console.ReadLine(); ;
            string result = StringReversal(strInputReversal);
            Console.WriteLine($"Result: {result}");
            break;
        case 2:
            Console.WriteLine("\n------Word Count------");
            Console.Write("Enter a string to count its words:\n > ");
            string strInputWordCount = Console.ReadLine();
            WordCount(strInputWordCount);
            break;
        case 3:
            Console.WriteLine("\n------Character Count------");
            Console.Write("Enter a string to count its characters:\n > ");
            string strInputCharCount = Console.ReadLine();
            CharCount(strInputCharCount);
            break;
        case 4:
            Console.WriteLine("\n------Lower Case Converter------");
            Console.Write("Enter a string to convert to lowercase:\n > ");
            string strInputLower = Console.ReadLine();
            Console.WriteLine($"Result: {strInputLower.ToLower()}");
            break;
        case 5:
            Console.WriteLine("\n------Upper Case Converter------");
            Console.Write("Enter a string to convert to uppercase:\n > ");
            string strInputUpper = Console.ReadLine();
            Console.WriteLine($"Result: {strInputUpper.ToUpper()}");
            break;
        case 6:
            Console.WriteLine("\n------Palindrome Checker------");
            Console.Write("Enter a string to check:\n > ");
            string strInputPal = Console.ReadLine() ?? "";
            string reversed = StringReversal(strInputPal);
            if (strInputPal.Equals(reversed, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{strInputPal} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"{strInputPal} is NOT a Palindrome");
            }
            break;
        default:
            Console.WriteLine("Invalid input.");
            break;
    }

    Console.WriteLine("\nDo you want to try again? (Y = Yes | N = No)");
    Console.Write(" > ");
    string tryAgain = Console.ReadLine();

    if (tryAgain.ToUpper() != "Y")
    {
        Console.Write("Are you sure you want to quit? (Y/N) \n > ");
        string confirmExit = Console.ReadLine();
        if (confirmExit.ToUpper() == "Y")
        {
            Console.WriteLine("\nThank you for using String Manipulation Toolkit");
            break;
        }
        else
        {
            Console.WriteLine("Returning to menu...");
        }
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


