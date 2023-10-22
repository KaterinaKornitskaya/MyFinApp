using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinApp.MODEL
{
    // класс Затрата
    internal class Outcome
    {
        public int Id { get; set; }  // Id затраты
                                     // атрибуты для Имени затраты:
        [Required]                   // имя не может быть пустым (not null)
        [StringLength(50)]           // макс.длина имени 50 символов
        public string Name { get; set; }  // имя затраты
        
        public DateTime DateTime { get; set; }  // дата затраты

        // реализация связи 1:N - одна категория - много затрат
        // к затрате соотносится одна категория - создаем свойство Категория
        public virtual OutcomeCategory Category { get; set; }
       
    }
}
