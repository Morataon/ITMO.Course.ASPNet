using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCreditApp1.Models
{

    public class Bid
    {
        // ID заявки
        [Required]
        public virtual int BidId { get; set; }

        // Имя заявителя
        [Required]
        [DisplayName("Имя заявителя")]
        public virtual string Name { get; set; }

        [Required]
        [DisplayName("Название кредита")]
        // Название кредита
        public virtual string CreditHead { get; set; }

        // Дата подачи заявки
        [Required]
        [DisplayName("Дата подачи заявки")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public virtual DateTime bidDate { get; set; }
    }
}