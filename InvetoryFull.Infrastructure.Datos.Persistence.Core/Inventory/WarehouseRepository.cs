using InventoryFull.Domain.Core.Inventory.Warehouse;
using InvetoryFull.Infrastructure.Data.Persistence.Core.Base;

namespace InvetoryFull.Infrastructure.Data.Persistence.Core.Inventory
{
    internal class WarehouseRepository : RepositoryBase<WarehouseEntity>, IWarehouseRepository
    {
        public WarehouseRepository(IContextDb context) : base(context) { }
    }
}
