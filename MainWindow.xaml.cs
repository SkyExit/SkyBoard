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

        public static MainWindow Instance { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            MainScreen();
            Instance = this;
        }

        public static async Task copyToClipboard(String emoji, bool addToHistory)
        {
            System.Windows.Clipboard.SetText(emoji);

            MainWindow mainWindow = Instance;
            Button copyButton = mainWindow._CopyButton;
            copyButton.Content = "📋 Copied to Clipboard";
            copyButton.Visibility = Visibility.Visible;
            if(addToHistory) HistoryPage.smi.Add(emoji); //Add to History
            await Task.Delay(1500);
            copyButton.Visibility = Visibility.Hidden;
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
            _ContentFrame.Navigate(new HistoryPage());
        }

        private void ButtonSmiley_Click(object sender, RoutedEventArgs e)
        {
            _ContentFrame.Navigate(new SmileyPage());
        }

        private void ButtonAnimals_Click(object sender, RoutedEventArgs e)
        {
            _ContentFrame.Navigate(new AnimalPage());
        }

        private void ButtonFlower_Click(object sender, RoutedEventArgs e)
        {
            _ContentFrame.Navigate(new FlowerPage());
        }

        private void ButtonHand_Click(object sender, RoutedEventArgs e)
        {
            _ContentFrame.Navigate(new HandPage());
        }

        private void ButtonHuman_Click(object sender, RoutedEventArgs e)
        {
            _ContentFrame.Navigate(new HumanPage());
        }

        private void ButtonSettings_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
