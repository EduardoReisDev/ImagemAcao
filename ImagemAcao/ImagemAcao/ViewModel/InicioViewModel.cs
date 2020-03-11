using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using ImagemAcao.Model;

namespace ImagemAcao.ViewModel
{
    public class InicioViewModel : INotifyPropertyChanged
    {
        public Jogo Jogo { get; set; }
        public Command IniciarCommand { get; set; }   

        public InicioViewModel()
        {
            IniciarCommand = new Command(IniciarJogo);
        }

        public void IniciarJogo()
        {
            App.Current.MainPage = new View.Jogo();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged (string NameProperty)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NameProperty));
            }
        }
    }
}
