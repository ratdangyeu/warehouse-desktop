using Warehouse.Repository.Enums;

namespace Warehouse.Service
{
    public class WarehouseSearchContext
    {
        public string? Keywords { get; set; }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public int? Status { get; set; }
    }
}
