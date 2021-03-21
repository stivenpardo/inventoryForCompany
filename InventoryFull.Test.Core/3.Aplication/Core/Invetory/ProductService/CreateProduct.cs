using InventoryFull.Aplication.Core.Inventory.Configuration;
using InventoryFull.Aplication.Core.Inventory.Products.Service;
using InventoryFull.Aplication.Dto.Inventory.Products;
using InventoryFull.Domain.Core.Inventory.Product;
using InvetoryFull.Infrastructure.Data.Persistence.Core.Base.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Categories;

namespace InventoryFull.Test.Core._3.Aplication.Core.Invetory.ProductService
{
    public class CreateProduct
    {
        //TODO: Michael, implemeted test for serviceProduct
        [Fact]
        [UnitTest]
        public async Task Create_Produt_Successfull_Test()
        {
            var productEntity = new ProductRequestDto
            {
                ProductId = Guid.NewGuid().ToString(),
                ProductName = "name fake",
                ProductDescription =" description Fake",
                CategoryId = Guid.NewGuid().ToString()
            };

            var productRepoMock = new Mock<IProductRepository>();

            productRepoMock.Setup(x => x.Insert(It.IsAny<ProductEntity>()))
            .Returns(() =>
            {
                return Task.FromResult(new ProductEntity { ProductId = Guid.NewGuid().ToString()});
            });
        }

        [Fact]
        [UnitTest]
        public async Task Create_Produt_failed_on_properties_of_product_null_or_empty_Test()
        {
            var service = new ServiceCollection();
            service.ConfigureInventoryService(new DbSettings());
            var provider = service.BuildServiceProvider();
            var productSvc = provider.GetRequiredService<IProductService>();

            //Assert.ThrowsAsync<>


        }
    }
}
