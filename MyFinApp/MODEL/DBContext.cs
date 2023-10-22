using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinApp.MODEL
{
    internal class DBContext : DbContext
    {
        public DbSet<Outcome> Outcomes { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<OutcomeCategory> OutcomeCategories { get; set; }
        public DbSet<IncomeSource> IncomeSources { get; set; }
       
        public DBContext() : base("MyFinApp") { }
    }
}
