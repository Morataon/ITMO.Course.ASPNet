var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //  ��������� � ��������� �������� �������, ������� ���������� ��� ������ ������������ MVC
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}"); // ��� ����� ��� ����������� �������� �����������

// �� ���� ������ ������:
// app.MapDefaultControllerRoute(); ��� ����� �� ���������, ������� ����������� ������ �������������� ������

app.UseStaticFiles(); // ��� ����������� ����������� ������ (� ����� ������� ��� ������� ������ ����� Site.css)
app.Run();
