using MyFinApp.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.Xml.Linq;
using System.Windows.Media.Effects;


namespace MyFinApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Connector connector = new Connector();

            

            List<string> styles = new List<string> { "light", "dark" };
            styleBox.SelectionChanged += ThemeChange;
            styleBox.ItemsSource = styles;
            styleBox.SelectedItem = "dark";

            
        }
        public void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = styleBox.SelectedItem as string;
            var uri = new Uri(style + ".xaml", UriKind.Relative);
            ResourceDictionary resDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resDict);
        }

        private void Category_Click(object sender, RoutedEventArgs e)
        {
            myUCSource.Visibility = Visibility.Collapsed;
            myUCOutcome.Visibility = Visibility.Collapsed;
            myUCIncome.Visibility = Visibility.Collapsed;
            myUCCategory.Visibility = Visibility.Visible;
        }

        private void Source_Click(object sender, RoutedEventArgs e)
        {
            myUCCategory.Visibility = Visibility.Collapsed;
            myUCOutcome.Visibility = Visibility.Collapsed;
            myUCIncome.Visibility = Visibility.Collapsed;
            myUCSource.Visibility = Visibility.Visible;
        }

        private void Outcome_Click(object sender, RoutedEventArgs e)
        {
            myUCCategory.Visibility = Visibility.Collapsed;
            myUCSource.Visibility = Visibility.Collapsed;
            myUCIncome.Visibility = Visibility.Collapsed;
            myUCOutcome.Visibility = Visibility.Visible;
        }

        private void Income_Click(object sender, RoutedEventArgs e)
        {
            myUCCategory.Visibility = Visibility.Collapsed;
            myUCSource.Visibility = Visibility.Collapsed; 
            myUCOutcome.Visibility = Visibility.Collapsed;
            myUCIncome.Visibility = Visibility.Visible;
        }
    }
}
