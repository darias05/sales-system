using System;
using System.Collections.Generic;
using System.Text;
using sales_system.DTO;

namespace sales_system.DAO
{
    public class Dao_Sale
    {
        public List<Dto_Sale> CreateSale(List<Dto_Product> Product, List<Dto_Seller> Seller, List<int> Quantity, List<string> Comments)
        {
            List<Dto_Sale> sales = new List<Dto_Sale>();
            int n = 0;
            int i = 0;

            while (i < Product.Count)
            {
                if (n < Seller.Count)
                {
                    sales.Add(new Dto_Sale()
                    {
                        Product = Product[i],
                        Seller = Seller[n],
                        Quantity = Quantity[i],
                        Comments = Comments[i]
                    });
                    i++;
                    n++;
                }
                else
                {
                    n = 0;
                }
            }
            return sales;
        }

    }
}
