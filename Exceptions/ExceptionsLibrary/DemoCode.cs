using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLibrary
{
    public class DemoCode
    {
        public int GrandParentMethod(int position)
        {
            int output = 0;
            Console.WriteLine("Open DataBase Connection");

            try
            {
                output = ParentMethod(position);
            }
            catch (Exception ex)
            {
                //Do some logging
                throw new Exception("Fiz merda", ex);
            }
            finally
            {
                Console.WriteLine("Close DataBase Connection");
            } 
            
            return output;
        }
        
        public int ParentMethod(int position)
        {
            return GetNumber(position);
        }

        public int GetNumber(int position)
        {
            int output = 0;

            int[] numbers = new int[] { 1, 4, 7, 2 };
            output = numbers[position];

            return output;
        }
    }
}
