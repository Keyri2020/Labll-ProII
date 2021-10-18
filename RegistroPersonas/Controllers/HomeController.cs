using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using RegistroPersonas.Repository;
using RegistroPersonas.Service;
using RegistroPersonas.Dominio;
using RegistroPersonas.Data;
using RegistroPersonas.Models;

namespace RegistroPersonas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IPersonas iperson;

        public HomeController(ILogger<HomeController> logger, IPersonas ipersonas)
        {
            this.iperson = ipersonas;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GuardarPerson(PersonViewModel viewModel)
        {
            PersonTb personTb = new PersonTb();

            if (ModelState.IsValid)
            {
                viewModel.Guardar(personTb);
                return View("Index");
            }
            else
            {
                return View("SaveData");
            }

        }

        public IActionResult GetAll()
        {
            var formatoJson = iperson.personList();
            return Json(new { data = formatoJson });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
    
