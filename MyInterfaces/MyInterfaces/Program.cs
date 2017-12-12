using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassUseInterface o1 = new ClassUseInterface();
            if (o1 is ISomeInterface)
            {
                o1.GetInput("hej");
            }
        }
    }
    //interface er en "klasse" med kun abstracte metoder
    interface ISomeInterface
    {
        string GetInput(string prompt);
    }

    class ClassUseInterface : ISomeInterface
    {
        public string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}
