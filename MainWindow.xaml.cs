using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SkyBoard
{
    public partial class MainWindow : Window
    {

        public static MainWindow Instance { get; private set; }

        private String version = "v0.9.7";
        private String darkModeColor = "#1f1d19";
        private String whiteModeColor = "#f0f0f0";

        public MainWindow()
        {
            InitializeComponent();

            MainScreen();
            Instance = this;

            switchDarkMode(Properties.Settings.Default.DarkMode);
        }

        public void switchDarkMode(bool state)
        {
            MainWindow mw = MainWindow.Instance;

            if (state)
            {
                //DarkMode
                mw.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(darkModeColor);
            }
            else
            {
                //WhiteMode
                mw.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(whiteModeColor);
            }
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
            _ContentFrame.Navigate(new SettingsPage(version));
        }
    }
}
