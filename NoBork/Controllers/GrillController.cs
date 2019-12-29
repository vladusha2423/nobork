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
    public class GrillController : Controller
    {
        private readonly ProductsContext _context;
        private static List<Grill> _Grills;
        private static Hashtable _ht;
        public GrillController(ProductsContext context)
        {
            _context = context;
            _context = context;
            if (_Grills == null)
            {
                _Grills = _context.Grills.ToList();
                if (_ht == null)
                {
                    _ht = new Hashtable();
                    foreach (Grill g in _Grills)
                        _ht.Add(g.Name, g);
                }

            }
        }

        public IActionResult Index()
        {
            return View(_Grills);
        }

        [HttpPost]
        public IActionResult Filter(FilterForm form)
        {
            _Grills = _context.Grills
                .Where(u => u.Price <= form.MaxPrice && u.Price >= form.MinPrice).ToList();



            if (form.MaxTemp != null)
            {
                List<Grill> temp = new List<Grill>();
                foreach (int i in form.Volume)
                    temp.AddRange(
                        _context.Grills.Where(u => u.MaxTemp == i));
                _Grills = _Grills.Where(u => temp.Contains(u)).ToList();
            }
            if (form.Power != null)
            {
                List<Grill> temp = new List<Grill>();
                foreach (int i in form.Power)
                    temp.AddRange(
                        _context.Grills.Where(u => u.Power == i));
                _Grills = _Grills.Where(u => temp.Contains(u)).ToList();
            }

            return RedirectToAction("Index");
        }


        public IActionResult Sort(int sort)
        {
            if (sort == 1)
                _Grills.Sort(new NameComparer());
            else if (sort == 2)
                _Grills.Sort(new PriceComparer());
            return RedirectToAction("Index");
        }
        public IActionResult Search(SearchString str)
        {
            _Grills = new List<Grill>();
            foreach (string s in _ht.Keys)
                if (s.IndexOf(str.Value) != -1)
                    _Grills.Add(_ht[s] as Grill);
            return RedirectToAction("Index");
        }
    }
}
