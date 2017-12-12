using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fredagsopgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputint;
            string inputdouble;
            while (true)
            {
                Console.WriteLine("Indtast heltal");
                inputint = Console.ReadLine();
                Console.WriteLine("Indtast Double");
                inputdouble = Console.ReadLine();

                try
                {
                    Console.WriteLine("Tallet er {0}", GetInt(inputint));  
                    Console.WriteLine("Tallet er {0}", GetDouble(inputdouble));
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input: {0}", e.Message);
                }
            }



        }


        public static int GetInt(string input)
        {
            int output = int.Parse(input);
            return output;
        }
        public static double GetDouble(string input)
        {
            double output = double.Parse(input);
            return output;
        }
    }
}
