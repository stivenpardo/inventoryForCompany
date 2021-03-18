using InventoryFull.Domain.Core.Inventory.Category;
using InvetoryFull.Infrastructure.Data.Persistence.Core.Base;

namespace InvetoryFull.Infrastructure.Data.Persistence.Core.Inventory
{
    internal class CategoryRepository : RepositoryBase<CategoryEntity>, ICategoryRepository
    {
        public CategoryRepository(IContextDb context) : base(context) { }
    }
}
