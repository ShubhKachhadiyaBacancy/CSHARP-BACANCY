using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY10_LINQ_2_
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        public Product()
        {
            Console.WriteLine("DEFAULT CONSTRUCTOR : PRODUCT");
        }

        public Product(int productId,string name,string category,double price)
        {
            Console.WriteLine("PARAMETERISED CONSTRUCTOR : PRODUCT");
            this.ProductId = productId;
            this.Name = name;
            this.Category = category;
            this.Price = price;
        }

        public static List<Product> GetProducts()
        {
            return new List<Product>() {
                new Product(1, "Phone", "Electronics", 25000),
                new Product(2, "Laptop", "Electronics", 60000),
                new Product(3, "Headphones", "Accessories", 2000),
                new Product(4, "Refrigerator", "Appliances", 30000),
                new Product(5, "Microwave", "Appliances", 15000)
            };
        }
        public static List<Product> GetProductsFromDifferentSupplier()
        {
            return new List<Product>() {
                new Product(1, "Phone", "Electronics", 25000),
                new Product(2, "Laptop", "Electronics", 60000),
                new Product(3, "Earphones", "Accessories", 2000),
                new Product(4, "Mixer", "Appliances", 5000),
                new Product(5, "Oven", "Appliances", 15000)
            };
        }
    }
}
