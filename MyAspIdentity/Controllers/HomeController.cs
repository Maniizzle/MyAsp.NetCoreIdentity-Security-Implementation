using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyAspIdentity.Models;

namespace MyAspIdentity.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<MideUser> userManager;

        public HomeController(UserManager<MideUser> userManager)
        {
            this.userManager = userManager;
        }

        private Task<MideUser> CurrentUser => userManager.FindByNameAsync(HttpContext.User.Identity.Name);

        [Authorize]
        public IActionResult Index()
        {
            return View(GetData(nameof(Index)));
        }
        [Authorize(Roles = "Admin")]
        public IActionResult OtherAction() => View("Index", GetData(nameof(OtherAction)));
        private Dictionary<string, object> GetData(string actionName) =>
            new Dictionary<string, object>
            {
                ["Action"] = actionName,
                ["User"] = HttpContext.User.Identity.Name,
                ["Authenticated"] = HttpContext.User.Identity.IsAuthenticated,
                ["Auth Type"] = HttpContext.User.Identity.AuthenticationType,
                ["In Users Role"] = HttpContext.User.IsInRole("Admin"),
                ["City"]= CurrentUser.Result.City,
                ["Qualification"]= CurrentUser.Result.Qualification
            };
        [Authorize]
        public async Task<IActionResult> UserProps()
        {
            ViewBag.City = new SelectList(Enum.GetNames(typeof(Cities)));
            ViewBag.Qualification = new SelectList(Enum.GetNames(typeof(QualificationLevels)));
            return View(await CurrentUser);
        }    
        
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> UserProps([Required] Cities city, [Required] QualificationLevels qualification)
        {
            if (ModelState.IsValid)
            {
                MideUser user= await CurrentUser;
                user.City = city;
                user.Qualification = qualification;
                await userManager.UpdateAsync(user);
                return RedirectToAction("Index");
            }

            return View(await CurrentUser);
        }
    }
}