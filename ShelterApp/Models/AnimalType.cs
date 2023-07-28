using System;
namespace ShelterApp.Models
{
	public class AnimalType
	{
		public int Id { get; set; }
		public string Name { get; set; } = String.Empty;
		public DateTime CreatedDate { get; set; } = DateTime.Now;

		//One to many configurations
		public List<Animal>? Animals { get; set; }
	}
}

