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
    public class ScalesController : Controller
    {
        private readonly ProductsContext _context;
        private static List<Scales> _Scales;
        private static Hashtable _ht;
        public ScalesController(ProductsContext context)
        {
            _context = context;
            _context = context;
            if (_Scales == null)
            {
                _Scales = _context.Scales.ToList();
                if (_ht == null)
                {
                    _ht = new Hashtable();
                    foreach (Scales s in _Scales)
                        _ht.Add(s.Name, s);
                }

            }
        }

        public IActionResult Index()
        {
            return View(_Scales);
        }

        [HttpPost]
        public IActionResult Filter(FilterForm form)
        {
            _Scales = _context.Scales
                .Where(u => u.Price <= form.MaxPrice && u.Price >= form.MinPrice).ToList();


            if (form.MaxWeight != null)
            {
                List<Scales> temp = new List<Scales>();
                foreach (int i in form.MaxWeight)
                    temp.AddRange(
                        _context.Scales.Where(u => u.MaxWeight == i));
                _Scales = _Scales.Where(u => temp.Contains(u)).ToList();
            }

                return RedirectToAction("Index");
        }


        public IActionResult Sort(int sort)
        {
            if (sort == 1)
                _Scales.Sort(new NameComparer());
            else if (sort == 2)
                _Scales.Sort(new PriceComparer());
            return RedirectToAction("Index");
        }
        public IActionResult Search(SearchString str)
        {
            _Scales = new List<Scales>();
            foreach (string s in _ht.Keys)
                if (s.IndexOf(str.Value) != -1)
                    _Scales.Add(_ht[s] as Scales);
            return RedirectToAction("Index");
        }
    }
}
