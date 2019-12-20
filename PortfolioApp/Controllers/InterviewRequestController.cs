using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Repositories;
using PortfolioApp.ViewModel;
using PortfolioApp.Models;

namespace PortfolioApp.Controllers
{
    public class InterviewRequestController : Controller
    {
        private PortfolioContext db;

        // Initialize context when controller is created.
        public InterviewRequestController(PortfolioContext db)
        {
            this.db = db;
            
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //[HttpGet]
        //public ActionResult Edit(int employeeID, string branch)
        //{
        //    EmployeeStoreVMRepo esRepo = new EmployeeStoreVMRepo(db);
        //    EmployeeStoreVM esVM = esRepo.Get(employeeID, branch);
        //    return View(esVM);
        //}

        //public IActionResult Create()
        //{
        //  //  InterviewRequestVMRepo irRepo = new InterviewRequestVMRepo(db);
        //  //  InterviewRequestVM irVM = 
        //   //     irRepo.Create(irVM);
        //   // return View(irVM);
        //}
    }
}