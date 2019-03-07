using System.ComponentModel.DataAnnotations;

namespace Fresenius_Angular.Models
{
    public class SparePart
    {
        public int Id { get; set; }
        [Display(Name = "Номер запчасти")]
        public string Number { get; set; }
        [Display(Name = "Наименование En.")]
        public string NameEn { get; set; }
        [Display(Name = "Наименование Rus. ")]
        public string NameRus { get; set; }        
        public int? EquipmentId { get; set; }

        [Display(Name = "Краткое_Описание_Запчасти")]
        public string Description { get; set; }
        public int? ManufacturerId { get; set; }
  
        public int? CountryId { get; set; }
        [Display(Name = "Фото ")]
        public string Image { get; set; }
        [Display(Name = "Фото ")]
        public byte[] Image_Byte { get; set; }
        public int[]   InvoiceID { get; set; }
    }
}