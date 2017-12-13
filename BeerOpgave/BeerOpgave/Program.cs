using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate
            Beer b1 = new Beer("thy", Beer.BeerType.Pilsner, 4.7f, 70);
            Beer b2 = new Beer("carlsberg lager", Beer.BeerType.Lager, 5.3f, 40);
            Beer b3 = new Beer();
            b3.SetName("Tuborg Ale");
            b3.SetBeerType(Beer.BeerType.Ale);
            b3.SetPercent(3.9f);
            b3.SetVolume(50);
            //create List
            List<Beer> beerList = new List<Beer>();
            beerList.Add(b1);
            beerList.Add(b2);
            beerList.Add(b3);

            Console.WriteLine("unsorted");
            foreach(Beer item in beerList)
            {
                Console.WriteLine(item.ToString());
            }

            beerList.Sort(new CompareName());
            Console.WriteLine("Sorted by name");
            foreach(Beer item in beerList)
            {
                Console.WriteLine(item.ToString());
            }

            beerList.Sort(new CompareBeerType());
            Console.WriteLine("Sorted by beer type");
            foreach (Beer item in beerList)
            {
                Console.WriteLine(item.ToString());
            }

            beerList.Sort(new ComparePercent());
            Console.WriteLine("Sorted by percent");
            foreach (Beer item in beerList)
            {
                Console.WriteLine(item.ToString());
            }

            beerList.Sort(new CompareVolume());
            Console.WriteLine("Sorted by volume");
            foreach (Beer item in beerList)
            {
                Console.WriteLine(item.ToString());
            }

            beerList.Sort(new CompareUnits(false));
            Console.WriteLine("Sorted by units");
            foreach (Beer item in beerList)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("b1 + b2");
            Beer b4 = b1 + b2;
            Console.WriteLine(b4.ToString());



        }
    }
    class Beer 
    {
        //fields
        public enum BeerType
        {
            Lager,
            Pilsner,
            Ale,

        }
        private string _name;
        private float _percent;
        private int _volume;
        private BeerType _beerType;
        
        //getset methods
        public string GetName()
        {
            return _name;
        }
        public void SetName(string n)
        {
            _name = n;
        }

        public BeerType GetBeerType()
        {
            return _beerType;
        }
        public void SetBeerType(BeerType b)
        {
            _beerType = b;
        }
        public float GetPercent()
        {
            return _percent;
        }
        public void SetPercent(float p)
        {
            _percent = p;
        }
        public int GetVolume()
        {
            return _volume;
        }
        public void SetVolume(int v)
        {
            _volume = v;
        }
        public float GetUnits()
        {
            float units = GetVolume() * (GetPercent() / 150);
            return units;
        }

        //Constructors
        public Beer()
        {

        }
        public Beer(string n, BeerType b, float p, int v)
        {
            SetName(n);
            SetBeerType(b);
            SetPercent(p);
            SetVolume(v);
        }
        //Overrides

        public override string ToString()
        {
            return string.Format("Navn: {0}, Type: {1}, Procent: {2}, Volume: {3}, genstande: {4}", GetName(), GetBeerType(), GetPercent(), GetVolume(), GetUnits());
        }

        //overload
        public static Beer operator +(Beer b1, Beer b2)
        {
            Beer b4 = new Beer();
            b4.SetName(b1.GetName() + b2.GetName());
            b4.SetBeerType(b1.GetBeerType());
            b4.SetPercent(b1.GetPercent() + b2.GetPercent());
            b4.SetVolume(b1.GetVolume() + b2.GetVolume());
            return b4;
        }
    }
    class CompareName : IComparer<Beer>
    {
        public int Compare(Beer x, Beer y)
        {
            return x.GetName().CompareTo(y.GetName());
        }
    }
    class CompareBeerType : IComparer<Beer>
    {
        public int Compare(Beer x, Beer y)
        {
            return x.GetBeerType().CompareTo(y.GetBeerType());
        }
    }
    class ComparePercent : IComparer<Beer>
    {
        public int Compare(Beer x, Beer y)
        {
            return x.GetPercent().CompareTo(y.GetPercent());
        }
    }
    class CompareVolume : IComparer<Beer>
    {
        public int Compare(Beer x, Beer y)
        {
            return x.GetVolume().CompareTo(y.GetVolume());
        }
    }
    class CompareUnits : IComparer<Beer>
    {
        private bool _ascend;
        public CompareUnits(bool asc)
        {
            _ascend = asc;
        }
        public int Compare(Beer x, Beer y)
        {
            if (_ascend)
            {
                return x.GetUnits().CompareTo(y.GetUnits());
            }
            else
            {
                return y.GetUnits().CompareTo(x.GetUnits());
            }

        }
    }

}
