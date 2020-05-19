using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ItViteaMorseCode
{
    public class ViewModel : INotifyPropertyChanged
    {
        //private variables for public properties.
        private string _TextBox1, _TextBox2;

        public ViewModel()
        {

        }

        #region public properties
        public string TextBox1
        {
            get { return _TextBox1; }
            set
            {
                _TextBox1 = value;
                OnPropertyChanged();
            }
        }
        public string TextBox2
        {
            get { return _TextBox2; }
            set
            {
                _TextBox2 = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
