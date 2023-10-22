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
            connector.AddOutcome("out5", "pro4");

            //using (DBContext db = new DBContext())
            //{
            //    //IncomeSource income = new IncomeSource { Name = "name3" };
            //    //db.IncomeSources.Add(income);
            //    ////db.SaveChanges();


            //    ////db.SaveChanges();


            //    Outcome out3 = new Outcome
            //    {
            //        Name = "out5",
            //        DateTime = DateTime.Now,
            //        Category = db.OutcomeCategories.Where(x => x.Name=="pro2").FirstOrDefault()
            //    };

            //    db.Outcomes.Add(out3);
            //    db.SaveChanges();





            //}

        }
    }
}
