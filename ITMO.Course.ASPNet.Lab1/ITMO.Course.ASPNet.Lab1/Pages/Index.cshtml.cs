using ITMO.Course.ASPNet.Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ITMO.Course.ASPNet.Lab1.Pages
{
    //  Требуется, чтобы страница принимала название продукта и его цену,
    //  а также была реализована проверка вводимой цены
    //  требуемые свойства и передача данных (с проверкой) реализуются в методе OnGet()
    public class IndexModel : PageModel
    {
        // public bool IsCorrect { get; set; } = true;


        //public void OnGet(string name, decimal? price)
        //    {
        //    Product = new Product();
        //    if (price == null || price < 0 || string.IsNullOrEmpty(name))
        //        {
        //            IsCorrect = false;
        //            return;
        //        }
        //    Product.Price = price;
        //    Product.Name = name;

        //    var result = price * (decimal?)0.18;
        //    MessageRezult = $"Для товара {name} с ценой {price} скидка получится {result}";
        //    }
        public void OnGet()
        {
        }
       
    }
}

