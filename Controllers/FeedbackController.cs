using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PiesShop.Models;

namespace PiesShop.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackRepository repository;

        public FeedbackController(IFeedbackRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                repository.AddFeedback(feedback);
                return RedirectToAction("FeedbackComplete");
            }
            return View(feedback);
        }

        public IActionResult FeedbackComplete()
        {
            return View();
            //Crear la Vista
        }

    }
}