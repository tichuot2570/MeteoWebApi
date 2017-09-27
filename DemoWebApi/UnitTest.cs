using DemoWebApi.Models;
using System.Collections.Generic;
using Xunit;
using System.Web.Http.Results;
using DemoWebApi.Controllers;


namespace DemoWebApi
{
    public class UnitTest
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
        public void GetProduct_ShouldReturnCorrectProduct()
        {
            var testProducts = GetTestProducts();
            var controller = new ProductsController(testProducts);
            var result = controller.GetProduct(3) as OkNegotiatedContentResult<Product>;
            Assert.NotNull(true);
            Assert.Equal(3, result.Content.Id);
        }
        [Fact]
        public void GetProduct_ShouldNotFindProduct()
        {
            var controller = new ProductsController(GetTestProducts());

            var result = controller.GetProduct(999) as OkNegotiatedContentResult<NotFoundResult>;
            Assert.Null(result);
        }
        //Post product
        [Fact]
        public void PostProduct_ShouldReturnOk()
        {
            var controller = new ProductsController(GetTestProducts());
            var result = controller.PostProduct(new Product { Id = 6, Name = "Tomato", Category = "Groceries", Price = 15 })
                as OkNegotiatedContentResult<Product>;
            Assert.Equal(6, result.Content.Id);
        }
        [Fact]
        public void PutProduct_ShouldReturnOk()
        {
            var testProducts = GetTestProducts();
            var controller = new ProductsController(GetTestProducts());
            var result = controller.PutProduct(new Product { Id = 2, Name = "Maccaroni", Category = "Groceries", Price = 15 })
                as OkNegotiatedContentResult<Product>;
            Assert.Equal("Maccaroni", result.Content.Name);
        }
        [Fact]
        public void DeleteProduct_ShouldReturnOk()
        {
            var testProducts = GetTestProducts();
            
            var controller = new ProductsController(testProducts);   
            var result = controller.DeleteProduct(3)
                as OkNegotiatedContentResult<Product>;
            Assert.Equal(3, testProducts.Count);

        }
    }
}