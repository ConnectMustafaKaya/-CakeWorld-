using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KekDukkani.Models;
using KekDukkani.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KekDukkani.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pierepository)
        {
           _pieRepository = pierepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheWeek = _pieRepository.PiesOfTheWeek
            };


            return View(homeViewModel);
        }
    }
}