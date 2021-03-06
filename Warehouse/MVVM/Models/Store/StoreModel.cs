namespace Warehouse.MVVM.Models
{
    public class StoreModel : BaseModel
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string? Address { get; set; }

        public string? Description { get; set; }

        public bool Inactive { get; set; }

        public StoreModel()
        {
            Inactive = false;
        }
    }
}
