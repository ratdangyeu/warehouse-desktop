namespace Warehouse.Repository.Entities
{
    public class UserRoleEntity : BaseEntity
    {
        public int? RoleId { get; set; }

        public int? UserId { get; set; }

        public UserEntity? User { get; set; }

        public RoleEntity? Role { get; set; }
    }
}
