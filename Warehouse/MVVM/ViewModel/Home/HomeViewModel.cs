using Prism.Events;
using Warehouse.Core;
using Warehouse.MVVM.Models;
using Warehouse.WarehouseEventAggregator;

namespace Warehouse.MVVM.ViewModel
{
    public class HomeViewModel : ObservableObject
    {
        #region Fields
        private readonly IEventAggregator _eventAggregator;
        #endregion

        #region Ctor
        public HomeViewModel()
        {
        }

        public HomeViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            AddEvents();
            AddPublishes();
        }
        #endregion

        #region Methods
        private void AddPublishes()
        {
            _eventAggregator.GetEvent<PubSubEvent<BaseAggregator<WarehouseModel>>>().Publish(new BaseAggregator<WarehouseModel>
            {
                Message = "Hello, It's me!",
                Data = new WarehouseModel
                {
                    Code = "WH001",
                    Name = "Kho Hòa Lạc",
                    Inactive = false
                }
            });
        }

        private void AddEvents()
        {
            
        }
        #endregion
    }
}
