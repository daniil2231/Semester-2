using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
    [Authorize(Roles = "admin")]
    public class AdminAddFuelModel : PageModel
    {
        [BindProperty]
        public FuelManager FuelManager { get; set; }

        [BindProperty]
        public Diesel Diesel { get; set; }

        [BindProperty]
        public CompressedNaturalGas Cng { get; set; }

        [BindProperty]
        public double NewPrice { get; set; }

        public void OnGet()
        {
            FuelManager = new FuelManager(new FuelRepository());
        }

        public IActionResult OnPostAddDiesel()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    if (Diesel.FuelName == null || Diesel.PricePerLiter == 0 || Diesel.Purity == 0 || Diesel.Viscosity == 0 || Diesel.Suitability == null)
                    {
                        ModelState.AddModelError("EmptyFieldsDiesel", "Please fill out all information fields");
                        return Page();
                    }
                    else
                    {
                        FuelManager.CreateDiesel(Diesel);
                    }
                }
                else
                {
                    FuelManager.CreateDiesel(Diesel);
                }

                return new RedirectToPageResult("/AdminAddFuel");
            }
            catch (DatabaseException)
            {
                return new RedirectToPageResult("/Error");
            }
        }

        public IActionResult OnPostAddCNG()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    if (Cng.FuelName == null || Cng.PricePerLiter == 0 || Cng.Purity == 0 || Cng.AirflowResistance == 0 || Cng.Suitability == null)
                    {
                        ModelState.AddModelError("EmptyFieldsCNG", "Please fill out all information fields");
                        return Page();
                    }
                    else
                    {
                        FuelManager.CreateCNG(Cng);
                    }
                }
                else
                {
                    FuelManager.CreateCNG(Cng);
                }

                return new RedirectToPageResult("/AdminAddFuel");
            }
            catch (DatabaseException)
            {
                return new RedirectToPageResult("/Error");
            }
        }

        public IActionResult OnPost()
        {
            try
            {
                foreach (Diesel diesel in FuelManager.GetDiesels())
                {
                    if (Request.Form.ContainsKey($"submit{diesel.FuelName}"))
                    {
                        FuelManager.EditDieselPrice(diesel, NewPrice);
                        return new RedirectToPageResult("/AdminAddFuel");
                    }
                    else if (Request.Form.ContainsKey($"remove{diesel.FuelName}"))
                    {
                        FuelManager.RemoveDiesel(diesel);
                        return new RedirectToPageResult("/AdminAddFuel");
                    }
                }

                foreach (CompressedNaturalGas cng in FuelManager.GetCNGs())
                {
                    if (Request.Form.ContainsKey($"submit{cng.FuelName}"))
                    {
                        FuelManager.EditCNGPrice(cng, NewPrice);
                        return new RedirectToPageResult("/AdminAddFuel");
                    }
                    else if (Request.Form.ContainsKey($"remove{cng.FuelName}"))
                    {
                        FuelManager.RemoveCNG(cng);
                        return new RedirectToPageResult("/AdminAddFuel");
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
