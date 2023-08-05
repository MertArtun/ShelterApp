using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShelterApp.Data;
using ShelterApp.Models;

namespace ShelterApp.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AnimalTypeRepository _animalTypeRepository;

        public AnimalController(AnimalTypeRepository animalTypeRepository)
        {
            _animalTypeRepository = animalTypeRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AnimalTypes()
        {
            return View(_animalTypeRepository.GetAll());
        }

        public IActionResult AddAnimalType()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnimalType(AnimalType entity)
        {
            System.Console.WriteLine(JsonConvert.SerializeObject(entity));
            try
            {
                _animalTypeRepository.Insert(entity);
            } 
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                throw;
            }
            return RedirectToAction("AnimalTypes");
        }
    }
}