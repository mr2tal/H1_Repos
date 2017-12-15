using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            Person p1 = new Person("Niels", 120, 1.85);
            Person p2 = new Person();
            p2.Name = "Joakim";
            p2.Weight = 80;
            p2.Height = 1.88;
            Person p3 = new Person("Mark", 75, 1.83);

            Console.WriteLine("Print persons");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            
            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p3);

            persons.Sort();
            WriteList("Sorted by Name", persons);
            persons.Sort(new CompareWeight());
            WriteList("Sorted by Weight", persons);
            persons.Sort(new CompareHeight());
            WriteList("Sorted by Height", persons);
            persons.Sort(new CompareBMI());
            WriteList("Sorted by BMI", persons);

            Console.ReadKey();



        }
        public static void WriteList(string s, List<Person> list)
        {
            Console.WriteLine(s);
            foreach (Person item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    class Person : IComparable
    {
        //Fields
        private string _Name;
        private int _Weight;
        private double _Height;

        //Properties

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

        public double Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        public double BMI
        {
            get { return Weight / (Math.Pow(Height, 2)); }
        }

        //Constructors
        public Person()
        {

        }
        public Person(string n, int w, double h)
        {
            Name = n;
            Weight = w;
            Height = h;
        }
        
        //Methods
        public double GetBMI()
        {
            double result = Weight / (Math.Pow(Height, 2));
            return result;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}, Weight: {1}, Height: {2}, BMI: {3}", Name, Weight, Height, GetBMI());
        }
        public int CompareTo(object obj)
        {
            return this.Name.CompareTo(((Person)obj).Name);
        }

    }
    class CompareWeight : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Weight.CompareTo(y.Weight);
        }
    }
    class CompareHeight : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Height.CompareTo(y.Height);
        }
    }
    class CompareBMI : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.GetBMI().CompareTo(y.GetBMI());
        }
    }

}
