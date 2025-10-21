using System;

class Program
{
    
    public delegate string FormatText(string input);

    public static string ToUpperCase(string input)
    {
        return input.ToUpper();
    }

    public static string ToLowerCase(string input)
    {
        return input.ToLower();
    }

    static void Main()
    {
        string text = "Hello World";

    
        FormatText upper = new FormatText(ToUpperCase);
        FormatText lower = new FormatText(ToLowerCase);

        
        Console.WriteLine($"Original Text: {text}");
        Console.WriteLine($"Uppercase: {upper(text)}");
        Console.WriteLine($"Lowercase: {lower(text)}");
    }
}
