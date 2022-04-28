namespace Warehouse.MVVM.Models
{
    public class RoleModel : BaseModel
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public bool Inactive { get; set; }

        public RoleModel()
        {
            Inactive = false;
        }
    }
}
