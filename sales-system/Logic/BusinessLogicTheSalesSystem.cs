using System;
using System.Collections.Generic;
using System.Text;
using sales_system.DTO;

namespace sales_system.Logic
{
    public class BusinessLogicTheSalesSystem
    {
        public static void SaleOfTheCheapestProduct(List<Dto_Sale> Sales)
        {
            int document = 0;
            double valuesell = 0;
            double productPrice = 0;
            string name = "";
            string productName = "";
            string productCategory = "";

            for (int j = 0; j < Sales.Count; j++)
            {
                double price = Sales[j].Product.Price;

                if (valuesell == 0)
                {
                    name = Sales[j].Seller.Name;
                    document = Sales[j].Seller.Document;
                    productName = Sales[j].Product.Name;
                    productPrice = Sales[j].Product.Price;
                    productCategory = Sales[j].Product.Category;
                    valuesell = productPrice;
                }
                else if (price < valuesell)
                {
                    name = Sales[j].Seller.Name;
                    document = Sales[j].Seller.Document;
                    productName = Sales[j].Product.Name;
                    productPrice = Sales[j].Product.Price;
                    productCategory = Sales[j].Product.Category;
                    valuesell = productPrice;
                }
            }
            Console.WriteLine("\nSale Of The Cheapest Product");
            Console.WriteLine("\nNombre del Vendedor: " + name);
            Console.WriteLine("Documento del vendedor: " + document);
            Console.WriteLine("Nombre del producto: " + productName);
            Console.WriteLine("Categoria del producto: " + productCategory);
            Console.WriteLine("Valor unitario del producto: " + productPrice);
        }

        public static void ProductsPriceAverage(List<Dto_Product> Products)
        {
            double valueProducts = 0;
            double productPrice;
            double ProductsPriceAverage;

            for (int i = 0; i < Products.Count; i++)
            {
                productPrice = Products[i].Price;
                valueProducts = productPrice + valueProducts;
            }

            ProductsPriceAverage = valueProducts / Products.Count;
            Console.WriteLine("\nProducts Price Average");
            Console.WriteLine("\nEl precio promedio de venta de los " + Products.Count + " productos es de = " + ProductsPriceAverage);
        }

        public static void NumberOfUnitsSold(List<Dto_Sale> Sales)
        {
            int results = 0;
            int units;
            int count;

            Console.WriteLine("\nNumber Of Units Sold\n");
            while (results < Sales.Count)
            {
                int repeatedProduct = 0;
                int repeatedProductInConsole = 0;
                units = Sales[results].Quantity;

                for (int i = 0; i < Sales.Count; i++)
                {
                    if (Sales[i].Product.Name == Sales[results].Product.Name)
                    {
                        repeatedProduct++;

                        if (repeatedProduct > 1)
                        {
                            count = Sales[i].Quantity;
                            units = units + count;
                        }
                    }
                }

                for (int j = 0; j < results; j++)
                {
                    if (Sales[j].Product.Name == Sales[results].Product.Name)
                    {
                        repeatedProductInConsole++;
                    }
                }

                if (repeatedProductInConsole == 0)
                {
                    Console.WriteLine("El producto " + Sales[results].Product.Name + " tiene un total de " + units + " vendidas.");
                }
                results++;
            }
        }

        public static void CheapestProduct(List<Dto_Product> Products)
        {
            double valuesell = 0;
            double productPrice = 0;
            string productName = "";
            string productCategory = "";

            for (int j = 0; j < Products.Count; j++)
            {
                double price = Products[j].Price;

                if (valuesell == 0)
                {
                    productName = Products[j].Name;
                    productPrice = Products[j].Price;
                    productCategory = Products[j].Category;
                    valuesell = productPrice;
                }
                else if (price > valuesell)
                {
                    productName = Products[j].Name;
                    productPrice = Products[j].Price;
                    productCategory = Products[j].Category;
                    valuesell = productPrice;
                }
            }
            Console.WriteLine("\nCheapest Product");
            Console.WriteLine("\nNombre del producto: " + productName);
            Console.WriteLine("Categoria del producto: " + productCategory);
            Console.WriteLine("Valor unitario del producto: " + productPrice);
        }
    }
}
