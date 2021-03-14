using System;
using System.Collections.Generic;
using System.Text;
using sales_system.DTO;
using sales_system.DAO;

namespace sales_system.Logic
{
    public class CreateSales
    {
        public List<Dto_Sale> CreateSale(List<Dto_Seller> Sellers, List<Dto_Product> Products)
        {
            List<int> Quantity = new List<int>()
            {
                5, 7, 8, 13, 5, 18, 21, 2,
                7, 3, 6, 13, 5, 8, 7, 1,
                2, 4, 5, 12, 14, 1, 1
            };

            List<string> Comments = new List<string>()
            {
                "sold out", "sold out", "sold out", "sold out", "sold out", "sold out", "sold out", "sold out",
                "sold out", "sold out", "sold out", "sold out", "sold out", "sold out", "sold out", "sold out",
                "sold out", "sold out", "sold out", "sold out", "sold out", "sold out", "sold out"
            };

            Dao_Sale dao_Sale = new Dao_Sale();
            List<Dto_Sale> List_Sales = dao_Sale.CreateSale(Products, Sellers, Quantity, Comments);

            return List_Sales;
        }
    }
}
