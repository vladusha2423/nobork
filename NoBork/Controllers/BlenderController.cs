using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NoBork.Models;

namespace NoBork.Controllers
{
    public class BlenderController : Controller
    {
        private readonly ProductsContext _context;
        private static List<Blender> _blenders;
        private static Hashtable _ht;
        public BlenderController(ProductsContext context)
        {
            _context = context;
            if (_blenders == null)
            {
                _blenders = _context.Blenders.ToList();
                if (_ht == null)
                {
                    _ht = new Hashtable();
                    foreach (Blender b in _blenders)
                        _ht.Add(b.Name, b);
                }

            }
        }

        public IActionResult Index()
        {
            return View(_blenders);
        }

        [HttpPost]
        public IActionResult Filter(FilterForm form)
        {
            _blenders = _context.Blenders
                .Where(u => u.Price <= form.MaxPrice && u.Price >= form.MinPrice).ToList();
            if (form.Volume != null)
            {
                List<Blender> temp = new List<Blender>();
                foreach (int i in form.Volume)
                    temp.AddRange(
                        _context.Blenders.Where(u => u.Volume <= i + 1 && u.Volume >= i));
                _blenders = _blenders.Where(u => temp.Contains(u)).ToList();
            }


            if (form.Power != null)
            {
                List<Blender> temp = new List<Blender>();
                foreach (int i in form.Power)
                    temp.AddRange(
                        _context.Blenders.Where(u => u.Power <= i + 500 && u.Power >= i - 500));
                _blenders = _blenders.Where(u => temp.Contains(u)).ToList();
            }
            if (form.ModesNumber != null)
            {
                List<Blender> temp = new List<Blender>();
                foreach (int i in form.ModesNumber)
                    temp.AddRange(
                        _context.Blenders.Where(u => u.ModesNumber <= i + 1 && u.ModesNumber >= i - 1));
                _blenders = _blenders.Where(u => temp.Contains(u)).ToList();
            }

            return RedirectToAction("Index");
        }


        public IActionResult Sort(int sort)
        {
            if (sort == 1)
                _blenders.Sort(new NameComparer());
            else if (sort == 2)
                _blenders.Sort(new PriceComparer());
            return RedirectToAction("Index");
        }
        public IActionResult Search(SearchString str)
        {
            _blenders = new List<Blender>();
            foreach (string s in _ht.Keys)
                if (s.IndexOf(str.Value) != -1)
                    _blenders.Add(_ht[s] as Blender);
            return RedirectToAction("Index");
        }
        
    }
}
