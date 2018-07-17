using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Models;
using TourCompany.Services.Abstracts;

namespace TourCompany.Services.Concretes
{
    public class OrderRepo : IRepo<Order>
    {
        TourCompanyContext db = new TourCompanyContext();
        public void Add(Order item)
        {
            db.Orders.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(Order item)
        {
            throw new NotImplementedException();
        }
    }
}
