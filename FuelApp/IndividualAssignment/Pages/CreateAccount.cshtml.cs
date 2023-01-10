using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using IndividualAssignmentLibrary;
using IndividualAssignmentLibrary.Business;
using IndividualAssignmentLibrary.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IndividualAssignment.Pages
{
    public class CreateAccountModel : PageModel
    {
        [BindProperty]
        public Customer customer { get; set; }

        AccountManager accountManager = new AccountManager(new AccountRepository());

        [BindProperty]
        public List<ValidationResult> errors { get; set; }

        public void OnGet()
        {
            errors = new List<ValidationResult>();
        }

        public IActionResult OnPost()
        {
            try
            {
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
                    accountManager.CreateAccount(customer.Username, customer.Password, customer.CardNumber, customer.CardValidThru, customer.CardCVC, customer.ZipCode, customer.PhoneNumber);
                }

                return new RedirectToPageResult("/Index");
            }
            catch (DatabaseException)
            {
                return new RedirectToPageResult("/Error");
            }
        }
    }
}
