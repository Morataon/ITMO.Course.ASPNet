var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //  добавляет в коллекцию сервисов сервисы, которые необходимы для работы контроллеров MVC
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}"); // это метод для регистрации маршрута контроллера

// но есть другой способ:
// app.MapDefaultControllerRoute(); это метод по умолчанию, который применяется вместо вышеуказанного метода

app.UseStaticFiles(); // для подключения статических файлов (в нашем проекте это таблица стилей файла Site.css)
app.Run();
