using System;//
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
        private string _MsgErro;
        public string MsgErro { get { return _MsgErro; } set { _MsgErro = value; OnPropertyChanged("MsgErro"); } }

        public InicioViewModel()
        {
            IniciarCommand = new Command(IniciarJogo);
            Jogo = new Jogo();
            Jogo.Grupo1 = new Grupo();
            Jogo.Grupo2 = new Grupo();

            Jogo.TempoPalavra = 60;
            Jogo.Rodadas = 5;

        }

        public void IniciarJogo()
        {
            string error = "";

            if (Jogo.TempoPalavra < 10)
            {
                error += "O tempo mínimo por rodada é 10 segundos.";
            }

            if(Jogo.Rodadas <= 0)
            {
                error += "\nO número mínimo de rodadas é 1.";
            }

            if(error.Length > 0)
            {
                MsgErro = error;
            }

            else
            {
                Armazenamento.Armazenamento.Jogo = this.Jogo;
                Armazenamento.Armazenamento.RodadaAtual = 1;
                App.Current.MainPage = new View.Jogo(Jogo.Grupo1);
            }
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
