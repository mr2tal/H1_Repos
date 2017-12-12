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
            k1.SetAreal(k1.GetSize());
            Cirkel C1 = new Cirkel(1);
            C1.SetAreal(C1.GetSize());
            Console.WriteLine(k1.ToString());
            Console.WriteLine(C1.ToString());
        }
    }
    abstract class Figur
    {
        //fields
        private double _size;
        protected double _Areal;

        //abstract methods
        abstract public double GetAreal();
        abstract public void SetAreal(double s);

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
        //override
        public override string ToString()
        {
            return string.Format("Size er {0} og Arealet er {1}", GetSize(), GetAreal());
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
            return _Areal; 
        }
        public override void SetAreal(double s)
        {
            _Areal = s * s;
        }

    }
    class Cirkel : Figur
    {
        //Constructor
        public Cirkel(double s) : base(s)
        {

        }
        //Override
        public override double GetAreal()
        {
            return _Areal;
        }

        public override void SetAreal(double s)
        {
            _Areal = Math.Pow(GetSize(), 2) * Math.PI;
        }
    }
}
