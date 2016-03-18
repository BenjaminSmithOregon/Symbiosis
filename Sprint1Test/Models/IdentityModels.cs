using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;
using System;

namespace Sprint1Test.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        //public string NickName { get; set; }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public virtual ICollection<Profile> profile { get; set; }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
            //Database.SetInitializer<ApplicationDbContext>(new DropCreateDatabaseAlways<ApplicationDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<Sprint1Test.Models.Profile> Profiles { get; set; }

        public System.Data.Entity.DbSet<Sprint1Test.Models.Post> Posts { get; set; }

        public System.Data.Entity.DbSet<Sprint1Test.Models.Skill> Skills { get; set; }

        public System.Data.Entity.DbSet<Sprint1Test.Models.SubCategory> SubCategories { get; set; }

        public System.Data.Entity.DbSet<Sprint1Test.Models.Category> Categories { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<UserJob> UserJobs { get; set; }

      //  public System.Data.Entity.DbSet<Sprint1Test.Models.ApplicationUser> ApplicationUsers { get; set; }
        // DELETE ANYTHING THAT LOOKS LIKE THIS LINE IF IT EVER EXISTS

    }
}