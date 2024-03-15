using ITMO.Course.ASPNet.MVC.Lab1.Models;
using Microsoft.AspNetCore.Mvc;


namespace ITMO.Course.ASPNet.MVC.Lab1.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private static PersonRepository db = new PersonRepository(); // СОЗДАЁМ СТАТИЧЕСКИЙ ОБЪЕКТ РЕПОЗИТОРИЯ

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "доброе утро" : "добрый день";
            ViewData["Mes"] = "хорошего настроения";
            return View();
        }

        [HttpGet] // это означает, что данный метод может использоваться только для GET запросов
        public ViewResult InputData() // это InputData, который в разметке файла Index является именем ActionLink 
        { 
            return View();
        }

        [HttpPost]
        public ViewResult InputData(Person p)
        {
            db.AddResponse(p); // указывем в этом перегруженном методе код добавления объекта Person в коллекцию db
            return View("Hello", p);
        }

        public ViewResult OutputData()
        {
            ViewBag.Pers = db.GetAllResponses;
            ViewBag.Count = db.NumberOfPerson;
            return View("ListPerson");
        }
        

        //public string Index()
        //{
        //    int hour = DateTime.Now.Hour;
        //    string Greeting = hour < 12 ? "Доброе утро" : "Добрый день"; // Операция x ? y : z вычисляет значение y, если значение x равно true, и значение z, если значение x равно false
        //    return Greeting;
        //}

        //public string Index(string hel)
        //{
        //    // int hour = DateTime.Now.Hour;
        //    // string Greeting = hour < 12 ? "Доброе утро" + ", " + hel : "Добрый день" + ", " + hel; // Операция x ? y : z вычисляет значение y, если значение x равно true, и значение z, если значение x равно false
        //    string Greeting = ModelClass.ModelHello() + ", " + hel;
        //    return Greeting;
        //    // в браузере набираем https://localhost:7292/?name=Anton
        //}
    }
}
