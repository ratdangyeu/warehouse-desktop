using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Warehouse.Core
{
    public class ObservableObject : INotifyPropertyChanged
    {
        #region Fields
        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion

        #region Ctor

        #endregion

        #region Methods
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
