using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourOnARow
{
    class Menu
    {
        FourOnARow f = new FourOnARow();
        public void PrintMenu()
        {
            string inputMenu = "";
            while (true)
            {
                Console.WriteLine("Velkommen til gameroom, vælg venligst spil");
                Console.WriteLine("1. Fire på stribe");
                Console.WriteLine("2. Exit");
                inputMenu = Console.ReadLine();

                MenuChoose(inputMenu);
                


            }

        }
        public void MenuChoose(string input)
        {
            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        f.FourOnARowGame();
                        break;
                    case 2:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Indtast et gyldigt nummer");
                        break;
                }
            }
            else
            {
                Console.WriteLine("indtast venligst et nummer");
            }
        }
    }
}
