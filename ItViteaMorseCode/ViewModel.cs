using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ItViteaMorseCode
{
    public class ViewModel : INotifyPropertyChanged
    {
        //private variables for public properties.
        private string _TextBox1, _TextBox2;

        //public variables.
        public TranslateMorse TLMorse;

        public ViewModel()
        {
            TLMorse = new TranslateMorse();
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

        #region methods
        public void ToMorse()
        { 
            if (!string.IsNullOrEmpty(TextBox1))
            TextBox2 = TLMorse.ToMorse(TextBox1);
        }
        #endregion

        #region ICommands
        private ICommand _ToMorseCmd;
        public ICommand ToMorseCmd
        {
            get
            {
                if (_ToMorseCmd == null)
                {
                    _ToMorseCmd = new RelayCommand(
                        p => ToMorse());
                }
                return _ToMorseCmd;
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
