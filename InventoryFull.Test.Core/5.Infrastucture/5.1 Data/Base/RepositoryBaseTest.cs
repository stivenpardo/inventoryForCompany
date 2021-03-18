using InventoryFull.Domain.Core.Inventory.Category;
using InvetoryFull.Infrastructure.Data.Persistence.Core.Base;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Categories;

namespace InventoryFull.Test.Core._5.Infrastucture._5._1_Data.Base
{
    public class RepositoryBaseTest
    {
        [Fact]
        [UnitTest]
        public async Task test_insert_call_Add_async_in_UnitOfWork() 
        {
            var entityCategory = new CategoryEntity
            {
                CategoryId = Guid.NewGuid().ToString(),
                CategoryName = "Pollo",     
            };

            var unitOfWorkMock = new Mock<IContextDb>();

            unitOfWorkMock.Setup(m => m.Commit()).Returns(() => 1);
            //TODO: Michael, finish of unittest
            unitOfWorkMock.Setup( m => m.Set<CategoryEntity>()).Returns(() => 
            {
                var context = new ContextDb();
            });

        }
    }
}
