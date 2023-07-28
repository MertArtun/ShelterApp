using System;
using Microsoft.EntityFrameworkCore;
using ShelterApp.Models;

namespace ShelterApp.Data
{
	public class Context : DbContext
	{

        public DbSet<AnimalType>? AnimalTypes { get; set; }
		public DbSet<Animal>? Animals { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Shelter_DB;User Id=omer.cubukcu;Password=Omer*2957;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}

