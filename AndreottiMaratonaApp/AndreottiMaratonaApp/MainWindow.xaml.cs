using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AndreottiMaratonaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ElencoMaratone Elenco;

        public MainWindow()
        {
            InitializeComponent();
            Elenco = new ElencoMaratone();
            DgElencoMaratone.ItemsSource = Elenco.Elenco;            
        }

        private void BtnSalva_Click(object sender, RoutedEventArgs e)
        {
            string NomeAtleta = TxtNomeAtleta.Text;
            string Società = TxtSocietà.Text;
            string TempoImpiegato = ToString(TxtTempo.Text);
            string Città = TxtCittà.Text;

            var maratona = new Maratona();
            maratona.NomeAtleta = NomeAtleta;
            maratona.Società = Società;
            maratona.TempoImpiegato = TempoImpiegato;
            maratona.Città = Città;
        }
    }
}