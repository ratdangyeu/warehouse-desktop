using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Warehouse.Repository
{
    public class WHContextFactory : IDesignTimeDbContextFactory<WHContext>
    {
        #region Fields

        #endregion

        #region Ctor
        public WHContextFactory()
        {

        }
        #endregion

        #region Methods
        public WHContext CreateDbContext(string[] args)
        {
            var dbContextBuilder = new DbContextOptionsBuilder();

            var dbPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\NaBi\\Warehouse";
            if (!Directory.Exists(dbPath))
            {
                Directory.CreateDirectory(dbPath);
            }
            dbContextBuilder.UseSqlite("Data Source = " + dbPath + "\\Warehouse.db");

            return new WHContext(dbContextBuilder.Options);
        }
        #endregion
    }
}
