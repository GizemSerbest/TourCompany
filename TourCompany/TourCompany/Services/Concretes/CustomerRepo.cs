using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Models;
using TourCompany.Services.Abstracts;

namespace TourCompany.Services.Concretes
{
    public class CustomerRepo : IRepo<Customer>
    {
        TourCompanyContext db = new TourCompanyContext();
        public void Add(Customer item)
        {
            db.Customers.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer item)
        {
            throw new NotImplementedException();
        }
    }
}
