using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Collections.Generic;
using NuGet.Configuration;

namespace SkyBoard
{
    public partial class HistoryPage : Page
    {
        public static List<String> smi = new List<string>();

        private int columnCount = 8 - 1; //Spalten
        private int tempC = 0;
        private int rowCount;
        private int tempR = 0;

        public HistoryPage()
        {
            InitializeComponent();

            rowCount = smi.Count / 8;

            Grid myGrid = HistoryGrid;

            myGrid.Height = (590 / 12) * (rowCount + 1);
            myGrid.Width = 360;
            myGrid.Margin = new Thickness(5, 0, 20, 0);
            myGrid.ShowGridLines = false;
            myGrid.HorizontalAlignment = HorizontalAlignment.Center;
            myGrid.VerticalAlignment = VerticalAlignment.Top;

            myGrid.ColumnDefinitions.Add(new ColumnDefinition());
            myGrid.ColumnDefinitions.Add(new ColumnDefinition());
            myGrid.ColumnDefinitions.Add(new ColumnDefinition());
            myGrid.ColumnDefinitions.Add(new ColumnDefinition());
            myGrid.ColumnDefinitions.Add(new ColumnDefinition());
            myGrid.ColumnDefinitions.Add(new ColumnDefinition());
            myGrid.ColumnDefinitions.Add(new ColumnDefinition());
            myGrid.ColumnDefinitions.Add(new ColumnDefinition());

            for (int b = 0; b <= rowCount; b++)
            {
                myGrid.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < smi.Count; i++)
            {
                if (tempC > columnCount)
                {
                    tempC = 0;
                    tempR++;
                    if (tempR > rowCount)
                    {
                        return;
                    }
                }

                Emoji.Wpf.TextBlock txt1 = new Emoji.Wpf.TextBlock();
                txt1.Text = smi[i];
                txt1.FontSize = 35;
                txt1.TextAlignment = TextAlignment.Center;
                txt1.HorizontalAlignment = HorizontalAlignment.Center;
                txt1.MouseLeftButtonDown += ButDeletOnPreviewMouseDown;

                Grid.SetColumnSpan(txt1, 1);
                Grid.SetColumn(txt1, tempC);
                Grid.SetRow(txt1, tempR);

                myGrid.Children.Add(txt1);

                tempC++;
            }
        }

        private async void ButDeletOnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Emoji.Wpf.TextBlock textBlock = (Emoji.Wpf.TextBlock)sender;
            await MainWindow.copyToClipboard(textBlock.Text, false);
        }

        public static void addToHistory(String emoji)
        {
            smi.Add(emoji);
            Properties.Settings.Default.History = smi.ToString();
        }
    }
}
