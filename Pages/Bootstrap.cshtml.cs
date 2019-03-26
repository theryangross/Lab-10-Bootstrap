using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Lab_10_Bootstrap.Pages
{
    public class BootstrapModel : PageModel
    {
        private readonly ILogger _log;
        public BootstrapModel(ILogger<BootstrapModel> log) 
        {
        _log = log; 
        }
        public void OnGet()
        {
            Object b = null;
            if (b == null) _log.LogWarning("Object is null!");
            else b.ToString();
        }

        public void OnPost()
        {
            _log.LogInformation("OnPost()Called");
        }
    }
}
