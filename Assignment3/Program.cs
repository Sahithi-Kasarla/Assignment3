using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tryparse method

            string input = "2";//replace 2 with your input
             if(int.TryParse(input, out int number))
             {
                 Console.WriteLine("the parsed number from string to in is:"+number);
             }
             else
             {
                 Console.WriteLine("error occured");
             }

            //Convert method

            /*string doublestring = "789.900";//replace with your double string
            try
            {
                double inputDouble = Convert.ToDouble(doublestring);
                Console.WriteLine("the converted number from string to double is " + inputDouble);
            }
            catch(Exception ex)
            {
                Console.WriteLine("error occured"+ex.Message);
            }
            */
            

            //Parse method

            /*string decimalstring = "89034.095";//replace with your decimal string
                try
            {
                decimal inputdecimal = Convert.ToDecimal(decimalstring);
                Console.WriteLine("the converted string from string to decimal is " + inputdecimal);
            }
            catch(Exception ex)
            {
                Console.WriteLine("error occured" + ex.Message);
            }*/

            Console.ReadKey();
         
        }
    }
}

