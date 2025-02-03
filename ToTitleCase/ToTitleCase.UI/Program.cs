using static ToTitleCase.UI.StringExtensions;

string input;

do
{
    Console.Write("Enter a sentence: ");
    input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("This field is required");
    }
    else
    {
        break;
    }
} while (true);

string result = input.ToTitleCase();

Console.WriteLine($"\n\"{result}\" is the input in title case.");