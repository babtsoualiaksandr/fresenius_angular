using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fresenius_Angular.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        [Display(Name = "Номер")]
        public string Num { get; set; }
        [Display(Name = "Дата")]
        public string Date { get; set; }
        [Display(Name = "Отправитель")]
        public string Sender { get; set; }
        [Display(Name = "Получатель")]
        public string Recipient { get; set; }


        public int [] Spareparts { get; set; }
    }
}
