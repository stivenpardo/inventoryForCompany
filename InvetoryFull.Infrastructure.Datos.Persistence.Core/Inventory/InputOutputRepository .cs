using InventoryFull.Domain.Core.Inventory.InputOutput;
using InvetoryFull.Infrastructure.Data.Persistence.Core.Base;

namespace InvetoryFull.Infrastructure.Data.Persistence.Core.Inventory
{
    internal class InputOutputRepository : RepositoryBase<InputOutputEntity>, IInputOutputRepository
    {
        public InputOutputRepository(IContextDb context) : base(context) { }
    }
}
