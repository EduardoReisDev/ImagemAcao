using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;
using ImagemAcao.ViewModel;

namespace ImagemAcao.ViewModel
{
    class ResultadoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string NameProperty)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NameProperty));
            }
        }
    }
}
