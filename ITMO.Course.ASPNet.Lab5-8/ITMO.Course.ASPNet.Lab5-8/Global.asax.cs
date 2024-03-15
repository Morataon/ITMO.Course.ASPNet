using ITMO.Course.ASPNet.Lab5_8.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ITMO.Course.ASPNet.Lab5_8
{
    public class MvcApplication : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            Database.SetInitializer<ApplicationDbContext>(new AppDbInitializer()); // при запуске приложения в базе данных окажется один пользователь и две роли
            Database.SetInitializer(new CreditsDbInitializer()); //этот метод генерирует БД методом CodeFirst из таблицы в файле CreditsDbInitializer
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
