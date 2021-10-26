namespace MCA.App.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using MCA.App.Data;
    public class ProductService : IProductService
    {
        public void GetStats(List<Product> products)
        {
            foreach (var i in GetProductsByName(products))
            {
                string StateOfWeight = i.Weight == 0 ? "N/A" : i.Weight.ToString() + "g";

                Console.WriteLine("Name : {0} \nPrice : ${1}  \nWeight {2} \nDescription : {3}... \n ", i.Name, i.Price, StateOfWeight, i.Description.Substring(0,10));
            }
            IsDomestic(products);
        }

        public IEnumerable<Product> GetProductsByName(List<Product> products)
        {
            return from i in products
                   orderby i.Name
                   select i;
        }

        public void IsDomestic(List<Product> products)
        {
            double priced = 0;
            double pricei = 0;

            int countd = 0;
            int counti = 0;

            foreach (var i in products)
            {
                if (i.Domestic)
                {
                    priced += i.Price;
                    countd += 1;
                }
                else
                {
                    pricei += i.Price;
                    counti += 1;
                }
            }

            Console.WriteLine("Domestic cost : $ {0} \nImported price : $ {1}", priced, pricei);
            Console.WriteLine("Domestic count : {0} \nImported count : {1}", countd, counti);
        }
    }
}