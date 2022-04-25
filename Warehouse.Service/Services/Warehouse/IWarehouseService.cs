using PagedList.Core;
using Warehouse.Repository.Entities;

namespace Warehouse.Service
{
    public interface IWarehouseService
    {
        void InsertAsync(WarehouseEntity entity);

        void UpdateAsync(WarehouseEntity entity);

        void DeleteAsync(WarehouseEntity entity);

        bool ExistsAsync(string code);

        WarehouseEntity? GetByIdAsync(int id);

        IPagedList<WarehouseEntity> Get(WarehouseSearchContext ctx);
    }
}
