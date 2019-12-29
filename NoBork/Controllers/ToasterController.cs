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
    public class ToasterController : Controller
    {
        private readonly ProductsContext _context;
        private static List<Toaster> _Toasters;
        private static Hashtable _ht;
        public ToasterController(ProductsContext context)
        {
            _context = context;
            _context = context;
            if (_Toasters == null)
            {
                _Toasters = _context.Toasters.ToList();
                if (_ht == null)
                {
                    _ht = new Hashtable();
                    foreach (Toaster t in _Toasters)
                        _ht.Add(t.Name, t);
                }

            }
        }

        public IActionResult Index()
        {
            return View(_Toasters);
        }

        [HttpPost]
        public IActionResult Filter(FilterForm form)
        {
            _Toasters = _context.Toasters
                .Where(u => u.Price <= form.MaxPrice && u.Price >= form.MinPrice).ToList();


            if (form.ModesNumber != null)
            {
                List<Toaster> temp = new List<Toaster>();
                foreach (int i in form.ModesNumber)
                    temp.AddRange(
                        _context.Toasters.Where(u => u.ModesNumber <= i + 1 && u.ModesNumber >= i - 1));
                _Toasters = _Toasters.Where(u => temp.Contains(u)).ToList();
            }
            if (form.FryingLevels != null)
            {
                List<Toaster> temp = new List<Toaster>();
                foreach (int i in form.FryingLevels)
                    temp.AddRange(
                        _context.Toasters.Where(u => u.FryingLevels == i));
                _Toasters = _Toasters.Where(u => temp.Contains(u)).ToList();
            }

            return RedirectToAction("Index");
        }


        public IActionResult Sort(int sort)
        {
            if (sort == 1)
                _Toasters.Sort(new NameComparer());
            else if (sort == 2)
                _Toasters.Sort(new PriceComparer());
            return RedirectToAction("Index");
        }
        public IActionResult Search(SearchString str)
        {
            _Toasters = new List<Toaster>();
            foreach (string s in _ht.Keys)
                if (s.IndexOf(str.Value) != -1)
                    _Toasters.Add(_ht[s] as Toaster);
            return RedirectToAction("Index");
        }
    }
}
