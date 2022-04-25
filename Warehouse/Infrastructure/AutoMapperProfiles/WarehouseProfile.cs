using AutoMapper;
using Warehouse.MVVM.Models;
using Warehouse.Repository.Entities;

namespace Warehouse.Infrastructure.AutoMapperProfiles
{
    public class WarehouseProfile : Profile
    {
        public WarehouseProfile()
        {
            #region Unit

            #endregion

            #region Vendor

            #endregion

            #region Warehouse
            CreateMap<WarehouseModel, WarehouseEntity>();
            CreateMap<WarehouseEntity, WarehouseModel>();
            #endregion

            #region WarehouseItem

            #endregion

            #region WarehouseItemCategory

            #endregion
        }
    }
}
