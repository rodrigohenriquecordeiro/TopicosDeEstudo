using ExceptionsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoCode demo = new DemoCode();
            try
            {
                int result = demo.GrandParentMethod(10);
                Console.WriteLine($"The value at the given position is {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Console.ReadLine();
        }
    }
}
