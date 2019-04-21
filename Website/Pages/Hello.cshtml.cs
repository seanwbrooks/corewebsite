using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Website.Data;

namespace Website.Pages
{
    public class HelloModel : PageModel
    {
        private readonly AppDbContext _db;

        public HelloModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public User User { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Users.Add(User);
            await _db.SaveChangesAsync();
            return RedirectToPage("/Hello");
        }
    }
}
