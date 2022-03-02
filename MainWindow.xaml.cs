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

namespace SkyBoard
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainScreen();
        }

        private void MainScreen()
        {
            _ContentFrame.Navigate(new SmileyPage());
        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonHistory_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonSmiley_Click(object sender, RoutedEventArgs e)
        {
            MainScreen();
        }

        private void ButtonAnimals_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonFlower_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonSettings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonInfo_Click(object sender, RoutedEventArgs e)
        {
            _ContentFrame.Navigate(new InfoPage());
        }
    }
}
