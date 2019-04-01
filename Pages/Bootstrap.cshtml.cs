using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_10_Bootstrap.Pages
{
    public class BootstrapModel : PageModel
    {
        [BindProperty] 
        [Display(Name = "First Name")]
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string FirstName {get; set;}

        [BindProperty] 
        [Display(Name = "Last Name")]
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string LastName {get; set;}

        [BindProperty] 
        [Display(Name = "Credit Card")]
        [Required(ErrorMessage = "Required")]
        [CreditCard]
        public string CreditCard {get; set;}

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
            _log.LogWarning($"{FirstName} {LastName} {CreditCard}");
        }
    }
}
