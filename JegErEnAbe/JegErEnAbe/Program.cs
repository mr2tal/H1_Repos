using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JegErEnAbe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast en sætning uden mellemrum");
            string inputString = Console.ReadLine();
            Console.WriteLine("Indtast starts index (0-indekset)");
            string inputStart = Console.ReadLine();
            Console.WriteLine("Indtast slut index (0-indekset)");
            string inputEnd = Console.ReadLine();
            if (int.TryParse(inputStart,out int inputStartInt) && int.TryParse(inputEnd,out int inputEndInt))
            {
                if (inputStartInt < 0 || inputString.Length < inputEndInt)
                {
                    Console.WriteLine("Outside scope");
                }
                else
                {
                    Console.WriteLine("Substringen af {0} er {1}",inputString,Substring(inputString, inputStartInt, inputEndInt));
                }
            } else
            {
                Console.WriteLine("Invalid Number");
            }
            Console.ReadKey();
        }

        static string Substring(string input, int startindex, int endindex)
        {
            string output = "";

            char[] chararr = input.ToCharArray();

            for (int i = startindex; i <= endindex; i++)
            {
                output = output + chararr[i].ToString();
            }

            return (output);

        }
       
    }
}
