using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegateExample
{
    
    public delegate int MathOperation(int a, int b);

    class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
   
            MathOperation operation = new MathOperation(Add);

            int result = operation(10, 20);

      
            Console.WriteLine("The sum is: " + result);
        }
    }
}

