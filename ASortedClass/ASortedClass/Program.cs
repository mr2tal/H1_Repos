using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASortedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact c1 = new Contact("Alpha", "test1", 5);
            Contact c2 = new Contact("Charlie", "test2", 20);
            Contact c3 = new Contact("Delta", "test3", 35);
            Contact c4 = new Contact("Bravo", "test4", 30);
                
            List<Contact> list = new List<Contact>();
            list.Add(c1);
            list.Add(c2);
            list.Add(c3);
            list.Add(c4);
            list.Sort();
            
            foreach (Contact item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    class Contact : IComparable
    {
        //Fields
        private string _name;
        private string _tlf;
        private int _weight;

        //GetSet Methods
        public string GetName()
        {
            return _name;
        }
        public void SetName(string n)
        {
            _name = n;
        }
        public string GetTlf()
        {
            return _tlf;
        }
        public void SetTlf(string t)
        {
            _tlf = t;
        }
        public int GetWeight()
        {
            return _weight;
        }
        public void SetWeight(int w)
        {
            _weight = w;
        }
        //Constructor
        public Contact(string n, string t, int w)
        {
            SetName(n);
            SetTlf(t);
            SetWeight(w);
        }

        public override string ToString()
        {
            return string.Format("navn: {0 , -10}, tlf: {1, -10}, vægt: {2, -10}", GetName(), GetTlf(), GetWeight());
        }
        public int CompareTo(object obj)
        {
            //return this.GetWeight() - ((Contact)obj).GetWeight();
            return this.GetName().CompareTo(((Contact)obj).GetName());

        }

    }
}
