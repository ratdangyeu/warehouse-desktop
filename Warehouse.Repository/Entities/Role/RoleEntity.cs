using System.Collections.Generic;

namespace Warehouse.Repository.Entities
{
    public class RoleEntity : BaseEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public bool Inactive { get; set; }

        public IList<UserRoleEntity>? UserRoles { get; set; }
    }
}
