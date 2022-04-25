namespace Warehouse.MVVM.Models
{
    public class WarehouseItemModel : BaseModel
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

        public WarehouseItemModel()
        {
            Inactive = false;
        }
    }
}
