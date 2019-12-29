using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NoBork.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NoBork.Controllers
{
    public class CoffeeMachineController : Controller
    {
        private readonly ProductsContext _context;
        private static List<CoffeeMachine> _CoffeeMachines;
        private static Hashtable _ht;
        public CoffeeMachineController(ProductsContext context)
        {
            _context = context;
            if (_CoffeeMachines == null)
            {
                _CoffeeMachines = _context.CoffeeMachines.ToList();
                if (_ht == null)
                {
                    _ht = new Hashtable();
                    foreach (CoffeeMachine cm in _CoffeeMachines)
                        _ht.Add(cm.Name, cm);
                }

            }
        }

        public IActionResult Index()
        {
            return View(_CoffeeMachines);
        }

        [HttpPost]
        public IActionResult Filter(FilterForm form)
        {
            _CoffeeMachines = _context.CoffeeMachines
                .Where(u => u.Price <= form.MaxPrice && u.Price >= form.MinPrice).ToList();
            if (form.Volume != null)
            {
                List<CoffeeMachine> temp = new List<CoffeeMachine>();
                foreach (int i in form.Volume)
                    temp.AddRange(
                        _context.CoffeeMachines.Where(u => u.Volume <= i + 1 && u.Volume >= i));
                _CoffeeMachines = _CoffeeMachines.Where(u => temp.Contains(u)).ToList();
            }
            if (form.RecipesNumber != null)
            {
                List<CoffeeMachine> temp = new List<CoffeeMachine>();
                foreach (int i in form.RecipesNumber)
                    temp.AddRange(
                        _context.CoffeeMachines.Where(u => u.RecipesNumber == i));
                _CoffeeMachines = _CoffeeMachines.Where(u => temp.Contains(u)).ToList();
            }

            return RedirectToAction("Index");
        }


        public IActionResult Sort(int sort)
        {
            if (sort == 1)
                _CoffeeMachines.Sort(new NameComparer());
            else if (sort == 2)
                _CoffeeMachines.Sort(new PriceComparer());
            return RedirectToAction("Index");
        }
        public IActionResult Search(SearchString str)
        {
            _CoffeeMachines = new List<CoffeeMachine>();
            foreach (string s in _ht.Keys)
                if (s.IndexOf(str.Value) != -1)
                    _CoffeeMachines.Add(_ht[s] as CoffeeMachine);
            return RedirectToAction("Index");
        }
    }
}
