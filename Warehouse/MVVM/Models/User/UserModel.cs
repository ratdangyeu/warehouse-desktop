using System;

namespace Warehouse.MVVM.Models
{
    public class UserModel : BaseModel
    {
        public string Code { get; set; }

        public string UserName { get; set; }

        public string? LastName { get; set; }

        public string? FirstName { get; set; }

        public string? Phone { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string? ModifiedBy { get; set; }

        public int? StoreId { get; set; }

        public bool Inactive { get; set; }

        public UserModel()
        {
            Inactive = false;
        }
    }
}
