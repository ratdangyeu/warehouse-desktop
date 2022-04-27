using System.Collections.Generic;

namespace Warehouse.Repository.Entities
{
    public class StoreEntity : BaseEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string? Address { get; set; }

        public string? Description { get; set; }

        public bool Inactive { get; set; }

        public IList<UserEntity>? Users { get; set; }
    }
}
