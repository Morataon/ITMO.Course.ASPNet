using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ITMO.Course.ASPNet.FinalTask.Models;

namespace ITMO.Course.ASPNet.FinalTask.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var st1 = new Student()
            {
                Id = 1,
                LastName = "Морозова",
                FirstName = "Александра",
                MiddleName = "Петровна",
                Email = "morozova@mail.ru"
            };

            var st2 = new Student()
            {
                Id = 2,
                LastName = "Каштанов",
                FirstName = "Вениамин",
                MiddleName = "Григорьевич",
                Email = "kashtanov@mail.ru"
            };

            var st3 = new Student()
            {
                Id = 3,
                LastName = "Моргунов",
                FirstName = "Антон",
                MiddleName = "Маратович",
                Email = "morgan@gmail.com"
            };

            var asmnt1 = new Assessment() { Id = 1, StudentId = 1, ReleaseDate = DateTime.Today.AddDays(-61), Value = 5 };
            var asmnt2 = new Assessment() { Id = 2, StudentId = 1, ReleaseDate = DateTime.Today.AddDays(-48), Value = 4 };
            var asmnt3 = new Assessment() { Id = 3, StudentId = 2, ReleaseDate = DateTime.Today.AddDays(-47), Value = 5 };
            var asmnt4 = new Assessment() { Id = 4, StudentId = 2, ReleaseDate = DateTime.Today.AddDays(-52), Value = 4 };
            var asmnt5 = new Assessment() { Id = 5, StudentId = 2, ReleaseDate = DateTime.Today.AddDays(-49), Value = 5 };
            var asmnt6 = new Assessment() { Id = 6, StudentId = 3, ReleaseDate = DateTime.Today.AddDays(-56), Value = 5 };
            var asmnt7 = new Assessment() { Id = 7, StudentId = 3, ReleaseDate = DateTime.Today.AddDays(-57), Value = 4 };
            var asmnt8 = new Assessment() { Id = 8, StudentId = 3, ReleaseDate = DateTime.Today.AddDays(-52), Value = 4 };


            modelBuilder.Entity<Student>().HasData(st1, st2, st3);
            modelBuilder.Entity<Assessment>().HasData(asmnt1, asmnt2, asmnt3, asmnt4, asmnt5, asmnt6, asmnt7, asmnt8);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ITMO.Course.ASPNet.FinalTask.Models.Student>? Student { get; set; }
        public DbSet<ITMO.Course.ASPNet.FinalTask.Models.Assessment> Assessment { get; set; } = default!;
    }
}