using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using ProiectDAW.Models;
using System;

[assembly: OwinStartupAttribute(typeof(ProiectDAW.Startup))]
namespace ProiectDAW
{
    public partial class Startup
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateDefaultRolesAndUsers();
        }

        public void CreateDefaultRolesAndUsers()
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            if(!roleManager.RoleExists("Administrator"))
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Administrator";
                roleManager.Create(role);

                ApplicationUser user = new ApplicationUser();
                user.UserName = "admin";
                user.Email = "admin@gametag.com";

                var Check = userManager.Create(user, "admin2020");
                if(Check.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Administrator");
                }
                else
                {
                    var e = new Exception("Could not add default user");

                    var enumerator = Check.Errors.GetEnumerator();
                    foreach(var error in Check.Errors)
                    {
                        e.Data.Add(enumerator.Current, error);
                    }

                    throw e;
                }
            }
        }
    }
}
