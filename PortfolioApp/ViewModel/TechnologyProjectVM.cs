using PortfolioApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.ViewModel
{
    public class TechnologyProjectVM
    {
        public Project Project { get; set; }
        public IEnumerable<Technology> Technologies { get; set; }
    }
}
