using AutoMapper;
using System.Windows;
using System.Windows.Input;

namespace Warehouse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Fields

        #endregion

        #region Ctor
        public MainWindow(IMapper mapper)
        {            
            InitializeComponent();
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
