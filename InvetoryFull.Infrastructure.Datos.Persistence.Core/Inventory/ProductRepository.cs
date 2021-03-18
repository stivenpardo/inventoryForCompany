using InventoryFull.Domain.Core.Inventory.Product;
using InvetoryFull.Infrastructure.Data.Persistence.Core.Base;

namespace InvetoryFull.Infrastructure.Data.Persistence.Core.Inventory
{
    internal class ProductRepository : RepositoryBase<ProductEntity>, IProductRepository
    {
        public ProductRepository(IContextDb context) : base(context) { }
    }
}
