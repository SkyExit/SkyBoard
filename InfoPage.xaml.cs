using DynamicData;
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
    /// <summary>
    /// Interaktionslogik für InfoPage.xaml
    /// </summary>
    public partial class InfoPage : Page
    {

        public static List<String> versionList = new List<String>();
        public static List<String> descriptionList = new List<String>();

        public InfoPage()
        {
            InitializeComponent();

            buildList();

            Grid infoGrid = InfoGrid;

            for (int i = 0; i < versionList.Count; i++)
            {

                TextBlock txt1 = new TextBlock();
                txt1.Text = "  " + versionList[i];
                txt1.FontSize = 32;
                txt1.Foreground = new SolidColorBrush(Colors.White);
                txt1.TextAlignment = TextAlignment.Center;
                txt1.HorizontalAlignment = HorizontalAlignment.Left;
                Grid.SetColumnSpan(txt1, 1);
                Grid.SetColumn(txt1, 0);
                Grid.SetRow(txt1, i);

                TextBlock txt2 = new TextBlock();
                txt2.Text = descriptionList[i];
                txt2.FontSize = 13;
                txt2.TextAlignment = TextAlignment.Center;
                txt2.HorizontalAlignment = HorizontalAlignment.Left;
                txt2.Foreground = new SolidColorBrush(Colors.White);
                Grid.SetColumnSpan(txt2, 1);
                Grid.SetColumn(txt2, 1);
                Grid.SetRow(txt2, i);

                infoGrid.Children.Add(txt1);
                infoGrid.Children.Add(txt2);
            }
        }

        private void buildList()
        {
            versionList.Add("v1.5.9");
            descriptionList.Add("Played a bit with the displaying and \nimplemented the first coloed emojis");

            versionList.Add("v1.3.6");
            descriptionList.Add("Created simple emoji displaying in table");

            versionList.Add("v1.2.1");
            descriptionList.Add("Added project to GitHub");

            versionList.Add("v1.2.0");
            descriptionList.Add("Added this information page");

            versionList.Add("v1.1.0");
            descriptionList.Add("Added navigation buttons");

            versionList.Add("v1.0.0");
            descriptionList.Add("Created the project");
        }
    }
}
