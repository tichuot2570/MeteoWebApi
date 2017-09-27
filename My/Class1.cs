using DemoWebApi.Models;
using System.Collections.Generic;
using Xunit;
using System.Web;
using DemoWebApi.Controllers;
/*
namespace MyFirstUnitTest
{
    public class UnitTesting
    {

        private List<Product> GetTestProducts()
        {
            var testProducts = new List<Product>();
            testProducts.Add(new Product { Id = 1, Name = "Ketchup", Category = "Groceries", Price = 1 });
            testProducts.Add(new Product { Id = 2, Name = "Makkara", Category = "Groceries", Price = 3.75M });
            testProducts.Add(new Product { Id = 3, Name = "Mommi", Category = "Groceries", Price = 16.99M });
            testProducts.Add(new Product { Id = 4, Name = "Paperi", Category = "Groceries", Price = 11.00M });

            return testProducts;
        }
        [Fact]
        public void GetAllProducts_ShouldReturnAllProducts()
        {
            var testProducts = GetTestProducts();
            var controller = new ProductsController(testProducts);
            var result = controller.GetAllProducts() as List<Product>;
            Assert.Equal(testProducts.Count, result.Count);
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}


    */