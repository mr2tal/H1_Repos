using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Mandag_30_11_17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Her allokerer vi plads i heap
            User objUser = new User();
            User obj1 = new User();
            User obj2 = new User("craig", "Playstead", "mm@mm.dk", "kettegaard 70");
            User obj3 = new User() { brugernavn = "per", password = "123", mail = "kk@k.dk" };
            List<int> list = new List<int>();
            list.Add(88);
            int[] arr = new int[] { 5, 6, 9 };
            list.AddRange(arr);

            List<User> userList = new List<User>();

            userList.Add(objUser);
            userList.Add(obj1);
            userList.Add(obj2);
            userList.Add(obj3);

            foreach (User user in userList)
            {
                Console.WriteLine(user);
            }
        }
    }
    class User
    {
        public string brugernavn;
        public string password;
        public string mail;
        public string adresse;

        // construktor
        public User () { }

        public User (string navn, string pass, string m, string adr)
        {
            brugernavn = navn;
            password = pass;
            mail = m;
            adresse = adr;
        }
        public void Udskriv()
        {
            Console.WriteLine("brugernavnet er {0}", brugernavn);
        }
    }
}
