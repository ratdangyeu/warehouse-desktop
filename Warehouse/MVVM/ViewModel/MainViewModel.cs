using Prism.Events;
using Warehouse.Core;
using Warehouse.MVVM.Models;
using Warehouse.WarehouseEventAggregator;

namespace Warehouse.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        #region Fields
        private object _currentView;
        private readonly IEventAggregator _eventAggregator;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public HomeViewModel HomeVM { get; set; }
        #endregion

        #region Ctor
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();

            CurrentView = HomeVM;
            AddEvents();
        }

        public MainViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            AddEvents();
            HomeVM = new HomeViewModel(_eventAggregator);

            CurrentView = HomeVM;            
        }

        #endregion

        #region Methods
        private void AddEvents()
        {
            _eventAggregator.GetEvent<PubSubEvent<BaseAggregator<WarehouseModel>>>().Subscribe(GetMessageEvent);
        }
        #endregion

        #region Events
        private void GetMessageEvent(BaseAggregator<WarehouseModel> obj)
        {
            var msg = obj.Message;
            var wh = obj.Data;
        }
        #endregion
    }
}
