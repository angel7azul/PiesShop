using System;
using Microsoft.AspNetCore.Mvc;
using PiesShop.Models;

namespace PiesShop.Controllers
{
    public class AgendaController:Controller
    {
        Contacto contacto;
        public IActionResult Index()
        {
            contacto = new Contacto
            {
                Nombre = "Luis Angel",
                FechaNac = new DateTime(1997/01/17),
                Email = "luisito@gmail.com"
            };
            return View(contacto);
        }
    }
}