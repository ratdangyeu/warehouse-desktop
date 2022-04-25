namespace Warehouse.MVVM.Models
{
    public class BaseSearchModel
    {
        public string? Keywords { get; set; }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public int? Status { get; set; }
    }
}
