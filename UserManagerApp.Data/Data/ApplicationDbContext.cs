using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserManagerApp.Models.Entities;

namespace UserManagerApp.Data.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ApplicationUser> AppUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().HasData(

                new ApplicationUser { Id = "1", FirstName = "Wisdom", LastName = "Ngwueche", Email = "wisdomngwueche@gmail.com", ImageUrl = "", UserName = "wisdomngwueche", GitHub = "ngwueche", Twitter = "wisdomngwueche" },
                new ApplicationUser { Id = "2", FirstName = "Ada", LastName = "Mgbede", Email = "addamgbede@gmail.com", ImageUrl = "", UserName = "addamgbede", GitHub = "addamgbede", Twitter = "addamgbede" },
                new ApplicationUser { Id = "3", FirstName = "Nnenna", LastName = "Humphery", Email = "nnennahumphery@gmail.com", ImageUrl = "", UserName = "nnennahumphery", GitHub = "nnennahumphery", Twitter = "nnennahumphery" },
                new ApplicationUser { Id = "4", FirstName = "Covenant", LastName = "Ebube", Email = "covenantebube@gmail.com", ImageUrl = "", UserName = "covenantebube", GitHub = "covenantebube", Twitter = "covenantebube" },
                new ApplicationUser { Id = "5", FirstName = "Ebele", LastName = "Okolo", Email = "ebeleokolo@gmail.com", ImageUrl = "", UserName = "E_okolo", GitHub = "E_okolo", Twitter = "ebeleokolo" },
                new ApplicationUser { Id = "6", FirstName = "Utobi", LastName = "Ozoeze", Email = "uto@gmail.com", ImageUrl = "", UserName = "O_uto", GitHub = "O_uto", Twitter = "ozoeze" }
                );

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Regular" },
                new IdentityRole { Id = "2", Name = "Admin" }
                );


        }

        //protected override void up(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.Sql(@"INSERT INTO AspNetRoles()");
        //}
    }
}
