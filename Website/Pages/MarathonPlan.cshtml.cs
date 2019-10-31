using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
    public class MarathonPlanModel : PageModel
    {
        public void OnGet()
        {
        }

        public object OnSubmit(object formData)
        {
            return formData;
        }
    }
}
