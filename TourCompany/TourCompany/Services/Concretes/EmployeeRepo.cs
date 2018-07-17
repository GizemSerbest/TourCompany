using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Models;
using TourCompany.Services.Abstracts;

namespace TourCompany.Services.Concretes
{

     

    class EmployeeRepo : IRepo<Employee>
    {

        TourCompanyContext db = new TourCompanyContext();

        public void Add(Employee item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> Get()
        {
            return db.Employees.ToList();
        }

        public void Update(Employee item)
        {
            throw new NotImplementedException();
        }
    }
}
