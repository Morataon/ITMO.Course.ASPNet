using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ITMO.Course.ASPNet.FinalTask.Data;
using ITMO.Course.ASPNet.FinalTask.Models;

namespace ITMO.Course.ASPNet.FinalTask.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly ITMO.Course.ASPNet.FinalTask.Data.ApplicationDbContext _context;

        public IndexModel(ITMO.Course.ASPNet.FinalTask.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Student.ToListAsync();
            }
        }
    }
}
