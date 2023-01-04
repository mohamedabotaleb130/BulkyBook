using BulkyBook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAccess
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CoverType> CoverType { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Company> Companies { get; set; }
		public DbSet<ShoppingCart> ShoppingCarts { get; set; }
		public DbSet<OrderDetail> orderDetails { get; set; }
		public DbSet<OrderHeader> orderHeaders { get; set; }
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<ApplicationUser>().ToTable("Users", "security");
			builder.Entity<IdentityRole>().ToTable("Roles", "security");
			builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "security");
			builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "security");
			builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "security");
			builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "security");
			builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "security");
		}
	}
}

    