using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher[] teachers = new Teacher[6];

            teachers[0] = new Teacher("Bo", 9, "bst", 75.50);
            teachers[1] = new Teacher("Jan", 9, "JAJ", 80);
            teachers[2] = new Teacher("John", 4, "Joel", 75);
            teachers[3] = new Teacher("Flemming", 1, "fls", 60);
            teachers[4] = new Teacher("Robert", 5, "rlh", 50);
            teachers[5] = new Teacher("Ole", 35, "obh", 89);


            Console.WriteLine("unsorted");
            foreach (Teacher item in teachers)
            {
                Console.WriteLine(item.ToString());
            }

            Array.Sort(teachers, new CompareName());
            Console.WriteLine("Sorted by Name");
            foreach (Teacher item in teachers)
            {
                Console.WriteLine(item.ToString());
            }

            Array.Sort(teachers, new CompareCoffee());
            Console.WriteLine("Sorted by Coffee");
            foreach (Teacher item in teachers)
            {
                Console.WriteLine(item.ToString());
            }
            Array.Sort(teachers, new CompareInitials());
            Console.WriteLine("Sorted by Initials");
            foreach (Teacher item in teachers)
            {
                Console.WriteLine(item.ToString());
            }
            Array.Sort(teachers, new CompareWeight());
            Console.WriteLine("Sorted by Weight");
            foreach (Teacher item in teachers)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }

    class Teacher : IComparable
    {
        public string Name { get; set; }
        public int NrOfCoffee { get; set; }
        public string Initials { get; set; }
        public double Weight { get; set; }
        
        public Teacher (string n, int coffee, string init, double weight)
        {
            Name = n;
            NrOfCoffee = coffee;
            Initials = init;
            Weight = weight;
        }

        public override string ToString()
        {
            return string.Format("Name: {0, -10}, Coffee: {1, -2}, Initials: {2, -4}, Weight: {3, 6:N2}", Name, NrOfCoffee, Initials, Weight);
        }

        public int CompareTo(object obj)
        {
            return this.NrOfCoffee.CompareTo(((Teacher)obj).NrOfCoffee);
        }
    }
    class CompareName : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Teacher)x).Name.CompareTo(((Teacher)y).Name);
        }
    }
    class CompareCoffee : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Teacher)x).NrOfCoffee.CompareTo(((Teacher)y).NrOfCoffee);
        }
    }
    class CompareInitials : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Teacher)x).Initials.CompareTo(((Teacher)y).Initials);
        }
    }

    class CompareWeight : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Teacher)x).Weight.CompareTo(((Teacher)y).Weight);
        }
    }
}
