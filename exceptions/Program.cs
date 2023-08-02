using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                Console.WriteLine("Enter a number  :  ");
                 num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter another number  :  ");
                 num2 = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("error");
                Console.ResetColor();

            }
            finally { Console.WriteLine("finall"); }

            Console.WriteLine("sum is" + (num1 + num2));  
        }
    }
 }