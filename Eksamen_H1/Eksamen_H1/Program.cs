using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen_H1
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialisere min menu
            Menu menu = new Menu();
            //kalder metoden PrintMenu()
            menu.PrintMenu();
        }


    }

    class Jul
    {
        public static void Julemand(bool b)
        {
            if (b == true)
            {
                Console.WriteLine("Glædelig jul nissemand");
            }else if (b == false)
            {
                Console.WriteLine("Glædelig jul nissepige");
            }
        }
        public static void Julemand(bool b, string s)
        {
            if (b == true && s.ToLower() == "n")
            {
                Console.WriteLine("Glædelig jul nissemand");
            }
            else if (b == true && s.ToLower() == "p")
            {
                Console.WriteLine("Glædelig jul nissepige");
            }
        }
    }
    class Demon
    {
        public void Demons()
        {
            string textAfterChar = "";
            string text = System.IO.File.ReadAllText(@"C:\TEST\demon.txt",System.Text.Encoding.GetEncoding("iso-8859-1"));

            char[] chararr = text.ToCharArray();
            List<char> charList = new List<char>(chararr);

            for (int i = 0; i < charList.Count(); i++)
            {
                if (charList[i] == ',' || charList[i] == '.' || charList[i] == '´' || charList[i] == '\'') 
                {
                   
                    
                    
                }else
                {
                    textAfterChar = textAfterChar + charList[i];
                }
            }
            
            
            

            string[] words = textAfterChar.Split(' ');
            List<string> wordList = new List<string>(words);

            //opgave 3A
            Console.WriteLine("opgave 3A");
            Console.WriteLine("{0} ord i teksten.",wordList.Count());
            Console.WriteLine("tryk en tast for at forsætte");
            Console.ReadKey();

            //opgave 3B
            int countstrings = 0;
            foreach (string word in wordList)
            {
                if (word[0] == 'h' || word[0] == 'H')
                {
                    countstrings = countstrings + 1;
                }
            }
            Console.WriteLine("opgave 3B");
            Console.WriteLine("{0} strings der starter med h/H", countstrings);
            Console.WriteLine("tryk en tast for at forsætte");
            Console.ReadKey();
            //opgave 3C
            int countchars = 0;
            char[] chararray = textAfterChar.ToCharArray();

            for (int i = 0; i < chararray.Count(); i++)
            {
                if (chararray[i] == ' ')
                {

                }else
                {
                    countchars = countchars + 1;
                }
            }
            Console.WriteLine("opgave 3C");
            Console.WriteLine("{0} antal bogstaver uden mellemrum, komma og punktum",countchars);
            Console.WriteLine("tryk en tast for at forsætte");
            Console.ReadKey();
            //opgave 3D
            List<string> containingWord = new List<string>();
            int countContains = 0;
            foreach (string word in wordList)
            {
                if (!containingWord.Contains(word))
                {
                    containingWord.Add(word);
                    foreach (string Listword in wordList)
                    {
                        if (Listword == word)
                        {
                            countContains = countContains + 1;
                        }
                    }
                    Console.WriteLine("{0} er der {1} gange", word, countContains);
                    countContains = 0;
                } 

            }
            Console.WriteLine("tryk en tast for at forsætte");
            Console.ReadKey();

            //opgave 3E
            string longest = "";
            foreach (string word in wordList)
            {
                if (word.Length > longest.Length)
                {
                    longest = word;
                }
            }
            Console.WriteLine("opgave 3E");
            Console.WriteLine("{0} er det længste ord", longest);


            Console.WriteLine("Tryk på en vilkårlig tast for at forsætte");
            Console.ReadKey();
        
        }
    }

    class Assignment
    {
        public void PrintAssignment()
        {
            Console.WriteLine("Lav en filmdatabase, der skal kunne loades fra fil.\nsørg for at have properties på objekterne");
        }
    }

    class Menu
    {
                public void PrintMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Vælg venligst opgave:\n1. opgave\n3. opgave\n4. opgave\n5. exit");
                string menuInput = Console.ReadLine();
                MenuChoice(menuInput);
            }
        }

        public void MenuChoice(string choice)
        {
            Jul julemand = new Jul();
            Demon demon = new Demon();
            Assignment assignment = new Assignment();

            switch (choice)
            {
                case "1":
                    Jul.Julemand(true);
                    Jul.Julemand(false);
                    Jul.Julemand(true, "n");
                    Jul.Julemand(true, "p");
                    Console.WriteLine("tryk vilkårlig tast for at gå tilbage til menuen");
                    Console.ReadKey();
                    break;
                case "3":
                    demon.Demons();
                    break;
                case "4":
                    assignment.PrintAssignment();
                    Console.ReadKey();
                    break;
                case "5":
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Indtast venligst tal der er i brug på listen");
                    break;
            }
        }

    }
}
