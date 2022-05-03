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

namespace Prb.Enums.Wpf
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

        private void BtnShowEnumValue_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Season.Autumn.ToString());
        }

        private void BtnShowPrediction_Click(object sender, RoutedEventArgs e)
        {
            WindDirection currentWind = WindDirection.East;
            int currentWindIndex = (int)currentWind;
            string currentWindName = currentWind.ToString();
            lblPrediction.Content = "Huidige wind = " + currentWindName + " (nr. " + currentWindIndex + ")\n";

            WindDirection tomorrowWind = WindDirection.West;
            int tomorrowWindIndex = (int)tomorrowWind;
            string tomorrowWindName = tomorrowWind.ToString();
            lblPrediction.Content += "Wind voor morgen = " + tomorrowWindName + " (nr. " + tomorrowWindIndex + ")\n";

            WindDirection directionTwo = (WindDirection)2;
            lblPrediction.Content += "Wind met index 2 = " + directionTwo.ToString();
        }
    }
}
