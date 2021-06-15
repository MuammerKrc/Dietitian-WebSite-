using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.webui.Identity;
using app.webui.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace app.webui.Controllers
{
    public class RoleAndUserController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        private UserManager<User> userManager;
        public RoleAndUserController(UserManager<User> _userManager, RoleManager<IdentityRole> _roleManager)
        {
            roleManager = _roleManager;
            userManager = _userManager;
        }

        #region RoleManager
        public async Task<IActionResult> RoleEdit(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            var members = new List<User>();
            var nonMembers = new List<User>();
            foreach (var user in userManager.Users.ToList())
            {
                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    members.Add(user);
                }
                else
                {
                    nonMembers.Add(user);
                }
            }
            var model = new RoleDetail()
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> RoleEdit(RoleEditModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var userId in model.IdsToAdd ?? new string[] { })
                {
                    var user = await userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await userManager.AddToRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }
                foreach (var userId in model.IdsToDelete ?? new string[] { })
                {
                    var user = await userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await userManager.RemoveFromRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }
            }
            return Redirect("/RoleAndUser/RoleEdit/" + model.RoleId);
        }
        public IActionResult RoleList()
        {
            return View(roleManager.Roles);
        }
        [HttpGet]
        public IActionResult RoleCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await roleManager.CreateAsync(new IdentityRole(model.Name));
                if (result.Succeeded)
                {
                    return RedirectToAction("RoleList");
                }
                else
                {
                    foreach (var errror in result.Errors)
                    {
                        ModelState.AddModelError("", errror.Description);
                    }
                }
            }
            return View(model);

        }
        #endregion

        // **************************************************** 
        #region User
        public IActionResult UserList()
        {
            return View(userManager.Users);
        }
        [HttpGet]
        public async Task<IActionResult> UserEdit(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                var selectedRoles = await userManager.GetRolesAsync(user);
                var roles = roleManager.Roles.Select(i => i.Name);
                var model = new UserModel()
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    UserName = user.UserName,
                    UserId = user.Id,
                    SelectedRoles = selectedRoles
                };
                ViewBag.Roles = roles;
                return View(model);
            }

            return RedirectToAction("~/RoleAndUser/UserList");
        }

        [HttpPost]
        public async Task<IActionResult> UserEdit(UserModel model, string[] selectedRoles)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await userManager.FindByIdAsync(model.UserId);
            if (user != null)
            {
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.UserName = model.UserName;
                user.Email = model.Email;
                user.EmailConfirmed = model.EmailConfirmed;
                var result = await userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    foreach (var roles in selectedRoles ?? new string[] { })
                    {
                        var results = await userManager.AddToRoleAsync(user, roles);
                        if (!results.Succeeded)
                        {
                            foreach (var item in results.Errors)
                            {
                                ModelState.AddModelError("", item.Description);
                            }
                        }
                    }
                    foreach (var removeRoles in roleManager.Roles)
                    {
                        if (!selectedRoles.Contains(removeRoles.Name))
                        {
                            var results = await userManager.RemoveFromRoleAsync(user, removeRoles.Name);
                            if (!results.Succeeded)
                            {
                                foreach (var item in results.Errors)
                                {
                                    ModelState.AddModelError("", item.Description);
                                }
                            }
                        }
                    }
                }
                else{
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("",item.Description);
                    }
                }
            }
            return Redirect("/RoleAndUser/UserList");
        }
        #endregion

    }
}