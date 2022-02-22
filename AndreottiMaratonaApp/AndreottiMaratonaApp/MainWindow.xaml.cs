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
            DgrElencoMaratone.ItemsSource = Elenco.Elenco;            
        }

        private void BtnLeggiDaFile_Click(object sender, RoutedEventArgs e)
        {
            Elenco.LeggiDaFile();
            DgrElencoMaratone.Items.Refresh();
        }

        private void BtnCerca_Click(object sender, RoutedEventArgs e)
        {
            string nome = TxtNomeAtleta.Text;
            string città = TxtCittà.Text;

            int tempoImpiegato = Elenco.CercaNomeCittà(nome, città);
            LblTempo.Content = tempoImpiegato.ToString();

        }
    }
}