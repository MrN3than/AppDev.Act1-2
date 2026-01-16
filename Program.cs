Console.WriteLine("String Manipulation Toolkit");
Console.WriteLine("[1] String Reversal \n [2] Word Count \n [3] Character Count \n [4] Lower Case Converter [5] Upper Case Converter");
Console.Write("Enter your choice (1-5) \n > ");
string input = Console.ReadLine(); 
int intChoice = int.Parse(input);

switch (intChoice) {
    case 1:
        Console.WriteLine("String Reversal");
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
