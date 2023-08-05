using System;
namespace ShelterApp.Models
{
	public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Age { get; set; }
        public string Description { get; set; } = String.Empty;
        public bool IsAdopted { get; set; }
        public DateTime BirtDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime? AdoptedDate { get; set; }

        public AnimalType? Type { get; set; }
    }
}

//// Sahiplendirme Başvuru Sınıfı
//public class AdoptionApplication
//{
//    public int Id { get; set; }
//    public int AnimalId { get; set; }
//    public string ApplicantName { get; set; }
//    public string ApplicantEmail { get; set; }
//    public string Status { get; set; } // "Pending", "Approved", "Rejected"
//}

//// Hayvan Barınağı Yönetim Sistemi Sınıfı
//public class AnimalShelterManagementSystem
//{
//    private List<Animal> animals;
//    private List<AdoptionApplication> adoptionApplications;

//    public AnimalShelterManagementSystem()
//    {
//        animals = new List<Animal>();
//        adoptionApplications = new List<AdoptionApplication>();
//    }

//    // Hayvanları listeleme
//    public List<Animal> GetAnimals()
//    {
//        return animals;
//    }

//    // Hayvan kabul etme
//    public void AddAnimal(Animal animal)
//    {
//        animal.Id = animals.Count + 1;
//        animals.Add(animal);
//    }

//    // Sahiplendirme başvuru yapma
//    public void SubmitAdoptionApplication(AdoptionApplication application)
//    {
//        application.Id = adoptionApplications.Count + 1;
//        application.Status = "Pending";
//        adoptionApplications.Add(application);
//    }

//    // Sahiplendirme başvurularını listeleme
//    public List<AdoptionApplication> GetAdoptionApplications()
//    {
//        return adoptionApplications;
//    }

//    // Sahiplendirme başvurusu onaylama veya reddetme
//    public void ProcessAdoptionApplication(int applicationId, bool isApproved)
//    {
//        var application = adoptionApplications.Find(a => a.Id == applicationId);
//        if (application != null)
//        {
//            application.Status = isApproved ? "Approved" : "Rejected";

//            if (isApproved)
//            {
//                var animal = animals.Find(a => a.Id == application.AnimalId);
//                if (animal != null)
//                {
//                    animal.IsAdopted = true;
//                }
//            }
//        }
//    }
//}

//// Örnek Kullanım
//public class Program
//{
//    public static void Main()
//    {
//        AnimalShelterManagementSystem shelterSystem = new AnimalShelterManagementSystem();

//        // Hayvanlar
//        Animal dog = new Animal { Name = "Buddy", Type = "Dog", Age = 2, Description = "Friendly and playful" };
//        Animal cat = new Animal { Name = "Whiskers", Type = "Cat", Age = 1, Description = "Calm and affectionate" };

//        shelterSystem.AddAnimal(dog);
//        shelterSystem.AddAnimal(cat);

//        // Sahiplendirme Başvuruları
//        AdoptionApplication application1 = new AdoptionApplication { AnimalId = 1, ApplicantName = "John Doe", ApplicantEmail = "john@example.com" };
//        AdoptionApplication application2 = new AdoptionApplication { AnimalId = 2, ApplicantName = "Jane Smith", ApplicantEmail = "jane@example.com" };

//        shelterSystem.SubmitAdoptionApplication(application1);
//        shelterSystem.SubmitAdoptionApplication(application2);

//        // Başvuruları listeleme
//        List<AdoptionApplication> applications = shelterSystem.GetAdoptionApplications();
//        foreach (var application in applications)
//        {
//            Console.WriteLine($"Application ID: {application.Id}, Animal ID: {application.AnimalId}, Applicant Name: {application.ApplicantName}, Status: {application.Status}");
//        }

//        // Sahiplendirme başvurusu onaylama
//        shelterSystem.ProcessAdoptionApplication(1, true);

//        // Hayvanların sahiplendirildiğini kontrol etme
//        List<Animal> animals = shelterSystem.GetAnimals();
//        foreach (var animal in animals)
//        {
//            Console.WriteLine($"Animal ID: {animal.Id}, Name: {animal.Name}, Type: {animal.Type}, Is Adopted: {animal.IsAdopted}");
//        }
//    }
//}
