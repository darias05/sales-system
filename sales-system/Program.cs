using System;
using System.Collections.Generic;
using sales_system.Logic;
using sales_system.DTO;

namespace sales_system
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateSellers createSellers = new CreateSellers();
            List<Dto_Seller> sellers = createSellers.CreateSeller();

            CreateProducts createProducts = new CreateProducts();
            List<Dto_Product> products = createProducts.CreateProduct();

            CreateSales createSales = new CreateSales();
            List<Dto_Sale> sales = createSales.CreateSale(sellers, products);

            BusinessLogicTheSalesSystem.SaleOfTheCheapestProduct(sales);
            BusinessLogicTheSalesSystem.ProductsPriceAverage(products);
            BusinessLogicTheSalesSystem.NumberOfUnitsSold(sales);
            BusinessLogicTheSalesSystem.CheapestProduct(products);
        }
    }
}
