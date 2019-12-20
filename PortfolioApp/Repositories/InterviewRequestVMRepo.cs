using PortfolioApp.Models;
using PortfolioApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Repositories
{
    public class InterviewRequestVMRepo
    {
        private PortfolioContext db;
        public InterviewRequestVMRepo(PortfolioContext db)
        {
            this.db = db;
        }

        public bool Create(InterviewRequestVM irVM)
        {
            // Updating our ViewModel really requires updates to 
            // two separate tables. 

            // Update the 'Store'.
            CompanyRepo companyRepo = new CompanyRepo(db);
           // companyRepo.Create(irVM);

            //// Update the 'Employee'.
            //EmployeeRepo empRepo = new EmployeeRepo(db);
            //empRepo.Update(esVM.EmployeeID, esVM.FirstName, esVM.LastName);

            // Error handling could go here and if problems are encountered
            // 'false' could be returned.

            // Otherwise if things go well return true.
            return true;
        }

    }
}
