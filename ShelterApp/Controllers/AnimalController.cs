using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShelterApp.Data;
using ShelterApp.Models;

namespace ShelterApp.Controllers
{
    public class AnimalController : Controller
    {
        private AnimalTypeRepository _animalTypeRepository;

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
            try
            {
                _animalTypeRepository.Insert(entity);
            } 
            catch(Exception)
            {
                throw;
            }
            return RedirectToAction("AnimalTypes");
        }
    }
}