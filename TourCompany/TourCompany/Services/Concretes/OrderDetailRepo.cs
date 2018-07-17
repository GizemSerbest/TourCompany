using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Models;
using TourCompany.Services.Abstracts;

namespace TourCompany.Services.Concretes
{
    class OrderDetailRepo : IRepo<OrderDetail>
    {
        TourCompanyContext db = new TourCompanyContext();
        public void Add(OrderDetail item)
        {
            db.OrderDetails.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(OrderDetail item)
        {
            throw new NotImplementedException();
        }
    }
}
