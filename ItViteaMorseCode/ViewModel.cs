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
        private bool _TranslateToggle;

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
        public bool TranslateToggle
        {
            get { return _TranslateToggle; }
            set
            {
                _TranslateToggle = value;
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
        public void FromMorse()
        {
            if (!string.IsNullOrEmpty(TextBox1))
                TextBox2 = TLMorse.FromMorse(TextBox1);
        }
        public void Switch()
        {
            string strTemp = TextBox1;
            TextBox1 = TextBox2;
            TextBox2 = strTemp;
        }
        public void Clear()
        {
            TextBox1 = "";
            TextBox2 = "";
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
        private ICommand _FromMorseCmd;
        public ICommand FromMorseCmd
        {
            get
            {
                if (_FromMorseCmd == null)
                {
                    _FromMorseCmd = new RelayCommand(
                        p => FromMorse());
                }
                return _FromMorseCmd;
            }
        }
        private ICommand _SwitchCmd;
        public ICommand SwitchCmd
        {
            get
            {
                if (_SwitchCmd == null)
                {
                    _SwitchCmd = new RelayCommand(
                        p => Switch());
                }
                return _SwitchCmd;
            }
        }
        private ICommand _ClearCmd;
        public ICommand ClearCmd
        {
            get
            {
                if (_ClearCmd == null)
                {
                    _ClearCmd = new RelayCommand(
                        p => Clear());
                }
                return _ClearCmd;
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
