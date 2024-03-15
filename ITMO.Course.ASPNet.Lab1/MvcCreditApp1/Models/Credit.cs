using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCreditApp1.Models
{
    public class Credit
    {


        // ID кредита
        [Required]
        [DisplayName("Id")]
        public virtual int CreditId { get; set; }

        // Название
        [Required]
        [DisplayName("Название")]
        public virtual string Head { get; set; }

        // Период, на который выдается кредит
        [Required]
        [DisplayName("Период")]
        public virtual int Period { get; set; }

        // Максимальная сумма кредита
        [Required]
        [DisplayName("Макс. сумма")]
        public virtual int Sum { get; set; }

        // Процентная ставка
        [Required]
        [DisplayName("% ставка")]
        public virtual int Procent { get; set; }

    }
}