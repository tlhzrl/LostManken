using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LostManken.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LostManken.Pages.Auth
{
    public class LoginIM
    {
        [Required(ErrorMessage = "E-posta alaný boþ geçilemez")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Parola giriniz")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
    public class LoginModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public LoginModel(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        [BindProperty]
        public LoginIM LoginÝnputModel { get; set; }

        public async Task OnGet()
        {

            var user = new ApplicationUser
            {
                UserName = "Melek_Calti",
                Email = "lostmankenn@gmail.com",

            };

            var result = await _userManager.CreateAsync(user, "05423253455Oz+");

            if (result.Succeeded)
            {

            }

        }

        public async Task<IActionResult> OnPostLogin()
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(LoginÝnputModel.Email);

                if (user != null)
                {
                    var passwordExist = await _userManager.CheckPasswordAsync(user, LoginÝnputModel.Password);

                    var emailCorfirmed = await _userManager.IsEmailConfirmedAsync(user);

                    if (passwordExist && emailCorfirmed)
                    {
                        var result = await _signInManager.PasswordSignInAsync(user, LoginÝnputModel.Password, LoginÝnputModel.RememberMe, false);

                        if (result.Succeeded)
                        {
                        }
                        return new RedirectToPageResult("/Index");
                    }
                    else
                    {
                        ViewData["ErrorMessage"] = "Boyle bir parola yada þifre bulunamadý!";
                    }
                }
                //else
                //{
                //    ViewData["ErrorMessage"] = "Boyle bir parola yada þifre bulunamadý!";
                //}
            }
            return Page();
        }
    }
}
