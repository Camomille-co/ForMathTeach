﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using jhyf.Data;
using jhyf.Data.Identity;
using Microsoft.AspNetCore.Authorization;

namespace jhyf.Pages.Homeworks
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly jhyf.Data.ApplicationDbContext _context;

        public IndexModel(jhyf.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<AddHomework> AddHomework { get;set; } = default!;

        public async Task OnGetAsync()
        {
            AddHomework = await _context.Homeworks.ToListAsync();
        }
    }
}
