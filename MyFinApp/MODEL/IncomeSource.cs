using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinApp.MODEL
{
    // класс Источник дохода
    internal class IncomeSource
    {
        public int Id { get; set; }  // Id Источника
                                     // атрибуты для имени источника:
        [Required]                   // not null
        [StringLength(50)]           // длина имени - не больше 50 символов
        public string Name { get; set; }  // имя Источника

        // реализация связи 1:N - один источник - много доходов
        // объявляем коллекцию доходов
        public virtual ICollection<Income> Incomes { get; set; }

        
        
        
        // в конструкторе выделяем место для коллекции доходов
        public IncomeSource()
        {
            Incomes = new List<Income>();
        }
       
    }
}
