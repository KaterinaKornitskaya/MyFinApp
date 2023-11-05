using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinApp.MODEL
{
    // класс Доход
    internal class Income
    {
        public int Id { get; set; }  // Id дохода
                                     // атрибуты для Имени дохода:
        [Required]                   // имя не может быть пустым (not null)
        [StringLength(50)]           // макс.длина имени 50 символов
        public string Name { get; set; }  // имя дохода
        public DateTime DateTime { get; set; }  // дата дохода

        public float Sum { get; set; }  // сумма дохода

        // реализация связи 1:N - один источник - много доходов
        // к доходу соотносится один источник - создаем свойство Источник
        public virtual IncomeSource Source { get; set; }

    }
}
