using System;
using Microsoft.AspNetCore.Mvc;
using PiesShop.Models;
using Microsoft.AspNetCore.Authorization;

namespace PiesShop.Controllers
{
    [Authorize]
    public class PieController:Controller
    {   
        private readonly IPieRepository repository;

        public PieController(IPieRepository repository)
        {
            this.repository = repository;
        }
        
        public IActionResult AddPie()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddPie(Pie pie)
        {           
            if (ModelState.IsValid)
            {
                repository.AddPie(pie);
                return RedirectToAction("PieComplete");
            }
            return View(pie);
        }

        public IActionResult PieComplete()
        {
            return View();
            //Crear la Vista
        }

    }
}