using DriveUp.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;

namespace DriveUp.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<RentACarUser> userManager;
        private readonly UserManager<Data.Entities.User> userManager1;

        public AdminController(UserManager<RentACarUser> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<IActionResult> ListUsers()
        {
            var users = await userManager.Users.ToListAsync();
            return View(users);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            await userManager.DeleteAsync(user);
            return RedirectToAction("ListUsers");
        }

    }
}
