using System;
using System.Collections.Generic;
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
    public class BuyFuelModel : PageModel
    {
        [BindProperty]
        public FuelManager FuelManager { get; set; }

        [BindProperty]
        public double LitersToBuy { get; set; }

        Customer customer;

        [BindProperty]
        public double FillUpTime { get; set; }


        AccountManager accountManager = new AccountManager(new AccountRepository());

        string UsernameFromCookie;
        string UsernameFromSession;

        public void OnGet()
        {
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

                FuelManager = new FuelManager(new FuelRepository());
            }
        }

        public IActionResult OnPost()
        {
            try
            {
                customer = accountManager.GetCustomerByUsername(Request.Cookies["username"]);
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                foreach (Diesel diesel in FuelManager.GetDiesels())
                {
                    if (Request.Form.ContainsKey($"purchase{diesel.FuelName}"))
                    {
                        FuelManager.BuyFuel(diesel, customer, LitersToBuy);
                        FillUpTime = diesel.CalculateFillUpTime(LitersToBuy);
                        return Page();
                    }
                }

                foreach (CompressedNaturalGas cng in FuelManager.GetCNGs())
                {
                    if (Request.Form.ContainsKey($"purchase{cng.FuelName}"))
                    {
                        FuelManager.BuyFuel(cng, customer, LitersToBuy);
                        FillUpTime = cng.CalculateFillUpTime(LitersToBuy);
                        return Page();
                    }
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
