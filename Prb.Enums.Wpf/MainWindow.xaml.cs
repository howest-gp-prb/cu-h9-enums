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

namespace Hfdstk6.Enumeraties01.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        enum Seizoen { Herfst, Winter, Lente, Zomer }
        enum WindRichting { Oost, Zuid, Noord, West };

        private void btnToonEnumWaarde_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Seizoen.Herfst.ToString());
        }

        private void btnToonVoorspelling_Click(object sender, RoutedEventArgs e)
        {
            int huidigeWindNr = (int)WindRichting.Oost;
            string huidigeWind = WindRichting.Oost.ToString();
            lblVoorspelling.Content = "Huidige wind = " + huidigeWind + " (nr. " + huidigeWindNr + ")\n";

            int windVoorMorgenNr = (int)WindRichting.West;
            string windVoorMorgen = WindRichting.West.ToString();
            lblVoorspelling.Content += "Wind voor morgen = " + windVoorMorgen + " (nr. " + windVoorMorgenNr + ")\n";

            WindRichting richtingNul = (WindRichting)2;
            lblVoorspelling.Content += "Wind met index 2 = " + richtingNul.ToString();
        }
    }
}
