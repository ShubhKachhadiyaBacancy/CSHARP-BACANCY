using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAY10_LINQ_2_
{
    public class ProductManagement
    {
        public ProductManagement()
        {
            Console.WriteLine("DEFAULT CONSTRUCTOR : PRODUCT MANAGEMENT");
        }

        //Show each product’s details along with matching sales records
        public void MethodGetProductsWithMatchingSalesDetails(List<Product> products, List<Sale> sales)
        {
            var productSales = products
            .Join(
                sales,
                product => product.ProductId,
                sale => sale.ProductId,
                (product, sale) => new
                {
                    ProductId = product.ProductId,
                    ProductName = product.Name,
                    Category = product.Category,
                    Price = product.Price,
                    SaleId = sale.SaleId,
                    Quantity = sale.Quantity,
                    SaleDate = sale.SaleDate.ToShortDateString()
                }
            );

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("PRODUCTS AND SALES DETAILS WITH MATCHING SALES(METHOD) : ");
            Console.WriteLine("---------------------------------------------------------");
            foreach (var ps in productSales)
            {
                Console.WriteLine($"PRODUCT ID : {ps.ProductId}\nNAME : {ps.ProductName}\n" +
                    $"CATEGORY : {ps.Category}\nPRICE : {ps.Price}\nSALE ID : {ps.SaleId}\n" +
                    $"QUANTITY : {ps.Quantity}\nSALE DATE : {ps.SaleDate}\n");
            }
        }
        public void QueryGetProductsWithMatchingSalesDetails(List<Product> products, List<Sale> sales)
        {
            var productSales = from product in products
                               join sale in sales on product.ProductId equals sale.ProductId
                               select new
                               {
                                   ProductId = product.ProductId,
                                   ProductName = product.Name,
                                   Category = product.Category,
                                   Price = product.Price,
                                   SaleId = sale.SaleId,
                                   Quantity = sale.Quantity,
                                   SaleDate = sale.SaleDate.ToShortDateString()
                               };

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("PRODUCTS AND SALES DETAILS WITH MATCHING SALES(QUERY) : ");
            Console.WriteLine("--------------------------------------------------------");
            foreach (var ps in productSales)
            {
                Console.WriteLine($"PRODUCT ID : {ps.ProductId}\nNAME : {ps.ProductName}\n" +
                    $"CATEGORY : {ps.Category}\nPRICE : {ps.Price}\nSALE ID : {ps.SaleId}\n" +
                    $"QUANTITY : {ps.Quantity}\nSALE DATE : {ps.SaleDate}\n");
            }
        }

        //Generate a combination of all products and all sales records, regardless of any relationship.
        public void MethodGetProductSalesCombinations(List<Product> products, List<Sale> sales)
        {
            var productSalesCombination = products
                .Join(
                    sales,
                    product => true,
                    sale => true,
                    (product, sale) => new
                    {
                        ProductId = product.ProductId,
                        ProductName = product.Name,
                        Category = product.Category,
                        Price = product.Price,
                        SaleId = sale.SaleId,
                        Quantity = sale.Quantity,
                        SaleDate = sale.SaleDate.ToShortDateString()
                    }
                );

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("COMBINATION OF PRODUCTS AND SALES(METHOD) : ");
            Console.WriteLine("--------------------------------------------");
            foreach (var ps in productSalesCombination)
            {
                Console.WriteLine($"PRODUCT ID : {ps.ProductId}\nNAME : {ps.ProductName}\n" +
                    $"CATEGORY : {ps.Category}\nPRICE : {ps.Price}\nSALE ID : {ps.SaleId}\n" +
                    $"QUANTITY : {ps.Quantity}\nSALE DATE : {ps.SaleDate}\n");
            }
        }
        public void QueryGetProductSalesCombinations(List<Product> products, List<Sale> sales)
        {
            var productSalesCombination = from product in products
                                          from sale in sales
                                          select new
                                          {
                                              ProductId = product.ProductId,
                                              ProductName = product.Name,
                                              Category = product.Category,
                                              Price = product.Price,
                                              SaleId = sale.SaleId,
                                              Quantity = sale.Quantity,
                                              SaleDate = sale.SaleDate.ToShortDateString()
                                          };

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("COMBINATION OF PRODUCTS AND SALES(QUERY) : ");
            Console.WriteLine("-------------------------------------------");
            foreach (var ps in productSalesCombination)
            {
                Console.WriteLine($"PRODUCT ID : {ps.ProductId}\nNAME : {ps.ProductName}\n" +
                    $"CATEGORY : {ps.Category}\nPRICE : {ps.Price}\nSALE ID : {ps.SaleId}\n" +
                    $"QUANTITY : {ps.Quantity}\nSALE DATE : {ps.SaleDate}\n");
            }
        }

        //Modify the first query so that products with no sales still appear in the results
        public void MethodGetProductsWithSalesDetails(List<Product> products, List<Sale> sales)
        {
            var productSales = products
            .GroupJoin(
                sales,
                product => product.ProductId,
                sale => sale.ProductId,
                (product, sale) => new
                {
                    ProductId = product.ProductId,
                    ProductName = product.Name,
                    Category = product.Category,
                    Price = product.Price,
                    Sales = sale.DefaultIfEmpty()
                }
            )
            .SelectMany(
                result => result.Sales.Select(sale => new
                {
                    ProductId = result.ProductId,
                    ProductName = result.ProductName,
                    Category = result.Category,
                    Price = result.Price,
                    SaleId = sale?.SaleId ?? 0,
                    Quantity = sale?.Quantity ?? 0,
                    SaleDate = sale?.SaleDate.ToShortDateString() ?? "No Sales"
                })
            );

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("PRODUCTS AND SALES DETAILS EVEN IF PRODUCT NOT SOLD(METHOD) : ");
            Console.WriteLine("--------------------------------------------------------------");
            foreach (var ps in productSales)
            {
                Console.WriteLine($"PRODUCT ID : {ps.ProductId}\nNAME : {ps.ProductName}\n" +
                    $"CATEGORY : {ps.Category}\nPRICE : {ps.Price}\nSALE ID : {ps.SaleId}\n" +
                    $"QUANTITY : {ps.Quantity}\nSALE DATE : {ps.SaleDate}\n");
            }
        }
        public void QueryGetProductsWithSalesDetails(List<Product> products, List<Sale> sales)
        {
            var productSales = from product in products
                               join sale in sales on product.ProductId equals sale.ProductId into saleGroup
                               from sale in saleGroup.DefaultIfEmpty()
                               select new
                               {
                                   ProductId = product.ProductId,
                                   ProductName = product.Name,
                                   Category = product.Category,
                                   Price = product.Price,
                                   SaleId = sale?.SaleId ?? 0,
                                   Quantity = sale?.Quantity ?? 0,
                                   SaleDate = sale?.SaleDate.ToShortDateString() ?? "No Sales"
                               };

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("PRODUCTS AND SALES DETAILS EVEN IF PRODUCT NOT SOLD(QUERY) : ");
            Console.WriteLine("-------------------------------------------------------------");
            foreach (var ps in productSales)
            {
                Console.WriteLine($"PRODUCT ID : {ps.ProductId}\nNAME : {ps.ProductName}\n" +
                    $"CATEGORY : {ps.Category}\nPRICE : {ps.Price}\nSALE ID : {ps.SaleId}\n" +
                    $"QUANTITY : {ps.Quantity}\nSALE DATE : {ps.SaleDate}\n");
            }
        }

        //Create a report that displays product names along with the quantity sold.
        //Ensure that only products with sales records are included.
        public void MethodGetProductSalesReport(List<Product> products, List<Sale> sales)
        {
            var productSales = products
            .Join(
                sales,
                product => product.ProductId,
                sale => sale.ProductId,
                (product, sale) => new
                {
                    ProductName = product.Name,
                    Quantity = sale.Quantity
                }
            )
            .GroupBy(
                ps => ps.ProductName
            )
            .Select(g => new
            {
                ProductName = g.Key,
                Quantity = g.Sum(p => p.Quantity)
            }
            );

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("PRODUCTS NAME WITH QUANTITY(METHOD) : ");
            Console.WriteLine("--------------------------------------");
            foreach (var ps in productSales)
            {
                Console.WriteLine($"PRODUCT NAME : {ps.ProductName}\nQUANTITY : {ps.Quantity}\n");
            }
        }
        public void QueryGetProductSalesReport(List<Product> products, List<Sale> sales)
        {
            var productSales = from product in products
                               join sale in sales on product.ProductId equals sale.ProductId
                               select new
                               {
                                   ProductName = product.Name,
                                   Quantity = sale.Quantity
                               } into ps
                               group ps by ps.ProductName into g
                               select new
                               {
                                   ProductName = g.Key,
                                   Quantity = g.Sum(p => p.Quantity)
                               };

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("PRODUCTS NAME WITH QUANTITY(QUERY) : ");
            Console.WriteLine("-------------------------------------");
            foreach (var ps in productSales)
            {
                Console.WriteLine($"PRODUCT NAME : {ps.ProductName}\nQUANTITY : {ps.Quantity}\n");
            }
        }

        //List all products that have been sold more than 10 times in total, using a nested
        //LINQ query.
        public void MethodGetProductsSoldMoreThan10Times(List<Product> products, List<Sale> sales)
        {
            var productsSales = products
                .Join(
                    sales,
                    product => product.ProductId,
                    sale => sale.ProductId,
                    (product, sale) => new
                    {
                        ProductName = product.Name,
                        Quantity = sale.Quantity
                    }
                )
                .GroupBy(
                    g => g.ProductName
                )
                .Select(ps => new
                {
                    ProductName = ps.Key,
                    Quantity = ps.Sum(p => p.Quantity)
                }
                ).Where(x => x.Quantity > 10);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("PRODUCTS NAME WITH MINIMUM QUANTITY 10(METHOD) : ");
            Console.WriteLine("-------------------------------------------------");
            foreach (var ps in productsSales)
            {
                Console.WriteLine($"PRODUCT NAME : {ps.ProductName}\nQUANTITY : {ps.Quantity}");
            }
        }
        public void QueryGetProductsSoldMoreThan10Times(List<Product> products, List<Sale> sales)
        {
            var productSales = from product in products
                               join sale in sales on product.ProductId equals sale.ProductId
                               select new
                               {
                                   ProductName = product.Name,
                                   Quantity = sale.Quantity
                               } into ps
                               group ps by ps.ProductName into g
                               select new
                               {
                                   ProductName = g.Key,
                                   Quantity = g.Sum(p => p.Quantity) 
                               } into grp
                               where grp.Quantity > 10
                               select grp;

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("PRODUCTS NAME WITH MINIMUM QUANTITY 10(QUERY) : ");
            Console.WriteLine("------------------------------------------------");
            foreach (var ps in productSales)
            {
                Console.WriteLine($"PRODUCT NAME : {ps.ProductName}\nQUANTITY : {ps.Quantity}");
            }
        }

        //Group sales data by product name, and display the total quantity sold per product.
        public void MethodGetProductNameAndTotalQuantitySold(List<Product> products, List<Sale> sales)
        {
            var productSales = products
            .GroupJoin(
                sales, 
                product => product.ProductId, 
                sale => sale.ProductId, 
                (product, saleGroup) => new
                {
                    ProductName = product.Name,
                    TotalQuantitySold = saleGroup.Sum(s => s.Quantity)
                }
            )
            .Select(item => new
            {
                ProductName = item.ProductName,
                Quantity = item.TotalQuantitySold == 0 ? 0 : item.TotalQuantitySold
            });

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("PRODUCTS NAME WITH TOTAL QUANTITY (METHOD) : ");
            Console.WriteLine("---------------------------------------------");

            foreach (var ps in productSales)
            {
                Console.WriteLine($"PRODUCT NAME : {ps.ProductName}\nQUANTITY : {ps.Quantity}\n");
            }
        }
        public void QueryGetProductNameAndTotalQuantitySold(List<Product> products, List<Sale> sales)
        {
            var productSales = from product in products
                               join sale in sales on product.ProductId equals sale.ProductId into saleGroup
                               select new
                               {
                                   ProductName = product.Name,
                                   TotalQuantitySold = saleGroup.Sum(s => s.Quantity)
                               } into item
                               select new
                               {
                                   ProductName = item.ProductName,
                                   Quantity = item.TotalQuantitySold == 0 ? 0 : item.TotalQuantitySold
                               };

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("PRODUCTS NAME WITH TOTAL QUANTITY (QUERY) : ");
            Console.WriteLine("--------------------------------------------");

            foreach (var ps in productSales)
            {
                Console.WriteLine($"PRODUCT NAME : {ps.ProductName}\nQUANTITY : {ps.Quantity}\n");
            }
        }

        //Implement an alternative approach to achieve the same result and analyze the differences.
        public void MethodGetProductNameAndTotalQuantitySoldAlternative(List<Product> products, List<Sale> sales)
         {
            var productSales = products
                .GroupJoin(
                    sales,
                    product => product.ProductId,
                    sale => sale.ProductId,
                    (product, saleGroup) => new
                    {
                        ProductName = product.Name,
                        Sales = saleGroup.DefaultIfEmpty() // Ensures that products with no sales still appear
                    })
                .ToLookup(
                    productGroup => productGroup.ProductName,  // Group by ProductName
                    productGroup => productGroup.Sales.Sum(sale => sale?.Quantity ?? 0)  // Sum quantities for each product
                )
                .Select(group => new
                {
                    ProductName = group.Key,
                    TotalQuantitySold = group.Sum()  // Sum up all quantities for the product
                })
                .ToList();

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("PRODUCTS NAME WITH TOTAL QUANTITY ALTERNATIVE(METHOD) : ");
            Console.WriteLine("--------------------------------------------------------");
            foreach (var ps in productSales)
            {
                Console.WriteLine($"PRODUCT NAME : {ps.ProductName}\nQUANTITY : {ps.TotalQuantitySold}\n");
            }
        }
        public void QueryGetProductNameAndTotalQuantitySoldAlternative(List<Product> products, List<Sale> sales)
        {
            var productSales = from product in products
                               join sale in sales on product.ProductId equals sale.ProductId into saleGroup
                               from sale in saleGroup.DefaultIfEmpty()
                               select new
                               {
                                   ProductName = product.Name,
                                   Quantity = sale?.Quantity ?? 0
                               } into ps
                               group ps by ps.ProductName into g
                               select new
                               {
                                   ProductName = g.Key,
                                   Quantity = g.Sum(p => p.Quantity)
                               };

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("PRODUCTS NAME WITH TOTAL QUANTITY ALTERNATIVE(QUERY) : ");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var ps in productSales)
            {
                Console.WriteLine($"PRODUCT NAME : {ps.ProductName}\nQUANTITY : {ps.Quantity}\n");
            }
        }
        
        //Retrieve a unique list of product categories.
        public void MethodGetDistinctProductCategory(List<Product> products)
        {
            var categories = products
                .Select(p => p.Category)
                .Distinct();

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("DISTINCT PRODUCT CATEGORIES(METHOD) : ");
            Console.WriteLine("--------------------------------------");
            foreach (var category in categories)
            {
                Console.WriteLine($"PRODUCT CATEGORY : {category}");
            }
        }
        public void QueryGetDistinctProductCategory(List<Product> products)
        {
            var categories = (from product in products
                              select product.Category).Distinct();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("DISTINCT PRODUCT CATEGORIES(QUERY) : ");
            Console.WriteLine("-------------------------------------");
            foreach (var category in categories)
            {
                Console.WriteLine($"PRODUCT CATEGORY : {category}");
            }
        }

        //Merge two product collections(from different suppliers), ensuring no duplicate product
        //names.
        public void MethodGetProductFromDifferentSupplier(List<Product> products, List<Product> productsFromDifferentSupplier)
        {
            var productNames = products
                .Select(p => p.Name)
                .Union(productsFromDifferentSupplier
                    .Select(p => p.Name)
                );

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("DISTINCT PRODUCT NAMES FROM DIFFERENT SUPPLIERS (METHOD) : ");
            Console.WriteLine("-----------------------------------------------------------");
            foreach (var productName in productNames)
            {
                Console.WriteLine($"PRODUCT NAME : {productName}");
            }
        }
        public void QueryGetProductFromDifferentSupplier(List<Product> products, List<Product> productsFromDifferentSupplier)
        {
            var productNames = (from product in products
                                select product.Name)
                    .Union(from product in productsFromDifferentSupplier
                           select product.Name);

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("DISTINCT PRODUCT NAMES FROM DIFFERENT SUPPLIERS (QUERY) : ");
            Console.WriteLine("----------------------------------------------------------");
            foreach (var productName in productNames)
            {
                Console.WriteLine($"PRODUCT NAME : {productName}");
            }
        }

        //Identify products that appear in both collections.
        public void MethodGetCommonProductFromDifferentSupplier(List<Product> products, List<Product> productsFromDifferentSupplier)
        {
            var productNames = products
                .Select(p => p.Name)
                .Intersect(productsFromDifferentSupplier
                    .Select(p => p.Name)
                );

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("COMMON PRODUCT NAMES FROM DIFFERENT SUPPLIERS(METHOD) : ");
            Console.WriteLine("--------------------------------------------------------");
            foreach (var productName in productNames)
            {
                Console.WriteLine($"PRODUCT NAME : {productName}");
            }
        }
        public void QueryGetCommonProductFromDifferentSupplier(List<Product> products, List<Product> productsFromDifferentSupplier)
        {
            var productNames = (from product in products
                                select product.Name)
                    .Intersect(from product in productsFromDifferentSupplier
                               select product.Name);


            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("COMMON PRODUCT NAMES FROM DIFFERENT SUPPLIERS(QUERY) : ");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var productName in productNames)
            {
                Console.WriteLine($"PRODUCT NAME : {productName}");
            }
        }

        //Find products that exist in one collection but not in the other.
        public void MethodGetFindProductsInOneCollectionButNotInAnother(List<Product> products, List<Product> productsFromDifferentSupplier)
        {
            var productNames = products
                .Select(p => p.Name)
                .Except(productsFromDifferentSupplier
                    .Select(p => p.Name)
                );

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("PRODUCT NAMES IN ONE COLLECTION BUT NOT IN SECOND(METHOD) : ");
            Console.WriteLine("------------------------------------------------------------");
            foreach (var productName in productNames)
            {
                Console.WriteLine($"PRODUCT NAME : {productName}");
            }
        }
        public void QueryGetFindProductsInOneCollectionButNotInAnother(List<Product> products, List<Product> productsFromDifferentSupplier)
        {
            var productNames = (from product in products
                                select product.Name)
                    .Except(from product in productsFromDifferentSupplier
                            select product.Name);

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("PRODUCT NAMES IN ONE COLLECTION BUT NOT IN SECOND(QUERY) : ");
            Console.WriteLine("-----------------------------------------------------------");
            foreach (var productName in productNames)
            {
                Console.WriteLine($"PRODUCT NAME : {productName}");
            }
        }

        //Write a LINQ query that retrieves product names but delays execution.
        //Modify the dataset before execution and analyze how the results change.
        public void MethodGetDelayedProductNames(List<Product> products)
        {
            var productNames = products.Select(p => p.Name);
            products.Add(new Product(6,"Charger", "Accessories",2000));

            Console.WriteLine("---------------------------------");
            Console.WriteLine("DELAYED PRODUCT NAMES (METHOD) : ");
            Console.WriteLine("---------------------------------");
            foreach (var productName in productNames)
            {
                Console.WriteLine($"PRODUCT NAME : {productName}");
            }
        }
        public void QueryGetDelayedProductNames(List<Product> products)
        {
            var productNames = from product in products
                               select product.Name;
            products.Add(new Product(6, "Charger", "Accessories", 2000));

            Console.WriteLine("--------------------------------");
            Console.WriteLine("DELAYED PRODUCT NAMES (QUERY) : ");
            Console.WriteLine("--------------------------------");
            foreach (var productName in productNames)
            {
                Console.WriteLine($"PRODUCT NAME : {productName}");
            }
        }

        //Convert the query to execute immediately and compare the results.
        public void MethodGetImmediatelyProductNames(List<Product> products)
        {
            var productNames = products.Select(p => p.Name).ToList();
            products.Add(new Product(7, "Cable", "Accessories", 2000));

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("IMMEDIATE PRODUCT NAMES (METHOD) : ");
            Console.WriteLine("-----------------------------------");
            foreach (var productName in productNames)
            {
                Console.WriteLine($"PRODUCT NAME : {productName}");
            }
        }
        public void QueryGetImmediatelyProductNames(List<Product> products)
        {
            var productNames = (from product in products
                                select product.Name).ToList();
            products.Add(new Product(7, "Cable", "Accessories", 2000));

            Console.WriteLine("----------------------------------");
            Console.WriteLine("IMMEDIATE PRODUCT NAMES (QUERY) : ");
            Console.WriteLine("----------------------------------");
            foreach (var productName in productNames)
            {
                Console.WriteLine($"PRODUCT NAME : {productName}");
            }
        }
    }
}
