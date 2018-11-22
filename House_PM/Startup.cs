using House_PM.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(House_PM.Startup))]
namespace House_PM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndUsers();
        }

        public void CreateRolesAndUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!roleManager.RoleExists("admin"))
            {
                var role = new IdentityRole();
                role.Name = "admin";
                roleManager.Create(role);

                var user = new ApplicationUser();
                user.Name = "Angel Roma";
                user.UserName = "angelr10mar@gmail.com";
                user.Email = "angelr10mar@gmail.com";
                string password = "admin123";

                var chkUser = userManager.Create(user, password);

                if (chkUser.Succeeded)
                {
                    var resilt1 = userManager.AddToRole(user.Id, "admin");
                }
            }

            if (!roleManager.RoleExists("doctor"))
            {
                var role = new IdentityRole();
                role.Name = "doctor";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("assistant"))
            {
                var role = new IdentityRole();
                role.Name = "assistant";
                roleManager.Create(role);
            }

        }
    }
}
