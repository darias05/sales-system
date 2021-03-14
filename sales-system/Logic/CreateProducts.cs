using System;
using System.Collections.Generic;
using System.Text;
using sales_system.DTO;
using sales_system.DAO;

namespace sales_system.Logic
{
    public class CreateProducts
    {
        public List<Dto_Product> CreateProduct()
        {
            List<string> Name = new List<string>()
            {
                "500g pack of chicken breast", "pack of cod", "pack of salmon",
                "1 liters of semi-skimmed milk", "500g pack of chicken breast", "kg of Greek yogurt", "500g block of cheese",
                "large bag of apples", "bunches of bananas", "bag of mandarins", "cucumber", "onions",
                "frozen vegetable", "pizzas", "frozen fruit", "pack of toilet paper", 
                "pack of kitchen roll", "tube of toothpaste", "can of deodorant", "bottle of laundry detergent", 
                "bottle of fabric softener", "bottle of washing up liquid", "pack of wet wipes"
            };

            List<double> Price = new List<double>()
            {
                100, 75, 80, 130, 100, 280, 110, 200,
                100, 55, 60, 150, 78, 150, 230, 300,
                200, 65, 40, 30, 68, 85, 260
            };

            List<string> Category = new List<string>()
            {
                "Meat & fish", "Meat & fish", "Meat & fish", 
                "Dairy", "Meat & fish", "Dairy", "Dairy", 
                "Vegetables and fruit", "Vegetables and fruit", "Vegetables and fruit", "Vegetables and fruit", 
                "Vegetables and fruit", "Freezer", "Freezer", "Freezer",
                "Grooming products", "Grooming products", "Grooming products", "Grooming products",
                "Grooming products", "Grooming products", "Grooming products", "Grooming products"
            };

            Dao_Product dao_Product = new Dao_Product();
            List<Dto_Product> List_products = dao_Product.CreateProduct(Name, Price, Category);

            return List_products;
        }
    }
}
