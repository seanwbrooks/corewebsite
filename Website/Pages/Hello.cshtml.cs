using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
    public class HelloModel : PageModel
    {
        public string Message { get; private set; } = "HelloModel in C#";

        public void OnGet()
        {
            Message += $" Server time is { DateTime.Now }";
        }
    }
}
