using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NoBork.Models;

namespace NoBork.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly ProductsContext _context;
        public HomeController(ProductsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<string> TypeNames = new List<string>
            {
                "Blender",
                "Coffee machine",
                "Grill",
                "Juicer",
                "Meat grinder",
                "Microwave",
                "Mixer",
                "Scales",
                "Slow cooker",
                "Toaster"
            };
            return View(TypeNames);
        }
        public IActionResult Blender()
        {
            List<Blender> Blend = _context.Blenders.ToList();
            return View(Blend);
        }
        public IActionResult Coffee()
        {
            List<CoffeeMachine> Coffee = _context.CoffeeMachines.ToList();
            return View(Coffee);
        }
        public IActionResult Grill()
        {
            List<Grill> Grill = _context.Grills.ToList();
            return View(Grill);
        }
        public IActionResult Juicer()
        {
            List<Juicer> Juicer = _context.Juicers.ToList();
            return View(Juicer);
        }
        public IActionResult Meat()
        {
            List<MeatGrinder> Meat = _context.MeatGrinders.ToList();
            return View(Meat);
        }
        public IActionResult Microwave()
        {
            List<Microwave> Microwave = _context.Microwaves.ToList();
            return View(Microwave);
        }
        public IActionResult Mixer()
        {
            List<Mixer> Mixer = _context.Mixers.ToList();
            return View(Mixer);
        }
        public IActionResult Scales()
        {
            List<Scales> Scales = _context.Scales.ToList();
            return View(Scales);
        }
        public IActionResult Slow()
        {
            List<SlowCooker> SlowCook = _context.SlowCookers.ToList();
            return View(SlowCook);
        }
        public IActionResult Toaster()
        {
            List<Toaster> Toaster = _context.Toasters.ToList();
            return View(Toaster);
        }
    }
}
