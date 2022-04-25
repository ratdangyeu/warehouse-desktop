using PagedList.Core;
using System;
using System.Linq;
using Warehouse.Repository;
using Warehouse.Repository.Entities;
using Warehouse.Repository.Enums;

namespace Warehouse.Service
{
    public class WarehouseService : IWarehouseService
    {
        #region Fields
        private readonly WHContext _whContext;
        #endregion

        #region Ctor
        public WarehouseService(WHContext whContext)
        {
            _whContext = whContext;
        }
        #endregion

        #region Methods
        public void InsertAsync(WarehouseEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _whContext.Warehouse.Add(entity);
            _whContext.SaveChanges();
        }

        public void UpdateAsync(WarehouseEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _whContext.Warehouse.Update(entity);
            _whContext.SaveChanges();
        }

        public void DeleteAsync(WarehouseEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _whContext.Warehouse.Remove(entity);
            _whContext.SaveChanges();
        }

        public bool ExistsAsync(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                throw new ArgumentNullException(nameof(code));
            }

            return _whContext.Warehouse.Any(
                x => x.Code != null &&
                x.Code.Equals(code));
        }

        public WarehouseEntity? GetByIdAsync(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var entity = _whContext.Warehouse.Find(id);

            return entity;
        }
        #endregion

        #region List
        public IPagedList<WarehouseEntity> Get(WarehouseSearchContext ctx)
        {
            ctx.Keywords = ctx.Keywords?.Trim();

            var query = from p in _whContext.Warehouse
                        select p;

            if (!string.IsNullOrEmpty(ctx.Keywords))
            {
                query = from p in query
                        where p.Code.Contains(ctx.Keywords) ||
                              p.Name.Contains(ctx.Keywords)
                        select p;
            }

            if (ctx.Status != null)
            {
                if (ctx.Status == (int)ActiveStatus.Active)
                {
                    query = from p in query
                            where !p.Inactive
                            select p;
                }
                if (ctx.Status == (int)ActiveStatus.Inactive)
                {
                    query = from p in query
                            where p.Inactive
                            select p;
                }
            }

            query = from p in query
                    orderby p.Code
                    select p;

            return new PagedList<WarehouseEntity>(query, ctx.PageNumber, ctx.PageSize);
        }
        #endregion
    }
}
