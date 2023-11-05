using MyFinApp.MODEL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for UC_Outcome.xaml
    /// </summary>
    public partial class UC_Outcome : UserControl
    {
        Connector conn;
        public UC_Outcome()
        {
            InitializeComponent();
            conn = new Connector();
            List<string> list = new List<string>();
            using (DBContext db = new DBContext())
            {
                foreach (OutcomeCategory item in db.OutcomeCategories)
                {
                    comboBoxOutcome.Items.Add(item.Name);
                    list.Add(item.Name);
                }
            }
            foreach(var i in list)
            {
                stL.Children.Add(new Label { Content =  i });
            }
            

           
        }

        private void btnAddOutcome_Click(object sender, RoutedEventArgs e)
        {
            string cat = comboBoxOutcome.SelectedItem.ToString();
            try
            {
                conn.AddOutcome(txtBoxOutcomeName.Text, cat, float.Parse(txtBoxOutcomesum.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               
           
            
        }
    }
}
