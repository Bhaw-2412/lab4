using System;

class Car
{
    
    private int speed;


    public int Speed
    {
        get { return speed; }
        set
        {
            if (value > 180)
            {
                Console.WriteLine($"⚠️ Speed {value} km/h exceeds the limit! Resetting to 180 km/h.");
                speed = 180;
            }
            else
            {
                speed = value;
            }
        }
    }

    
    public void DisplaySpeed()
    {
        Console.WriteLine($"Current Speed: {Speed} km/h");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car();

        
        car.Speed = 150;
        car.DisplaySpeed();

        
        car.Speed = 200;
        car.DisplaySpeed();
    }
}
