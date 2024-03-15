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
    public class AssessmentsModel : PageModel
    {
        private readonly ITMO.Course.ASPNet.FinalTask.Data.ApplicationDbContext _context;

        public AssessmentsModel(ITMO.Course.ASPNet.FinalTask.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public int StudentId { get; set; } = default!;
        public Student Student { get; set; } = default!;
       
        [BindProperty] 
        public Assessment Assessment { get; set; } = default!;
        
        public IList<Assessment> Assessments { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var student = await _context.Student.Include(s=> s.Assessments).FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            else
            {

                Student = student;
                StudentId= student.Id;
                Assessments = student.Assessments;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Student == null || Assessment == null)
            {
                return Page();
            }

//            _context..Add();
            Assessment.ReleaseDate= DateTime.Now;
            Assessment.StudentId = StudentId;
            _context.Assessment.Add(Assessment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Assessments" , new {id = StudentId });
        }
    }
}
