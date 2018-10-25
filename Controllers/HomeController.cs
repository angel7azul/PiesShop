using System;
using Microsoft.AspNetCore.Mvc;
using PiesShop.Models;
using System.Linq;
using PiesShop.ViewModels;

namespace PiesShop.Controllers
{
    public class HomeController:Controller
    {
       /*Metodos de Accion, cuyo nombre debera coincidir con una pagina de vista, Razor*/
       private readonly IPieRepository _pieRepository;
       public HomeController(IPieRepository repository)
       {
           this._pieRepository = repository;
       } 

       public IActionResult Index()
       {
           HomeViewModel model = new HomeViewModel
           {
               Title = "Bienvenido",
               Pies = _pieRepository.GetAllPies().OrderBy(p => p.Name).ToList()
           };
           return View(model);
       }

       public IActionResult MisDatos()
       {
           DateTime dato = DateTime.Now;
           ViewBag.message ="Mi mensaje";//Dinamico, se pude poner el nombre que quieras ViewBag.Hola
           return View(dato);
       }

       public IActionResult Contacto()
       {
           return View();
       }
    }//del controlador
}