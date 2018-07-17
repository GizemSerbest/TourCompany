using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Models;

namespace TourCompany.Services.Concretes
{
   public  class LoginVerification
    {
        public static bool Verification(string username,string password)
        {
            TourCompanyContext db = new TourCompanyContext();
            List<Employee> employee = db.Employees.Where(x => x.Username == username && x.Password == password).ToList();
            int result = employee.Count();

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
