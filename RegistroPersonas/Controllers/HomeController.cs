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

        public IActionResult GuardarPerson(PersonTb viewModel)
        {
            if (ModelState.IsValid)
            {
                PersonTb personTb = new PersonTb();
                if (personTb.EdadPersona >= 18)
                {
                    personTb.NombrePersona = viewModel.NombrePersona;
                    personTb.EdadPersona = viewModel.EdadPersona;
                    personTb.DescripcionPersona = viewModel.DescripcionPersona;

                    iperson.SaveData(personTb);
                    return View("Index");

                }
                else
                {
                    return Redirect("/Home/SaveData");
                }

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
    
