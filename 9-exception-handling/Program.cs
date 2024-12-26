using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _9_exception_handling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("PROGRAM IS STARTING");
                System.Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                System.Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                double result = Divide(num1, num2);
                System.Console.WriteLine($"Result dividing is: {result}");
            }
            catch (DivideByZeroException ex)
            {
                System.Console.WriteLine("ERROR: Cannot divide with 0");
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine("ERROR: Invalid format, input should be number");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Unpredictable error: {ex.Message}");
            }
            finally
            {
                System.Console.WriteLine("PROGRAM IS FINISHED");
            }
        }

        static double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            return a / b;
        }
    }
}
