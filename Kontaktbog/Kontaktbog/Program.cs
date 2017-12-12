using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontaktbog
{
    class Program
    {
        static void Main(string[] args)
        {
            KontaktBog kontaktbog = new KontaktBog();
            string inputMenu;
            List < KontaktBog > kontaktbogsliste = new List<KontaktBog>();
        

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Velkommen til kontaktbogen, vælg en option \n1. tilføj kontakt\n2. se kontaktliste\n3. fjern kontaktperson\n4. Gem til tekstfil\n5. luk programmet");
                inputMenu = Console.ReadLine();

                switch (inputMenu)
                {
                    case "1":
                        string fornavn;
                        string efternavn;
                        string adresse;
                        string telefonNr;

                        Console.WriteLine("indtast fornavn");
                        fornavn = Console.ReadLine();
                        Console.WriteLine("indtast efternavn");
                        efternavn = Console.ReadLine();
                        Console.WriteLine("indtast adresse");
                        adresse = Console.ReadLine();
                        Console.WriteLine("indtast telefonnr");
                        telefonNr = Console.ReadLine();
                        KontaktBog newuser = new KontaktBog(fornavn, efternavn, adresse, telefonNr);
                        kontaktbogsliste.Add(newuser);

                        Console.WriteLine("Kontakt tilføjet klik en vilkårlig tast til at returnere til menuen");
                        Console.ReadKey();

                        break;
                    case "2":
                        foreach(KontaktBog item in kontaktbogsliste)
                        {
                            Console.WriteLine("Fornavn: {0} , Efternavn: {1} , Adresse: {2}, TelefonNummer: {3}", item.fornavn,item.efternavn,item.adresse,item.telefonnr);    
                        }
                        Console.WriteLine("klik en vilkårlig tast til at returnere til menuen");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Vælg venligst objekt at fjerne (0 er første objekt)");
                        foreach (KontaktBog item in kontaktbogsliste)
                        {
                            Console.WriteLine("Fornavn: {0} , Efternavn: {1} , Adresse: {2}, TelefonNummer: {3}", item.fornavn, item.efternavn, item.adresse, item.telefonnr);
                        }
                        string InputRemove = Console.ReadLine();
                        if (int.TryParse(InputRemove, out int remove))
                        {
                            if(remove < kontaktbogsliste.Count() && remove >= 0)
                            {
                                kontaktbogsliste.RemoveAt(remove);
                            }else
                            {
                                Console.WriteLine("nummer uden for scope");
                            }

                        }
                        else
                        {
                            Console.WriteLine("indtast et nummer næste gang");
                        }
                        Console.WriteLine("Tryk vilkårlig tast for at forsætte");
                        Console.ReadKey();
                        break;
                    case "4":
                        using (System.IO.TextWriter tw = new System.IO.StreamWriter(@"C:\Test\Test.txt"))
                            foreach (KontaktBog item in kontaktbogsliste)
                            {
                                tw.WriteLine(string.Format("Fornavn: {0}, efternavn: {1}, Adresse: {2}, Telefonnummer: {3}",item.fornavn, item.efternavn, item.adresse, item.telefonnr));
                            }
                        break;
                    case "5":
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid input click enter");
                        Console.ReadKey();
                        break;
                }

            }
        }
        
    }

    class KontaktBog
    {
        public string fornavn;
        public string efternavn;
        public string adresse;
        public string telefonnr;

        public KontaktBog() { }

        public KontaktBog(string f, string e, string a, string t)
        {
            fornavn = f;
            efternavn = e;
            adresse = a;
            telefonnr = t;
        }
    }
}
