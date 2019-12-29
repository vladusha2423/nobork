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
    public class MixerController : Controller
    {
        private readonly ProductsContext _context;
        private static List<Mixer> _Mixers;
        private static Hashtable _ht;
        public MixerController(ProductsContext context)
        {
            _context = context;
            _context = context;
            if (_Mixers == null)
            {
                _Mixers = _context.Mixers.ToList();
                if (_ht == null)
                {
                    _ht = new Hashtable();
                    foreach (Mixer m in _Mixers)
                        _ht.Add(m.Name, m);
                }

            }
        }

        public IActionResult Index()
        {
            return View(_Mixers);
        }

        [HttpPost]
        public IActionResult Filter(FilterForm form)
        {
            _Mixers = _context.Mixers
                .Where(u => u.Price <= form.MaxPrice && u.Price >= form.MinPrice).ToList();
            if (form.Volume != null)
            {
                List<Mixer> temp = new List<Mixer>();
                foreach (int i in form.Volume)
                    temp.AddRange(
                        _context.Mixers.Where(u => u.Volume <= i + 1 && u.Volume >= i - 1));
                _Mixers = _Mixers.Where(u => temp.Contains(u)).ToList();
            }


            if (form.Power != null)
            {
                List<Mixer> temp = new List<Mixer>();
                foreach (int i in form.Power)
                    temp.AddRange(
                        _context.Mixers.Where(u => u.Power <= i + 500 && u.Power >= i - 500));
                _Mixers = _Mixers.Where(u => temp.Contains(u)).ToList();
            }
            if (form.SpeedsNumber != null)
            {
                List<Mixer> temp = new List<Mixer>();
                foreach (int i in form.Power)
                    temp.AddRange(
                        _context.Mixers.Where(u => u.SpeedsNumber == i));
                _Mixers = _Mixers.Where(u => temp.Contains(u)).ToList();
            }
            if (form.ProgramsNumber != null)
            {
                List<Mixer> temp = new List<Mixer>();
                foreach (int i in form.ProgramsNumber)
                    temp.AddRange(
                        _context.Mixers.Where(u => u.ProgramsNumber == i));
                _Mixers = _Mixers.Where(u => temp.Contains(u)).ToList();
            }

            return RedirectToAction("Index");
        }


        public IActionResult Sort(int sort)
        {
            if (sort == 1)
                _Mixers.Sort(new NameComparer());
            else if (sort == 2)
                _Mixers.Sort(new PriceComparer());
            return RedirectToAction("Index");
        }
        public IActionResult Search(SearchString str)
        {
            _Mixers = new List<Mixer>();
            foreach (string s in _ht.Keys)
                if (s.IndexOf(str.Value) != -1)
                    _Mixers.Add(_ht[s] as Mixer);
            return RedirectToAction("Index");
        }
    }
}
