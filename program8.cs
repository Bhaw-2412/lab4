using System;

class Program
{
    
    public delegate double BillingOperation(double amount);

    
    public static double ShowTotal(double amount)
    {
        Console.WriteLine($"ShowTotal -> Original Price: ₹{amount:F2}");
        return amount; // pass unchanged
    }

    
    public static double ApplyDiscount(double amount)
    {
        double discounted = amount - (amount * 10 / 100.0);
        Console.WriteLine($"ApplyDiscount -> After 10% discount: ₹{discounted:F2}");
        return discounted; // pass discounted price
    }

    
    public static double AddTax(double amount)
    {
        double taxed = amount + (amount * 18 / 100.0);
        Console.WriteLine($"AddTax -> After 18% GST: ₹{taxed:F2}");
        return taxed; // pass taxed price
    }

    
    public static double FinalBill(double amount)
    {
        Console.WriteLine($"FinalBill -> Final Payable Amount: ₹{amount:F2}");
        return amount; // final
    }

    static void Main()
    {
        double productAmount = 5000.0;

        
        BillingOperation ops = ShowTotal;
        ops += ApplyDiscount;
        ops += AddTax;
        ops += FinalBill;

     
        foreach (Delegate d in ops.GetInvocationList())
        {
            BillingOperation step = (BillingOperation)d;
            productAmount = step(productAmount);
        }

        Console.WriteLine("\nProcessing completed.");
    }
}
