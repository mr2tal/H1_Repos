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
            Kvadrat k1 = new Kvadrat("kvadrat1", 5);
            Kvadrat k2 = new Kvadrat("kvadrat2", 10);
            k1.SetAreal(k1.GetSize());
            k2.SetAreal(k2.GetSize());
            Cirkel c1 = new Cirkel("cirkel1", 1);
            c1.SetAreal(c1.GetSize());
            Console.WriteLine(k1.ToString());
            Console.WriteLine(c1.ToString());
            Furniture f1 = new Furniture(5);


            List<Object> list = new List<Object>();
            list.Add(k1);
            list.Add(k2);
            list.Add(c1);
            list.Add(f1);

            Object[] arr = new Object[3];
            arr[0] = k1;
            arr[1] = c1;
            arr[2] = f1;


            foreach (Object item in arr)
            {
                Console.WriteLine(item.ToString());
            }
            

            foreach (Object item in list)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
    abstract class Figur
    {
        //fields
        private string _name;
        private double _size;
        protected double _areal;

        //abstract methods
        abstract public double GetAreal();
        abstract public void SetAreal(double s);

        //methods
        public string GetName()
        {
            return _name;
        }
        public void SetName(string n)
        {
            _name = n;
        }
        public double GetSize()
        {
            return _size;
        }
        protected void SetSize(double s)
        {
            _size = s;
        }

        //constructor
        public Figur(string n, double s)
        {
            SetName(n);
            SetSize(s);
        }
        //override
        public override string ToString()
        {
            return string.Format("Navn er {0}, Size er {1} og Arealet er {2}", GetName(), GetSize(), GetAreal());
        }

    }
    class Kvadrat : Figur
    {
        public Kvadrat(string n,double s) : base(n,s)
        {

        }

        //override
        public override double GetAreal()
        {
            return _areal; 
        }
        public override void SetAreal(double s)
        {
            _areal = s * s;
        }

    }
    class Cirkel : Figur
    {
        //Constructor
        public Cirkel(string n, double s) : base(n,s)
        {

        }
        //Override
        public override double GetAreal()
        {
            return _areal;
        }

        public override void SetAreal(double s)
        {
            _areal = Math.Pow(GetSize(), 2) * Math.PI;
        }
    }
    class Furniture
    {
        //fields
        private int _size;

        //methods
        public int GetSize()
        {
            return _size;
        }
        public void SetSize(int s)
        {
            _size = s;
        }

        //override
        public override string ToString()
        {
            return string.Format("størrelse: {0}", GetSize());
        }
        //constructor
        public Furniture(int s)
        {
            SetSize(s);
        }
    }
}
