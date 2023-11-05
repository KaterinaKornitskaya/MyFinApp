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
    /// Interaction logic for UserCont1.xaml
    /// </summary>
    public partial class UC_Category : UserControl
    {
        Connector connector;
        public UC_Category()
        {
            InitializeComponent();
            connector = new Connector();
        }

        private void CreateCat_Click(object sender, RoutedEventArgs e)
        {
            connector.AddCategory(txtBoxAddCat.Text);
        }
    }
}
