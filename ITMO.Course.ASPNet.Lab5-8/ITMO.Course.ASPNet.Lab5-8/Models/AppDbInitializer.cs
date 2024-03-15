using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ITMO.Course.ASPNet.Lab5_8.Models
{
    public class AppDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            // создаём объекты для управления пользователями и ролями
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context)); 
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            // создаём 2 роли
            var role1 = new IdentityRole { Name = "armin" }; 
            var role2 = new IdentityRole { Name = "user" };

            // добавляем роли в БД
            roleManager.Create(role1);
            roleManager.Create(role2);

            // создаём пользователя Админ и указваем ему параметры
            var armin = new ApplicationUser {Email = "armin@mail.ru", UserName = "armin@mail.ru" };
            string password = "qwerty_311";
            var result = userManager.Create(armin, password);
        }
    }
}