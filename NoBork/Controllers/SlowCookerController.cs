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
    public class SlowCookerController : Controller
    {
        private readonly ProductsContext _context;
        private static List<SlowCooker> _SlowCookers;
        private static Hashtable _ht;
        public SlowCookerController(ProductsContext context)
        {
            _context = context;
            _context = context;
            if (_SlowCookers == null)
            {
                _SlowCookers = _context.SlowCookers.ToList();
                if (_ht == null)
                {
                    _ht = new Hashtable();
                    foreach (SlowCooker sc in _SlowCookers)
                        _ht.Add(sc.Name, sc);
                }

            }
        }

        public IActionResult Index()
        {
            return View(_SlowCookers);
        }

        [HttpPost]
        public IActionResult Filter(FilterForm form)
        {
            _SlowCookers = _context.SlowCookers
                .Where(u => u.Price <= form.MaxPrice && u.Price >= form.MinPrice).ToList();
            if (form.Volume != null)
            {
                List<SlowCooker> temp = new List<SlowCooker>();
                foreach (int i in form.Volume)
                    temp.AddRange(
                        _context.SlowCookers.Where(u => u.Volume == i));
                _SlowCookers = _SlowCookers.Where(u => temp.Contains(u)).ToList();
            }


            if (form.ModesNumber != null)
            {
                List<SlowCooker> temp = new List<SlowCooker>();
                foreach (int i in form.ModesNumber)
                    temp.AddRange(
                        _context.SlowCookers.Where(u => u.ModesNumber == i));
                _SlowCookers = _SlowCookers.Where(u => temp.Contains(u)).ToList();
            }
            return RedirectToAction("Index");
        }


        public IActionResult Sort(int sort)
        {
            if (sort == 1)
                _SlowCookers.Sort(new NameComparer());
            else if (sort == 2)
                _SlowCookers.Sort(new PriceComparer());
            return RedirectToAction("Index");
        }
        public IActionResult Search(SearchString str)
        {
            _SlowCookers = new List<SlowCooker>();
            foreach (string s in _ht.Keys)
                if (s.IndexOf(str.Value) != -1)
                    _SlowCookers.Add(_ht[s] as SlowCooker);
            return RedirectToAction("Index");
        }
    }
}
