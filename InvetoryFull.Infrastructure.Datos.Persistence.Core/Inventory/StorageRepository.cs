using InventoryFull.Domain.Core.Inventory.Storage;
using InvetoryFull.Infrastructure.Data.Persistence.Core.Base;

namespace InvetoryFull.Infrastructure.Data.Persistence.Core.Inventory
{
    internal class StorageRepository : RepositoryBase<StorageEntity>, IStorageRepository
    {
        public StorageRepository(IContextDb context) : base(context) { }
    }
}
