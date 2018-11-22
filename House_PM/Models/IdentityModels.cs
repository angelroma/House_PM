using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using House_PM.Models.Domain;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace House_PM.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        private string name;
        private string speciality;
        private string phone;

        public string Speciality { get => speciality; set => speciality = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Vital> Vitals { get; set; }

    }
}