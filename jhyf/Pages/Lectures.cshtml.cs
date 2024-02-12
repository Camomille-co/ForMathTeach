using jhyf.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace jhyf.Pages
{
    [Authorize]
    public class LecturesModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public LecturesModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {

        }
    }
}
