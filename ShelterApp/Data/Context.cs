using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShelterApp.Identity;
using ShelterApp.Models;

namespace ShelterApp.Data
{
	public class Context : IdentityDbContext<AppUser, AppRole, Guid>
	{
        public DbSet<AnimalType>? AnimalTypes { get; set; }
		public DbSet<Animal>? Animals { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=Omer*2957;Host=localhost;Port=5432;Database=ShelterDb;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

