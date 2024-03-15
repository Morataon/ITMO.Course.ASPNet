using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITMO.Course.ASPNet.Lab5_8.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;

namespace ITMO.Course.ASPNet.Lab5_8.Controllers
{
    public class HomeController : Controller
    {
        private CreditContext db = new CreditContext(); // создаём экземпляр контекста данных
        public ActionResult Index()
        {
            //var allCredits = db.Credits.ToList<Credit>(); 
            //ViewBag.Credits = allCredits; 
            GiveCredits();
            return View();
        }

        private void GiveCredits()
        {
            var allCredits = db.Credits.ToList<Credit>(); // обращаемся к контексту и получаем все записи о кредитах
            ViewBag.Credits = allCredits; // создаем свойство Credits в объекте ViewBag и присваиваем ему извлеченный список, ViewBag передается в представление
        }


        [Authorize]
        [HttpGet]
        public ActionResult CreateBid() // GET метод , возвращает соответствующее представление c получением всех записей о кредитах и заявках
        {
            GiveCredits();
            var allBids = db.Bids.ToList<Bid>();
            ViewBag.Bids = allBids;
            return View();
        }


        [HttpPost]
        public string CreateBid(Bid newBid) // принимает переданную ему в запросе POST модель newBid и добавляет ее в базу данных. В конце возвращается строк уведомительного сообщения
        {
            newBid.bidDate = DateTime.Now;
            // Добавляем новую заявку в БД
            db.Bids.Add(newBid);
            // Сохраняем в БД все изменения
            db.SaveChanges();
            return "Спасибо, <b>" + newBid.Name + "</b>, за выбор нашего банка. Ваша заявка будет рассмотрена в течении 10 дней.";        
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            //return View();

            ViewBag.Message = "Your application description page.";
            IList<string> roles = new List<string> { "Роль не определена" };
            ApplicationUserManager userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            ApplicationUser user = userManager.FindByEmail(User.Identity.Name);
            if (user != null)
                roles = userManager.GetRoles(user.Id);
            ViewBag.rol = roles;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult BidSearch(string name) //добавляется  контроллер HomeController и метод действия контроллера, выполняющий асинхронную операцию «Извлечение из БД нужной информации в частичное представление»:
        {
            var allBids = db.Bids.Where(a => a.CreditHead.Contains(name)).ToList();
            if (allBids.Count == 0)
            {
                return Content("Указанный кредит " + name + " не найден");
                //return HttpNotFound();
            }
            return PartialView(allBids);
        }

    }
}