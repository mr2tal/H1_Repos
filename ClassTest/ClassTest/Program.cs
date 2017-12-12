using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>()
            {
                new Product
                {
                    ProductID = 5,
                    Name = "dør",
                    Description = "man kan åbne og lukke den",
                    Weight = 25.53,
                },
                new Product
                {
                    ProductID = 6,
                    Name = "væg",
                    Description = "4 vægge skal bruges",
                    Weight = 432.2
                }

            };
            product[0].SetBarCode("421312");
            product[1].SetBarCode("1234");

            foreach(Product item in product)
            {
                Console.WriteLine("ID = {0}, name = {1}, description = {2}, weight = {3}, barcode = {4}",
                    item.ProductID, item.Name, item.Description, item.Weight,item.GetBarCode());
            }
        }
    }
    class Product
    {
        public int ProductID;

        public string Description { get; set; }

        public string Name { get; set; }

        public double Weight { get; set; }

        private string BarCode;


        public string GetBarCode()
        {
            return BarCode;
        }

        public void SetBarCode(string input)
        {
            BarCode = input;
        }

        public void ProductTest()
        {
           
        }
    }
}
