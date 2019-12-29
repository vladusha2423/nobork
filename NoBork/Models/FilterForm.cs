using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoBork.Models
{
    public class FilterForm
    {
        public int Sort { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public List<int> Volume { get; set; }
        public List<int> Power { get; set; }
        public List<int> ModesNumber { get; set; }
        public List<int> RecipesNumber { get; set; }
        public List<int> MaxTemp { get; set; }
        public List<int> SpeedsNumber { get; set; }
        public List<int> NozzlesNumber { get; set; }
        public List<int> WavePower { get; set; }
        public List<int> ProgramsNumber { get; set; }
        public List<int> MaxWeight { get; set; }
        public List<int> FryingLevels { get; set; }
    }
}
