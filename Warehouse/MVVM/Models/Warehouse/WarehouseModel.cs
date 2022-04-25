namespace Warehouse.MVVM.Models
{
    public class WarehouseModel : BaseModel
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public string Path { get; set; }

        public string ParentId { get; set; }

        public bool Inactive { get; set; }

        public WarehouseModel()
        {
            Inactive = false;
        }
    }
}
