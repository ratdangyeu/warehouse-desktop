using System;
using System.Collections.Generic;

namespace Warehouse.Repository.Entities
{
    public class UserEntity : BaseEntity
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

        public bool Inactive { get; set; }

        public int? StoreId { get; set; }

        public StoreEntity? Store { get; set; }

        public IList<UserRoleEntity>? UserRoles { get; set; }
    }
}
