using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SkyBoard
{
    public partial class SettingsPage : Page
    {
        public static bool darkMode = Properties.Settings.Default.DarkMode;

        public static SettingsPage SettingsInstance { get; private set; }

        public SettingsPage(String version)
        {
            InitializeComponent();

            SettingsInstance = this;

            SettingsVersion.Text = version;
            
            DarkModeCheckBox.IsChecked = Properties.Settings.Default.DarkMode;
            switchColor(Properties.Settings.Default.DarkMode);
        }

        private void DarkMode_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = MainWindow.Instance;
            if(darkMode)
            {
                Properties.Settings.Default.DarkMode = false;
                darkMode = false;
                Properties.Settings.Default.Save();
                mw.switchDarkMode(false);
                switchColor(false);
            } else
            {
                Properties.Settings.Default.DarkMode = true;
                darkMode = true;
                Properties.Settings.Default.Save();
                mw.switchDarkMode(true);
                switchColor(true);
            }
        }

        private void switchColor(bool state)
        {
            if(state)
            {
                //DarkMode
                SettingsVersion.Foreground = new SolidColorBrush(Colors.White);
                DarkModeCheckBox.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {
                //WhiteMode
                SettingsVersion.Foreground = new SolidColorBrush(Colors.Black);
                DarkModeCheckBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }
    }
}
