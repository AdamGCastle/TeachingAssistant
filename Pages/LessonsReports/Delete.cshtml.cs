﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherAdmin.Data;
using TeacherAdmin.Models;

namespace TeacherAdmin.Pages.LessonsReports
{
    public class DeleteModel : PageModel
    {
        private readonly TeacherAdmin.Data.ItalkiDatabaseContext _context;

        public DeleteModel(TeacherAdmin.Data.ItalkiDatabaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public LessonBlog LessonBlog { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LessonBlog = await _context.LessonBlogs.FirstOrDefaultAsync(m => m.ID == id);

            if (LessonBlog == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LessonBlog = await _context.LessonBlogs.FindAsync(id);

            if (LessonBlog != null)
            {
                _context.LessonBlogs.Remove(LessonBlog);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
