using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MyFinApp.MODEL
{
    internal class Connector
    {
        // добавление расхода
        public void AddOutcome(string name, string category, float num)
        {
            using (DBContext db = new DBContext())
            {
                Outcome obj = new Outcome
                {
                    Name = name,
                    DateTime = DateTime.Now,
                    Category = db.OutcomeCategories.Where(x => x.Name==category).FirstOrDefault(),

                    Sum = num
                };
                db.Outcomes.Add(obj);
                db.SaveChanges();
                MessageBox.Show("Расход добавлен.");
            }
        }

        // добавление дохода
        public void AddIncome(string name, string source, float num)
        {
            using (DBContext db = new DBContext())
            {
                Income obj = new Income
                {
                    Name = name,
                    DateTime = DateTime.Now,
                    Source = db.IncomeSources.Where(x => x.Name == source).FirstOrDefault(),
                    Sum = num
                };
                db.Incomes.Add(obj);
                db.SaveChanges();
                MessageBox.Show("Доход добавлен.");
            }
        }

        // добавление категории расхода
        public void AddCategory(string name)
        {
            using(DBContext db = new DBContext())
            {
                bool flag = true;
                foreach (var item in db.OutcomeCategories)
                {
                    if (item.Name.Contains(name))
                    {
                        flag = false;
                        MessageBox.Show("Категория с таким названием уже существует.");
                        break;
                    }
                }
                if (flag)
                {
                    OutcomeCategory obj = new OutcomeCategory();
                    obj.Name = name;
                    db.OutcomeCategories.Add(obj);
                    db.SaveChanges();
                    MessageBox.Show("Категория создана.");
                }
            }
        }

        // добавление источника дохода
        public void AddSource(string name)
        {
            using(DBContext db = new DBContext())
            {
                bool flag = true;
                foreach(IncomeSource item in db.IncomeSources)
                {
                    if (item.Name.Contains(name))
                    {
                        flag = false;
                        MessageBox.Show("Источник с таким названием уже существует.");
                        break;
                    }    
                }
                if(flag)
                {
                    IncomeSource obj = new IncomeSource();
                    obj.Name = name;
                    db.IncomeSources.Add(obj);
                    db.SaveChanges();
                    MessageBox.Show("Источник создан.");
                }
            }
        }

        // лист из источников дохода
        public List<string> SourceList()
        {
            List<string> list;
            using (DBContext db = new DBContext())
            {
                list = new List<string>();
                foreach(var item in db.IncomeSources)
                {
                    list.Add(item.Name);
                }
            }
            return list;
        }
    }
}
