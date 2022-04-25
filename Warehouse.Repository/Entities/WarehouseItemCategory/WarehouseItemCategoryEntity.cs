using System.Collections.Generic;

namespace Warehouse.Repository.Entities
{
    public class WarehouseItemCategoryEntity : BaseEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string? ParentId { get; set; }

        public string? Path { get; set; }

        public string? Description { get; set; }

        public bool Inactive { get; set; }

        public IList<WarehouseItemEntity>? WarehouseItems { get; set; }
    }
}
