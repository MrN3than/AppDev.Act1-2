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
            break;
        case 3:
            Console.WriteLine("Character Count");
            break;
        case 4:
            Console.WriteLine("Lower Case Converter");
            break;
        case 5:
            Console.WriteLine("Upper Case Converter");
            break;
        default:
            Console.WriteLine("Invalid input. Please enter a number between 1-5.");
            break;
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
}

