namespace Warehouse.MVVM.Models
{
    public class UnitModel : BaseModel
    {
        public string? UnitName { get; set; }

        public bool Inactive { get; set; }

        public UnitModel()
        {
            Inactive = false;
        }
    }
}
