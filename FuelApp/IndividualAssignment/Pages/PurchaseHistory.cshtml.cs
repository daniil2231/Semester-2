using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IndividualAssignmentLibrary;
using IndividualAssignmentLibrary.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IndividualAssignment.Pages
{
    [Authorize(Roles = "admin")]
    public class PurchaseHistoryModel : PageModel
    {
        [BindProperty]
        public FuelManager fuelManager { get; set; }

        IFuelRepository realFuelRepo = new FuelRepository();

        public void OnGet()
        {
            fuelManager = new FuelManager(realFuelRepo);
        }
    }
}
