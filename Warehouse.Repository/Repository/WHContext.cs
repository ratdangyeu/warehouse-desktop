using Microsoft.EntityFrameworkCore;
using Warehouse.Repository.Entities;

namespace Warehouse.Repository
{
    public class WHContext : DbContext
    {
        #region Fields        
        public DbSet<RoleEntity> Role { get; set; }
        public DbSet<StoreEntity> Store { get; set; }        
        public DbSet<UnitEntity> Unit { get; set; }
        public DbSet<UserEntity> User { get; set; }
        public DbSet<UserRoleEntity> UserRole { get; set; }
        public DbSet<VendorEntity> Vendor { get; set; }
        public DbSet<WarehouseEntity> Warehouse { get; set; }
        public DbSet<WarehouseItemEntity> WarehouseItem { get; set; }
        public DbSet<WarehouseItemCategoryEntity> WarehouseItemCategory { get; set; }        
        #endregion

        #region Ctor
        public WHContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
            Database.Migrate();
        }
        #endregion

        #region Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
        }
        #endregion
    }
}
