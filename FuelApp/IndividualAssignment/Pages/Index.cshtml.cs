using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using IndividualAssignmentLibrary;
using IndividualAssignmentLibrary.Persistence;
using IndividualAssignmentLibrary.Business;

namespace IndividualAssignment.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        [Required]
        public string Username { get; set; }

        [BindProperty]
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        LoginManager loginManager = new LoginManager(new AccountRepository());

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (loginManager.Login(Username, Password).Password == null)
                    {
                        ModelState.AddModelError("InvalidCredentials", "The supplied username and/or password is invalid");
                        return Page();
                    }
                    CookieOptions cookieOptions = new CookieOptions();
                    Response.Cookies.Append("username", Username, cookieOptions);
                    HttpContext.Session.SetString("username", Username);

                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Name, Username));
                    claims.Add(new Claim("id", "1"));

                    if ("dandi" == Username)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, "admin"));
                    }
                    else
                    {
                        claims.Add(new Claim(ClaimTypes.Role, "customer"));
                    }

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

                    if (loginManager.Login(Username, Password).Role == "Customer")
                    {
                        return new RedirectToPageResult("/BuyFuel");
                    }
                    else if (loginManager.Login(Username, Password).Role == "Admin")
                    {
                        return new RedirectToPageResult("/AdminAddFuel");
                    }
                }
                else
                {
                    ModelState.AddModelError("InvalidCredentials", "The supplied username and/or password is invalid");
                    return Page();
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
