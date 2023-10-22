using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinApp.MODEL
{
    internal class Connector
    {
        public void AddOutcome(string name, string category)
        {
            using (DBContext db = new DBContext())
            {
                Outcome obj = new Outcome
                {
                    Name = name,
                    DateTime = DateTime.Now,
                    Category = db.OutcomeCategories.Where(x => x.Name==category).FirstOrDefault()
                };

                db.Outcomes.Add(obj);
                db.SaveChanges();
            }
        }
    }
}
