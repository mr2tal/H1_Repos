using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyImplementedClass myImplementedClass = new MyImplementedClass("alex", 20);
            Console.WriteLine(myImplementedClass.BirthDay());
            
        }
    }

    abstract class MyAbstractClass
    {
        //fields
        private string _name;
        private int _age;

        //properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            protected set { _age = value; }
        }

        //Constructor
        public MyAbstractClass(string n, int a)
        {
            Name = n;
            Age = a;
        }

        //methods
        public abstract string BirthDay();
    }
    class MyImplementedClass : MyAbstractClass
    {
        //Constructor with base values from MyAbstractClass
        public MyImplementedClass(string n, int a) : base(n,a)
        {

        }
        //override
        public override string BirthDay()
        {
            Age = Age + 1;
            return string.Format("Tilykke med føs'dagen {0}, du er nu {1} gammel",Name,Age);
        }

        //abstract skal overrides
        //non-virtuel kan ikke overrides
        //virtuel kan overrides
    }
    
}
