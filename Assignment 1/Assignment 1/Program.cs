using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;



namespace Assignment_1
{
    public static class Age
    {
        static double Maximum(double x, double y, double z)
        {
            return Math.Max(x, Math.Max(y, z));
        }
        
        static void Main(string[] args)
        {

            // obtain user input and convert to double
            Console.Write("Enter first floating-point value: ");
            double number1 = Double.Parse(Console.ReadLine());
            Console.Write("Enter second floating-point value: ");
            double number2 = Double.Parse(Console.ReadLine());
            Console.Write("Enter third floating-point value: ");
            double number3 = Double.Parse(Console.ReadLine());
            // call method Maximum to determine largest value
            double max = Maximum(number1, number2, number3);
            Console.WriteLine("\nMaximum is: " + max);
            Console.ReadLine();

        }
    }
}
