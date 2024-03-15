using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITMO.Course.ASPNet.Lab5_8.Models
{

        public class Credit
        {
            // ID кредита
            [DisplayName("ID")]
            [Required]
            public virtual int CreditId { get; set; }
            // Название
            [DisplayName("Название кредита")]
            [Required]
            public virtual string Head { get; set; }
            // Период, на который выдается кредит
            [DisplayName("Период кредита")]
            [Required]
            public virtual int Period { get; set; }
            // Максимальная сумма кредита
            [DisplayName("Сумма кредита")]
            [Required]
            public virtual int Sum { get; set; }
            // Процентная ставка
            [DisplayName("Процент")]
            [Required]
            public virtual int Procent { get; set; }
        }
}