using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOpgaveFigur
{
    class Program
    {
        static void Main(string[] args)
        {
            Kvadrat k1 = new Kvadrat(5);
            Console.WriteLine(k1.GetAreal());
            Cirkel C1 = new Cirkel(5);
            Console.WriteLine(C1.GetAreal());

        }
    }
    abstract class Figur
    {
        //fields
        private double _size;

        //abstract methods
        abstract public double GetAreal();


        //methods
        public double GetSize()
        {
            return _size;
        }
        protected void SetSize(double s)
        {
            _size = s;
        }

        //constructor
        public Figur(double s)
        {
            SetSize(s);
        }

    }
    class Kvadrat : Figur
    {
        public Kvadrat(double s) : base(s)
        {

        }

        //override
        public override double GetAreal()
        {
            return GetSize() * GetSize();
        }
    }
    class Cirkel : Figur
    {
        public Cirkel(double s) : base(s)
        {

        }

        public override double GetAreal()
        {
            return Math.Pow(GetSize(), 2) * Math.PI;
        }
    }
}
