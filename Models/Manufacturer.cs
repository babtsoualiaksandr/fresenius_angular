using System.ComponentModel.DataAnnotations;

namespace Fresenius_Angular.Models
{
 public class Manufacturer
    {
        public int Id { get; set; }
        [Display(Name = "Код производителя")]
        public string  Code { get; set; }
        [Display(Name = "Наименование полное")]
        public string NameFull { get; set; }
        [Display(Name = "Наименование краткое")]
        public string NameShort { get; set; }
        [Display(Name = "Адрес отправления")]
        public string AdressOfDeparture { get; set; }
        [Display(Name = "Лого")]
        public string Logo { get; set; } 
        [Display(Name = "Фото Лого")]
        public byte[] LogoFoto { get; set; } 
    }
}