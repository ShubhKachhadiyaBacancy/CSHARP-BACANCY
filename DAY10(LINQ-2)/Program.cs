
//1. Show each product’s details along with its sales records, even if it hasn’t been sold yet.
//2. Generate a combination of all products and all sales records, regardless of any
//   relationship.
//3. Modify the first query so that products with no sales still appear in the results
//4. Create a report that displays product names along with the quantity sold. Ensure that
//   only products with sales records are included.
//5. List all products that have been sold more than 50 times in total, using a nested
//   LINQ query.
//6. Group sales data by product name, and display the total quantity sold per product.
//7. Implement an alternative approach to achieve the same result and analyze the differences.
//8. Retrieve a unique list of product categories.
//9. Merge two product collections (from different suppliers), ensuring no duplicate product
//   names.
//10.Identify products that appear in both collections.
//11.Find products that exist in one collection but not in the other.
//12.Write a LINQ query that retrieves product names but delays execution.
//   Modify the dataset before execution and analyze how the results change.
//13.Convert the query to execute immediately and compare the results.


using DAY10_LINQ_2_;

List<Product> products = Product.GetProducts();
List<Product> productsFromDifferentSupplier = Product.GetProductsFromDifferentSupplier();
List<Sale> sales = Sale.GetSales();

ProductManagement productManagement = new ProductManagement();

//productManagement.MethodGetProductsWithMatchingSalesDetails(products, sales);
//productManagement.QueryGetProductsWithMatchingSalesDetails(products, sales);

//productManagement.MethodGetProductSalesCombinations(products, sales);
//productManagement.QueryGetProductSalesCombinations(products, sales);

//productManagement.MethodGetProductsWithSalesDetails(products, sales);
//productManagement.QueryGetProductsWithSalesDetails(products, sales);

//productManagement.MethodGetProductSalesReport(products, sales);
//productManagement.QueryGetProductSalesReport(products, sales);

//productManagement.MethodGetProductsSoldMoreThan10Times(products, sales);
//productManagement.QueryGetProductsSoldMoreThan10Times(products, sales);

//productManagement.MethodGetProductNameAndTotalQuantitySold(products, sales);
//productManagement.QueryGetProductNameAndTotalQuantitySold(products, sales);

//productManagement.MethodGetProductNameAndTotalQuantitySoldAlternative(products, sales);
//productManagement.QueryGetProductNameAndTotalQuantitySoldAlternative(products, sales);

//productManagement.MethodGetDistinctProductCategory(products);
//productManagement.QueryGetDistinctProductCategory(products);

//productManagement.MethodGetProductFromDifferentSupplier(products, productsFromDifferentSupplier);
//productManagement.QueryGetProductFromDifferentSupplier(products, productsFromDifferentSupplier);

//productManagement.MethodGetCommonProductFromDifferentSupplier(products, productsFromDifferentSupplier);
//productManagement.QueryGetCommonProductFromDifferentSupplier(products, productsFromDifferentSupplier);

//productManagement.MethodGetFindProductsInOneCollectionButNotInAnother(products, productsFromDifferentSupplier);
//productManagement.QueryGetFindProductsInOneCollectionButNotInAnother(products, productsFromDifferentSupplier);

//productManagement.MethodGetDelayedProductNames(products);
//productManagement.QueryGetDelayedProductNames(products);

//productManagement.MethodGetImmediatelyProductNames(products);
//productManagement.QueryGetImmediatelyProductNames(products);