using System;

class Program
{
    
    public delegate double ConvertTemperature(double celsius);

    
    public static double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = celsius * 9.0 / 5.0 + 32.0;
        Console.WriteLine($"CelsiusToFahrenheit -> {celsius}°C = {fahrenheit:F2}°F");
        return fahrenheit;
    }

    
    public static double CelsiusToKelvin(double celsius)
    {
        double kelvin = celsius + 273.15;
        Console.WriteLine($"CelsiusToKelvin    -> {celsius}°C = {kelvin:F2} K");
        return kelvin;
    }

    static void Main()
    {
        double celsius = 25.0;

        
        ConvertTemperature toF = new ConvertTemperature(CelsiusToFahrenheit);
        ConvertTemperature toK = new ConvertTemperature(CelsiusToKelvin);

        
        double f = toF(celsius);
        double k = toK(celsius);

        Console.WriteLine("\nDone.");
    }
}
