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

        private void BtnShowEnumValue_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Season.Autumn.ToString());
        }

        private void BtnShowPrediction_Click(object sender, RoutedEventArgs e)
        {
            int currentWindIndex = (int)WindDirection.East;
            string currentWind = WindDirection.East.ToString();
            lblPrediction.Content = "Huidige wind = " + currentWind + " (nr. " + currentWindIndex + ")\n";

            int tomorrowWindIndex = (int)WindDirection.West;
            string tomorrowWind = WindDirection.West.ToString();
            lblPrediction.Content += "Wind voor morgen = " + tomorrowWind + " (nr. " + tomorrowWindIndex + ")\n";

            WindDirection richtingNul = (WindDirection)2;
            lblPrediction.Content += "Wind met index 2 = " + richtingNul.ToString();
        }
    }

    enum Season { Autumn, Winter, Spring, Summer }
    enum WindDirection { East, South, North, West };
}
