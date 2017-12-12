using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LottoNRB
{
    public static class MyStaticValues
    { 
    }
    class Program
    {
        static void Main(string[] args)
        {
            int sameresults;
            List<List<int>> coupon = new List<List<int>>();
            string inputrows;
            Console.WriteLine("Indtast antal rækker fra 1 - 10");
            inputrows = Console.ReadLine();
            if (int.TryParse(inputrows,out int rows))
            {
               coupon = GenerateRows(rows);
            } else
            {
                Console.WriteLine("invalid input");
            }

            
            List<int> Lotto = new List<int>();

            for (int i = 0; Lotto.Count < 10; i++)
            {
                int number = RollNumber();
                if (Lotto.Contains(number) == false)
                {
                    Lotto.Add(number);  
                }

            }
            Lotto.Sort();
            Console.Write("Lotto Numrene er: ");
            foreach (int lottonumber in Lotto)
            {
                Console.Write("{0} ",lottonumber);
            }
            Console.WriteLine("");

            foreach (List<int> list in coupon)
            {
                for (int i = 0; list.Count < 10; i++)
                {
                    int number = RollNumber();
                    if (list.Contains(number) == false)
                    {
                        list.Add(number);
                    }
                }
                list.Sort();
                foreach (int number in list)
                {
                    Console.Write("{0} ", number);
                }
                Console.WriteLine("");

                sameresults = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (list.Contains(Lotto[i]))
                    {
                        sameresults = sameresults + 1;
                    }
                }

                Console.WriteLine("{0} rigtige", sameresults);
                
            }


        }

        public static int RollNumber()
        {
            System.Threading.Thread.Sleep(200);
            Random rnd = new Random();
            int random = rnd.Next(1, 36);            
            return random;        
        }
        
        public static List<List<int>> GenerateRows(int x)
        {
            List<List<int>> LottoRow = new List<List<int>>();
            for (int i = 0; LottoRow.Count < x; i++)
            {
                LottoRow.Add(new List<int>(){});   
            }
            return LottoRow;
        }
    }
}
