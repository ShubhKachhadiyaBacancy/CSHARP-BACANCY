using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY10_LINQ_2_
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime SaleDate { get; set; }

        public Sale()
        {
            Console.WriteLine("DEFAULT CONSTRUCTOR : SALE");
        }

        public Sale(int saleId,int productId,int quantity,DateTime saleDate)
        {
            Console.WriteLine("PARAMETERISED CONSTRUCTOR : SALE");
            this.SaleId = saleId;
            this.ProductId = productId;
            this.Quantity = quantity;
            this.SaleDate = saleDate;
        }

        public static List<Sale> GetSales() 
        {
            return new List<Sale> {
                new Sale(1, 1, 5, new DateTime(2023, 12, 1)),
                new Sale(2, 1, 3, new DateTime(2023, 12, 2)),
                new Sale(3, 3, 10, new DateTime(2023, 12, 3)),
                new Sale(4, 4, 2, new DateTime(2023, 12, 4)),
                new Sale(5, 5, 1, new DateTime(2023, 12, 5)),
                new Sale(6, 3, 7, new DateTime(2023, 12, 6)),
                new Sale(7, 1, 8, new DateTime(2023, 12, 7))
            };
        }
    }
}
