using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottotest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> coupon = new List<List<int>>();

            for (int i = 0; i < 10; i++)
            {
                coupon.Add(new List<int>());
            }
            Console.WriteLine(coupon);
        }
    }
}
