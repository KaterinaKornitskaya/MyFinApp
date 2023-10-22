using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyFinApp.MODEL
{
    // класс Категория затрат
    internal class OutcomeCategory
    {
        public int Id { get; set; }       // Id категории затраты
                                          // атрибуты для Имени затраты:
        [Required]                        // not null
        [StringLength(50)]                // макс.дина строки 50 символов
        public string Name { get; set; }  // имя категории затраты

        // реализация связи 1:N - одна категория - много затрат
        // создаем коллекию затрат
        public virtual ICollection<Outcome> Outcomes { get; set; }

        // конструктор класса Категория затраты
        public OutcomeCategory()
        {
            // в конструкторе выделяем память для коллекции затрат
            Outcomes = new List<Outcome>();
        }
    }
}
