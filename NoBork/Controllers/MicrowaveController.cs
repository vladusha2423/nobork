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
    public class MicrowaveController : Controller
    {
        private readonly ProductsContext _context;
        private static List<Microwave> _Microwaves;
        private static Hashtable _ht;
        public MicrowaveController(ProductsContext context)
        {
            _context = context;
            _context = context;
            if (_Microwaves == null)
            {
                _Microwaves = _context.Microwaves.ToList();
                if (_ht == null)
                {
                    _ht = new Hashtable();
                    foreach (Microwave mw in _Microwaves)
                        _ht.Add(mw.Name, mw);
                }

            }
        }

        public IActionResult Index()
        {
            return View(_Microwaves);
        }

        [HttpPost]
        public IActionResult Filter(FilterForm form)
        {
            _Microwaves = _context.Microwaves
                .Where(u => u.Price <= form.MaxPrice && u.Price >= form.MinPrice).ToList();
            if (form.Volume != null)
            {
                List<Microwave> temp = new List<Microwave>();
                foreach (int i in form.Volume)
                    temp.AddRange(
                        _context.Microwaves.Where(u => u.Volume <= i + 5 && u.Volume >= i - 5));
                _Microwaves = _Microwaves.Where(u => temp.Contains(u)).ToList();
            }


            if (form.Power != null)
            {
                List<Microwave> temp = new List<Microwave>();
                foreach (int i in form.Power)
                    temp.AddRange(
                        _context.Microwaves.Where(u => u.Power <= i + 500 && u.Power >= i - 500));
                _Microwaves = _Microwaves.Where(u => temp.Contains(u)).ToList();
            }
            if (form.ProgramsNumber != null)
            {
                List<Microwave> temp = new List<Microwave>();
                foreach (int i in form.ProgramsNumber)
                    temp.AddRange(
                        _context.Microwaves.Where(u => u.ProgramsNumber <= i + 1 && u.ProgramsNumber >= i - 1));
                _Microwaves = _Microwaves.Where(u => temp.Contains(u)).ToList();
            }
            if (form.WavePower != null)
            {
                List<Microwave> temp = new List<Microwave>();
                foreach (int i in form.Power)
                    temp.AddRange(
                        _context.Microwaves.Where(u => u.WavePower <= i + 500 && u.WavePower >= i - 500));
                _Microwaves = _Microwaves.Where(u => temp.Contains(u)).ToList();
            }

            return RedirectToAction("Index");
        }


        public IActionResult Sort(int sort)
        {
            if (sort == 1)
                _Microwaves.Sort(new NameComparer());
            else if (sort == 2)
                _Microwaves.Sort(new PriceComparer());
            return RedirectToAction("Index");
        }
        public IActionResult Search(SearchString str)
        {
            _Microwaves = new List<Microwave>();
            foreach (string s in _ht.Keys)
                if (s.IndexOf(str.Value) != -1)
                    _Microwaves.Add(_ht[s] as Microwave);
            return RedirectToAction("Index");
        }
    }
}
