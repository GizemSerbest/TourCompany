using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Models;
using TourCompany.Services.Abstracts;

namespace TourCompany.Services.Concretes
{
    public class TourRepo : IRepo<Tour>
    {
        TourCompanyContext db = new TourCompanyContext();
        public void Add(Tour item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tour> Get()
        {
          return  db.Tours.ToList();
        }

        public void Update(Tour item)
        {
            List<Tour> tours = Get();

            foreach (Tour tour in tours)
            {
                if (item.TourID == tour.TourID)
                {
                    tour.Limit = tour.Limit - 1;
                }
            }
            
            
            
            db.SaveChanges();
        }
    }
}
