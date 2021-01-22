using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.Unitprice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product {ID = 2, UnitInStock = 3, Unitprice = 500, ProductName = "Masa", CategoryId = 2 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product1);
            
        }
    }
}
