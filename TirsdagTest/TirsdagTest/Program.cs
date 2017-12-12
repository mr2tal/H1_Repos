using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace TirsdagTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //opgave 3.1
            string InputDate;
            string date;
            Console.WriteLine("Indtast dagnummeret 1-7");
            InputDate = Console.ReadLine();

            switch (InputDate)
            {
                case "1":
                    date = "Mandag";
                    break;
                case "2":
                    date = "tirsdag";
                    break;
                case "3":
                    date = "onsdag";
                    break;
                case "4":
                    date = "torsdag";
                    break;
                case "5":
                    date = "fredag";
                    break;
                case "6":
                    date = "lørdag";
                    break;
                case "7":
                    date = "søndag";
                    break;
                default:
                    date = "";
                    break;
            }

            if (date != "")
            {
                Console.WriteLine("I dag er det {0}", date);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            //opgave 3.2

            string InputCelc;
            string InputTemp;
            double celc;
            double OutputTemp;
            string TempType;

            Console.WriteLine("Indtast temperatur i celcius");
            InputCelc = Console.ReadLine();

            if (double.TryParse(InputCelc, out celc))
            {
                Console.WriteLine("Indtast k for kelvin, f for fahrenheit, R for Réaumur");
                InputTemp = Console.ReadLine();
                switch (InputTemp.ToLower())
                {
                    case "k":
                        OutputTemp = celc + 273.15;
                        TempType = "Kelvin";
                        break;
                    case "f":
                        OutputTemp = (celc * (9.00 / 5.00)) + 32.00;
                        TempType = "Fahrenheit";
                        break;
                    case "r":
                        OutputTemp = celc * 0.8;
                        TempType = "Réaumur";
                        break;
                    default:
                        OutputTemp = 0;
                        InputTemp = "";
                        TempType = "";
                        break;
                }
                if (TempType != "")
                {
                    Console.WriteLine("Celcius {0} er lig med {1} {2}", celc, OutputTemp, TempType);
                } else
                {
                    Console.WriteLine("Invalid input, k, f eller r for udregning");
                }
                

            } else
            {
                Console.WriteLine("Invalid number");
            }

            //opgave 4

            string InputTable;
            int Table;
            int count = 1;

            Console.WriteLine("Indtast tabel du vil have udregnet");
            InputTable = Console.ReadLine();

            if (int.TryParse(InputTable, out Table))
            {
                
                while (count * Table < 100)
                {
                    Console.WriteLine(" {0} x {1} : {2}", count, Table, Table * count);
                    count = count + 1;
                }

            }else
            {
                Console.WriteLine("Invalid Input");
            }

            //opgave 4.1
            string InputVertical;
            string InputHorizontal;
            int Vertical;
            int Horizontal;

            Console.WriteLine("Indtast vandret start");
            InputHorizontal = Console.ReadLine();

            Console.WriteLine("Indtast lodret start");
            InputVertical = Console.ReadLine();

            if (int.TryParse(InputHorizontal, out Horizontal) && int.TryParse(InputVertical, out Vertical))
            {
                Console.SetCursorPosition(Horizontal, Vertical);
                Console.WriteLine("┌────────┐");
                Console.SetCursorPosition(Horizontal, Vertical + 1);
                Console.WriteLine("│        │");
                Console.SetCursorPosition(Horizontal, Vertical + 2);
                Console.WriteLine("│        │");
                Console.SetCursorPosition(Horizontal, Vertical + 3);
                Console.WriteLine("│        │");
                Console.SetCursorPosition(Horizontal, Vertical + 4);
                Console.WriteLine("└────────┘");
            } else
            {
                Console.WriteLine("Invalid input");
            }

            //opgave 4.5

            String InputSlut;
            int SlutCount = 0;

            while (true)
            {
                Console.WriteLine("Indtast tekst, slut for at afslutte");
                InputSlut = Console.ReadLine();

                if (InputSlut.ToLower() != "slut")
                {
                    SlutCount = SlutCount + 1;
                    Console.WriteLine("{0}", InputSlut);
                } else
                {
                    SlutCount = SlutCount + 1;
                    Console.WriteLine("Antal gange programmet kørte: {0}", SlutCount);
                    break;
                }
            }

            //opgave 5.1 && 5.2
            
            double Fahrenheit;

            for (double Celcius = 10; Celcius <= 100; Celcius = Celcius + 10)
            {
                Fahrenheit = (Celcius * (9.00 / 5.00)) + 32.00;
                Console.WriteLine("{0} Celcius er {1} Fahrenheit", Celcius, Fahrenheit);
            }

            //opgave 5.3
            
            for(int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.WriteLine("Tekst med farve");
            }

            Console.ForegroundColor = ConsoleColor.White;

            //opgave 6.1
            string InputRadius;
            double Radius;
            double Circumference;

            Console.WriteLine("Indtast radius af cirklen");
            InputRadius = Console.ReadLine();

            if (double.TryParse(InputRadius, out Radius))
            {
                Circumference = (2 * Radius) * Math.PI;
                Console.WriteLine("Omkreds er {0}", Circumference);
            } else
            {
                Console.WriteLine("invalid input");
            }

            //opgave 7.1
            
            string Lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            int SpaceCount = 0;
            int Index = 0;

            
                while (true)
            {
                if (Index != -1)
                {
                    Index = Lorem.IndexOf(" ");
                    SpaceCount = SpaceCount + 1;
                    Lorem = Lorem.Substring(Index + 1);
                    Index = Lorem.IndexOf(" ");
                }else
                {
                    Console.WriteLine("{0} mellemrum", SpaceCount);
                    break;
                }
                
                
            }



            //opgave 7.2
            string Lorem1 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";

            Lorem1 = Lorem1.Replace(" ", "\n");

            Console.WriteLine(Lorem1);

            //opgave 7.3
            string InputName;
            int UppercaseCount = 0;
            string Substring = "";

            Console.WriteLine("Indtast fulde navn");
            InputName = Console.ReadLine();

            while (UppercaseCount < InputName.Length)
            {
                if(InputName.Substring(UppercaseCount, 1) != "")
                {
                   if (UppercaseCount == 0)
                    {
                        Substring = Substring + InputName.Substring(UppercaseCount, 1).ToUpper(); 
                        UppercaseCount = UppercaseCount + 1;
                    } else if (InputName.Substring(UppercaseCount - 1, 1) == " ")
                    {
                        Substring = Substring + InputName.Substring(UppercaseCount, 1).ToUpper();
                        UppercaseCount = UppercaseCount + 1;
                    }
                    else
                    {
                        Substring = Substring + InputName.Substring(UppercaseCount, 1).ToLower();
                        UppercaseCount = UppercaseCount + 1;
                    }
                }
            }
            Console.WriteLine(Substring);

            //opgave 8.1
            ArrayList Måneder = new ArrayList();

            Måneder.Add("Januar");
            Måneder.Add("Februar");
            Måneder.Add("Marts");
            Måneder.Add("April");
            Måneder.Add("Maj");
            Måneder.Add("Juni");
            Måneder.Add("Juli");
            Måneder.Add("August");
            Måneder.Add("September");
            Måneder.Add("Oktober");
            Måneder.Add("November");
            Måneder.Add("December");
            
            foreach (string Måned in Måneder)
            {
                if(Måned.Substring(0,1).ToLower() == "a")
                {
                    Console.WriteLine(Måned);
                }
            }

            Måneder.Sort();

            foreach (string Måned in Måneder)
            {
                if(Måned.Length > 4)
                {
                    Console.WriteLine(Måned);
                }
            }

            Måneder.Add("Bichat");

            foreach (string Måned in Måneder)
            {
                Console.WriteLine(Måned);
            }







        }
    }
}