using System;
using System.ComponentModel.DataAnnotations;

namespace Fresenius_Angular.Models
{
   public class IdentityCard
    {
        public int Id { get; set; }
        [Display(Name = "Номер регестрационного удостоверения")]
        public string Number { get; set; }
        [Display(Name = "Дата регистрации")]
        public DateTime DateOfRegistration { get; set; }
        [Display(Name = "Срок действия")]
        public DateTime  Expiration { get; set; }
        [Display(Name = "Заявитель")]
        public string Applicant { get; set; }
        [Display(Name = "Предназначение :))")]
        public string Purpose { get; set; }
    }
}