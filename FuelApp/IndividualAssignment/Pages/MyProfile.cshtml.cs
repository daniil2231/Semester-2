using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using IndividualAssignmentLibrary;
using IndividualAssignmentLibrary.Business;
using IndividualAssignmentLibrary.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IndividualAssignment.Pages
{
    [Authorize(Roles = "customer")]
    public class MyProfileModel : PageModel
    {
        [BindProperty]
        public Customer customer { get; set; }

        AccountManager accountManager = new AccountManager(new AccountRepository());

        [BindProperty]
        public List<ValidationResult> errors { get; set; }

        string UsernameFromCookie;
        string UsernameFromSession;

        public void OnGet()
        {
            if (Request.Cookies.ContainsKey("username"))
            {
                UsernameFromCookie = Request.Cookies["username"];
                customer = accountManager.GetCustomerByUsername(UsernameFromCookie);
            }

            if (HttpContext.Session.Get("username") != null)
            {
                UsernameFromSession = HttpContext.Session.GetString("username");
                customer = accountManager.GetCustomerByUsername(UsernameFromSession);
            }

            errors = new List<ValidationResult>();
        }

        public IActionResult OnPost()
        {
            try
            {
                customer.Id = accountManager.GetCustomerByUsername(Request.Cookies["username"]).Id;
                if (!ModelState.IsValid)
                {
                    if (customer.Username == null || customer.Password == null || customer.ZipCode == null || customer.CardNumber == 0 || customer.CardCVC == 0 || customer.PhoneNumber == 0)
                    {
                        ModelState.AddModelError("EmptyFields", "Please fill out all information fields");
                        return Page();
                    }
                    ValidationContext context = new ValidationContext(customer, null, null);

                    if (!Validator.TryValidateObject(customer, context, errors, true))
                    {
                        for (int i = 0; i < errors.Count; i++)
                        {
                            ModelState.AddModelError(i.ToString(), errors[i].ErrorMessage);
                        }
                        return Page();
                    }
                }
                else
                {
                    accountManager.UpdateAccountInfo(customer);
                    accountManager.UpdatePaymentInfo(customer);
                }

                return Page();
            }
            catch (DatabaseException)
            {
                return new RedirectToPageResult("/Error");
            }
        }
    }
}
