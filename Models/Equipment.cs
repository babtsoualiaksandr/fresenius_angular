using System.ComponentModel.DataAnnotations;

namespace Fresenius_Angular.Models
{
         public class Equipment
    {
        public int Id { get; set; }
        [Display(Name = "Код Оборудования")]
        public string Code { get; set; }
        [Display(Name = "Наименование ")]
        public string Name { get; set; }
        [Display(Name = "Описание ")]
        public string Description { get; set; }
        [Display(Name = "Путь к Фото ")]
        public string Image { get; set; }
        [Display(Name = "Фото ")]
        public byte[] Image_Byte { get; set; }
        [Display(Name = "Номер регистрационного удостоверения")]
        public string RegNumber { get; set; }
        [Display(Name = "Дата ")]
        public string Date { get; set; }   
    }
}