namespace Warehouse.Repository.Entities
{
    public class WarehouseItemEntity : BaseEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public int? WarehouseItemCategoryId { get; set; }

        public string? Description { get; set; }

        public int? VendorId { get; set; }

        public string? VendorName { get; set; }

        public string? Country { get; set; }

        public int UnitId { get; set; }

        public bool Inactive { get; set; }

        public UnitEntity Unit { get; set; }

        public VendorEntity? Vendor { get; set; }

        public WarehouseItemCategoryEntity? WarehouseItemCategory { get; set; }
    }
}
