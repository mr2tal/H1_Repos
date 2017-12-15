using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProject
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook jan = new AddressBook("Jan");
            Address a1 = new Address("Hans Peter Nielsen", "Birkehøj 5", "2134123456");
            Address a2 = new Address("Jens Peter Larsen", "Poppelhøj 6", "2345619481");
            jan.AddAddress(a1);
            jan.AddAddress(a2);
            


            AddressBook bo = new AddressBook("Bo");
            Address a3 = new Address("Niels Peter Hansen", "Bøgehøj 7", "213412345636");
            Address a4 = new Address("Lars Peter Jensen", "Fyrrehøj", "2345679801");
            bo.AddAddress(a3);
            bo.AddAddress(a4);
            
            Console.WriteLine(jan);
            Console.WriteLine(bo);

            AddressBook Jan_and_Bo = jan + bo;

            Console.WriteLine(Jan_and_Bo);

            Console.ReadKey();


        }
    }
    class Address
    {
        //fields
        private string _Name;
        private string _StreetAddress;
        private string _Telephone;

        //properties
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string StreetAddress
        {
            get { return _StreetAddress; }
            set { _StreetAddress = value; }
        }
        public string Telephone
        {
            get { return _Telephone; }
            set { _Telephone = value; }
        }

        //Constructor
        public Address(string n, string sa, string t)
        {
            Name = n;
            StreetAddress = sa;
            Telephone = t;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("Name {0}, Street address: {1}, Telephone: {2}", Name, StreetAddress, Telephone);
        }
    }
    class AddressBook
    {
        //fields
        private string _Owner;
        List<Address> _Addresses = new List<Address>();

        //Properties
        public string Owner
        {
            get { return _Owner; }
            set { _Owner = value; }
        }
        //Constructor
        public AddressBook(string o)
        {
            Owner = o;
        }
        //Methods
        public void AddAddress(Address a)
        {
            _Addresses.Add(a);
        }
        public override string ToString()
        {
            string n = string.Format("Owner: {0}\n",Owner);
            foreach(Address item in _Addresses)
            {
               n = n + string.Format("Name :{0}, Street Address: {1},Telephone: {2}\n", item.Name, item.StreetAddress,item.Telephone);
            }
            return n;
        }
        public static AddressBook operator +(AddressBook x, AddressBook y)
        {
            AddressBook ab1 = new AddressBook("");
            ab1.Owner = string.Format("{0} and {1}", x.Owner, y.Owner);
            
            ab1.AddAddress(x._Addresses[0]);
            ab1.AddAddress(x._Addresses[1]);
            ab1.AddAddress(y._Addresses[0]);
            ab1.AddAddress(y._Addresses[1]);

            return ab1;
            
        }
    }
}
