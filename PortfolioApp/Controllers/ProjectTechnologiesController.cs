using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioApp.Models;
using PortfolioApp.Repositories;

namespace PortfolioApp.Controllers
{
    //[Route("TasnuvaHaque")]
    public class ProjectTechnologiesController : Controller
    {
        private PortfolioContext db;
        public ProjectTechnologiesController(PortfolioContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            TechnologyProjectVMRepo repo = new TechnologyProjectVMRepo(db);

            return View(repo.GetAll());
        }

        //This Index() method is used for Attribute Routing
        //public IActionResult Index()
        //{
        //    return View(db.TechnologyProjects.Include(tp=>tp.Project).Include(tp=>tp.Technology));
        //}

        [HttpGet("{id:int}")]
        public IActionResult Details(int id)
        {
            TechnologyProjectVMRepo repo = new TechnologyProjectVMRepo(db);
            return View(repo.GetDetails(id));
        }
    }
}