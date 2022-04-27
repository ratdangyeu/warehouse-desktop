namespace Warehouse.WarehouseEventAggregator
{
    public class BaseAggregator<T>
    {
        public string Message { get; set; }

        public T Data { get; set; }
    }
}
