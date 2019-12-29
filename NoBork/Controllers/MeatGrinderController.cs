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
    public class MeatGrinderController : Controller
    {
        private readonly ProductsContext _context;
        private static List<MeatGrinder> _MeatGrinders;
        private static Hashtable _ht;
        public MeatGrinderController(ProductsContext context)
        {
            _context = context;
            _context = context;
            if (_MeatGrinders == null)
            {
                _MeatGrinders = _context.MeatGrinders.ToList();
                if (_ht == null)
                {
                    _ht = new Hashtable();
                    foreach (MeatGrinder mg in _MeatGrinders)
                        _ht.Add(mg.Name, mg);
                }

            }
        }

        public IActionResult Index()
        {
            return View(_MeatGrinders);
        }

        [HttpPost]
        public IActionResult Filter(FilterForm form)
        {
            _MeatGrinders = _context.MeatGrinders
                .Where(u => u.Price <= form.MaxPrice && u.Price >= form.MinPrice).ToList();



            if (form.Power != null)
            {
                List<MeatGrinder> temp = new List<MeatGrinder>();
                foreach (int i in form.Power)
                    temp.AddRange(
                        _context.MeatGrinders.Where(u => u.Power <= i + 500 && u.Power >= i - 500));
                _MeatGrinders = _MeatGrinders.Where(u => temp.Contains(u)).ToList();
            }
            if (form.SpeedsNumber != null)
            {
                List<MeatGrinder> temp = new List<MeatGrinder>();
                foreach (int i in form.NozzlesNumber)
                    temp.AddRange(
                        _context.MeatGrinders.Where(u => u.NozzlesNumber == i));
                _MeatGrinders = _MeatGrinders.Where(u => temp.Contains(u)).ToList();
            }

            return RedirectToAction("Index");
        }


        public IActionResult Sort(int sort)
        {
            if (sort == 1)
                _MeatGrinders.Sort(new NameComparer());
            else if (sort == 2)
                _MeatGrinders.Sort(new PriceComparer());
            return RedirectToAction("Index");
        }
        public IActionResult Search(SearchString str)
        {
            _MeatGrinders = new List<MeatGrinder>();
            foreach (string s in _ht.Keys)
                if (s.IndexOf(str.Value) != -1)
                    _MeatGrinders.Add(_ht[s] as MeatGrinder);
            return RedirectToAction("Index");
        }
    }
}
