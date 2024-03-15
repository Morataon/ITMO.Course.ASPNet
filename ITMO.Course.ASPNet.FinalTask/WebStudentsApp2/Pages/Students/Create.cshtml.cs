﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ITMO.Course.ASPNet.FinalTask.Data;
using ITMO.Course.ASPNet.FinalTask.Models;

namespace ITMO.Course.ASPNet.FinalTask.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly ITMO.Course.ASPNet.FinalTask.Data.ApplicationDbContext _context;

        public CreateModel(ITMO.Course.ASPNet.FinalTask.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Student == null || Student == null)
            {
                return Page();
            }

            _context.Student.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}