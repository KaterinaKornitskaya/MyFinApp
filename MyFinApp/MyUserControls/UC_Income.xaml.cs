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
    /// Interaction logic for UC_Income.xaml
    /// </summary>
    public partial class UC_Income : UserControl
    {
        Connector conn;
        public UC_Income()
        {
            InitializeComponent();
            conn = new Connector();
            RestartSource();
            
        }

        private void btnAddIncome_Click(object sender, RoutedEventArgs e)
        {
            string cat = comboBoxIncome.SelectedItem.ToString();
            MessageBox.Show(cat);
            conn.AddIncome(txtBoxIncomeName.Text, cat, float.Parse(txtBoxIncomeSum.Text));
        }

        private void restartSource_Click(object sender, RoutedEventArgs e)
        {
            RestartSource();
        }
        private void comboBoxIncome_DropDownOpened(object sender, EventArgs e)
        {
            RestartSource();
        }
        public void RestartSource()
        {
            comboBoxIncome.Items.Clear();
            stL.Children.Clear();
            List<string> li = conn.SourceList();
            foreach (string s in li)
            {
                comboBoxIncome.Items.Add(s);
            }
            foreach (var i in li)
            {
                stL.Children.Add(new Label { Content =  i });
            }
        }
    }
}
