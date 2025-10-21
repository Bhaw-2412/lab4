using System;

class Program
{

    public delegate int Operation(int a, int b);

    
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    static void Main()
    {
    
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        
        Operation addOp = new Operation(Add);
        Operation subOp = new Operation(Subtract);

       
        int sum = addOp(num1, num2);
        int diff = subOp(num1, num2);

        // Step 6: Display results
        Console.WriteLine($"\nAddition Result: {sum}");
        Console.WriteLine($"Subtraction Result: {diff}");
    }
}
