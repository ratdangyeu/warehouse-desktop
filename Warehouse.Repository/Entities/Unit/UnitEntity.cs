using System.Collections.Generic;

namespace Warehouse.Repository.Entities
{
    public class UnitEntity : BaseEntity
    {
        public string? UnitName { get; set; }

        public bool Inactive { get; set; }

        public IList<WarehouseItemEntity>? WarehouseItems { get; set; }
    }
}
