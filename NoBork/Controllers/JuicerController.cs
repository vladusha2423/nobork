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
    public class JuicerController : Controller
    {
        private readonly ProductsContext _context;
        private static List<Juicer> _Juicers;
        private static Hashtable _ht;
        public JuicerController(ProductsContext context)
        {
            _context = context;
            _context = context;
            if (_Juicers == null)
            {
                _Juicers = _context.Juicers.ToList();
                if (_ht == null)
                {
                    _ht = new Hashtable();
                    foreach (Juicer j in _Juicers)
                        _ht.Add(j.Name, j);
                }

            }
        }

        public IActionResult Index()
        {
            return View(_Juicers);
        }

        [HttpPost]
        public IActionResult Filter(FilterForm form)
        {
            _Juicers = _context.Juicers
                .Where(u => u.Price <= form.MaxPrice && u.Price >= form.MinPrice).ToList();
            if (form.Volume != null)
            {
                List<Juicer> temp = new List<Juicer>();
                foreach (int i in form.Volume)
                    temp.AddRange(
                        _context.Juicers.Where(u => u.Volume <= i + 1 && u.Volume >= i));
                _Juicers = _Juicers.Where(u => temp.Contains(u)).ToList();
            }



            if (form.Power != null)
            {
                List<Juicer> temp = new List<Juicer>();
                foreach (int i in form.Power)
                    temp.AddRange(
                        _context.Juicers.Where(u => u.Power <= i + 500 && u.Power >= i - 500));
                _Juicers = _Juicers.Where(u => temp.Contains(u)).ToList();
            }
            if (form.SpeedsNumber != null)
            {
                List<Juicer> temp = new List<Juicer>();
                foreach (int i in form.Power)
                    temp.AddRange(
                        _context.Juicers.Where(u => u.SpeedsNumber == i));
                _Juicers = _Juicers.Where(u => temp.Contains(u)).ToList();
            }

            return RedirectToAction("Index");
        }


        public IActionResult Sort(int sort)
        {
            if (sort == 1)
                _Juicers.Sort(new NameComparer());
            else if (sort == 2)
                _Juicers.Sort(new PriceComparer());
            return RedirectToAction("Index");
        }
        public IActionResult Search(SearchString str)
        {
            _Juicers = new List<Juicer>();
            foreach (string s in _ht.Keys)
                if (s.IndexOf(str.Value) != -1)
                    _Juicers.Add(_ht[s] as Juicer);
            return RedirectToAction("Index");
        }
    }
}
