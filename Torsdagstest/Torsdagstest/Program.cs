using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torsdagstest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indtast x");
            string inputx = Console.ReadLine();

            Console.WriteLine("indtast y");
            string inputy = Console.ReadLine();

            Console.WriteLine("Indtast x længde");
            string inputxmax = Console.ReadLine();

            Console.WriteLine("Indtast y længde");
            string inputymax = Console.ReadLine();

            if (int.TryParse(inputx, out int x) && int.TryParse(inputy, out int y) && int.TryParse(inputxmax, out int xmax) && int.TryParse(inputymax, out int ymax))
            {
                Console.Clear();
                Kasse(x, y, xmax, ymax);
            }else
            {
                Console.WriteLine("Invalid input");
            }
        }
        public static void Kasse(int x, int y, int xmax, int ymax)
        {
            Console.SetCursorPosition(x, y);
            
                for (int j = 1; j <= xmax; j++)
                {
                System.Threading.Thread.Sleep(1000);
                if (j == 1)
                    {
                        Console.Write("┌");
                    }else if (j == xmax)
                    {
                        Console.Write("┐");
                    }else if (j > 1 && j < xmax)
                    {
                        Console.Write("─");
                    }
                }
                for (int i = 1; i < ymax; i++)
                {

                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(x + xmax - 1, y + i);
                Console.Write("│");
                }
                for (int ii = x + xmax; ii >= x; ii--)
                {
                System.Threading.Thread.Sleep(1000);
                    if (ii == x + xmax)
                    {
                    Console.SetCursorPosition(x + xmax - 1, y + ymax - 1);
                    Console.Write("┘");
                    }else if (ii == x)
                {
                    Console.SetCursorPosition(x, y + ymax - 1);
                    Console.Write("└");
                }else
                {
                    Console.SetCursorPosition(ii - 1, y + ymax - 1);
                    Console.Write("─");
                }

                }

                for (int jj = y + ymax - 1; jj > y; jj--)
            {

                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(x, jj - 1);
                Console.Write("│");
            }

            Console.SetCursorPosition(x + xmax, y + ymax);
            
            


        }
    }
}
