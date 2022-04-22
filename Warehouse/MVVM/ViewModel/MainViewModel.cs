using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Core;

namespace Warehouse.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        #region Fields
        private object _currentView;

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

        #endregion

        #region Methods
        private void AddEvents()
        {
            
        }
        #endregion
    }
}
