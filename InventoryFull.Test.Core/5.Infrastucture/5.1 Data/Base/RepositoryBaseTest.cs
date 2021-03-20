using InventoryFull.Domain.Core.Base;
using InventoryFull.Domain.Core.Inventory.Category;
using InvetoryFull.Infrastructure.Data.Persistence.Core.Base;
using InvetoryFull.Infrastructure.Data.Persistence.Core.Base.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Categories;

namespace InventoryFull.Test.Core._5.Infrastucture._5._1_Data.Base
{
    public class RepositoryBaseTest
    {
        [Fact]
        [UnitTest]
        public async Task test_insert_call_Add_async_in_UnitOfWork_Successfull() 
        {
            var entityCategory = new CategoryEntity
            {
                CategoryId = Guid.NewGuid().ToString(),
                CategoryName = "Pollo",     
            };

            var unitOfWorkMock = new Mock<IContextDb>();

            unitOfWorkMock.Setup(m => m.Commit()).Returns(() => 1);

            unitOfWorkMock.Setup( m => m.Set<CategoryEntity>()).Returns(() => 
            {
                var context = new ContextDb();
                context.Category.Add(entityCategory);
                context.SaveChanges();
                return context.Category;
            });
            var services = new ServiceCollection();
            services.AddTransient(_ => unitOfWorkMock.Object);
            services.ConfigureBaseRepository(new DbSettings());
            var provider = services.BuildServiceProvider();
            var categoryRepository = provider.GetRequiredService<ICategoryRepository>();

            var reponse = await categoryRepository.Insert(entityCategory);

            unitOfWorkMock.Verify( x => x.Commit(), Times.Once);
            unitOfWorkMock.Verify( x => x.Set<CategoryEntity>(), Times.Once);
        }
        [Fact]
        [UnitTest]
        public async Task test_Update_call_Add_async_in_UnitOfWork_Successfull() 
        {
            //TODO Michael, solucionar la excepción que se esta generando y entender porque sucede.
            var entityCategory = new CategoryEntity
            {
                CategoryId = Guid.NewGuid().ToString(),
                CategoryName = "Pollo",         
            };

            var repositoryBaseMock = new Mock<IRepositoryBase<CategoryEntity>>();
            //var unitOfWorkMock = new Mock<IContextDb>();

            repositoryBaseMock.Setup(m => m.UnitOfWork.Commit()).Returns(() => 1);

            repositoryBaseMock.Setup( m => m.UnitOfWork.Set<CategoryEntity>()).Returns(() => 
            {
                var context = new ContextDb();
                context.Category.Update(entityCategory);
                context.SaveChanges();
                return context.Category;
            });
            repositoryBaseMock.Setup(m => m.Update(entityCategory)).Returns(() =>
            {
                return true;
            });

            var services = new ServiceCollection();
            services.AddTransient(_ => repositoryBaseMock.Object);
            services.ConfigureBaseRepository(new DbSettings());
            var provider = services.BuildServiceProvider();
            var categoryRepository = provider.GetRequiredService<ICategoryRepository>();

            var reponse = categoryRepository.Update(entityCategory);

            repositoryBaseMock.Verify( x => x.UnitOfWork.Commit(), Times.Once);
            repositoryBaseMock.Verify( x => x.UnitOfWork.Set<CategoryEntity>(), Times.Once);
        }

        [Fact]
        [UnitTest]
        public void test_Delete_call_Add_async_in_UnitOfWork_Successfull() 
        {
            //TODO Michael, solucionar la excepción que se esta generando y entender porque sucede.
            var entityCategory = new CategoryEntity
            {
                CategoryId = Guid.NewGuid().ToString(),
                CategoryName = "Pollo",     
            };

            var unitOfWorkMock = new Mock<IContextDb>();

            unitOfWorkMock.Setup(m => m.Commit()).Returns(() => 1);

            unitOfWorkMock.Setup( m => m.Set<CategoryEntity>()).Returns(() => 
            {
                var context = new ContextDb();
                context.Category.Remove(entityCategory);
                context.SaveChanges();
                return context.Category;
            });

            var services = new ServiceCollection();
            services.AddTransient(_ => unitOfWorkMock.Object);
            services.ConfigureBaseRepository(new DbSettings());
            var provider = services.BuildServiceProvider();
            var categoryRepository = provider.GetRequiredService<ICategoryRepository>();

            var reponse = categoryRepository.Delete(new CategoryEntity { CategoryId="1231231", CategoryName="Ninguni"});

            unitOfWorkMock.Verify( x => x.Commit(), Times.Once);
            unitOfWorkMock.Verify( x => x.Set<CategoryEntity>(), Times.Once);
        }
    }
}
