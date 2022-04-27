using Prism.Events;
using System.Windows;
using System.Windows.Input;
using Warehouse.MVVM.ViewModel;

namespace Warehouse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Fields
        private readonly MainViewModel _mainViewModel;
        private readonly IEventAggregator _eventAggregator;
        #endregion

        #region Ctor
        public MainWindow(
            IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _mainViewModel = new MainViewModel(_eventAggregator);
            InitializeComponent();
            DataContext = _mainViewModel;
        }
        #endregion

        #region Methods
        private void BtnMinimize(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnExit(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
