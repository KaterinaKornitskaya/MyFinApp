using MyFinApp.MODEL;
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

namespace MyFinApp.MyUserControls
{
    /// <summary>
    /// Interaction logic for UC_Source.xaml
    /// </summary>
    public partial class UC_Source : UserControl
    {
        Connector conn;
        public UC_Source()
        {
            InitializeComponent();
            conn = new Connector();
        }

        private void CreateSource_Click(object sender, RoutedEventArgs e)
        {

            conn.AddSource(txtBoxAddSource.Text);
        }
    }
}
