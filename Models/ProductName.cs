using System.ComponentModel.DataAnnotations;

namespace Fresenius_Angular.Models
{
    public class ProductName
    {
        public int Id { get; set; }
        [Display(Name = "Номер")]
        public int Item { get; set; }
        [Display(Name = "Наименование")]
        public string  Designation { get; set; }
        [Display(Name = "Код, артикул, ГОСТ, ТУ, НТД, модель")]
        public string  Gost { get; set; }
        [Display(Name = "Производитель")]
        public string Manufacturer { get; set; }
        [Display(Name = "Рег. номер товара")]
        public string RegItem { get; set; }
        [Display(Name = "Тип")]
        public string  Type { get; set; }

    }
}