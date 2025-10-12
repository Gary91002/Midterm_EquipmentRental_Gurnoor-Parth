using Microsoft.EntityFrameworkCore;
using Midterm_EquipmentRental_Gurnoor_Parth.Models;

namespace Midterm_EquipmentRental_Gurnoor_Parth.Data
{
	public class AppDbContext: DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

        // DbSets

		// Auth DbSets
		public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			base.OnModelCreating(modelBuilder);

            // Seed data

			modelBuilder.Entity<User>().HasData(
				new User { Id = 1, Username = "admin", Password = "admin", Role = "Admin" },
				new User { Id = 2, Username = "user", Password = "user", Role = "User" }
			);
        }

    }
}
