using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Models;
using TourCompany.Services.Abstracts;

namespace TourCompany.Services.Concretes
{
    public class CategoryRepo : IRepo<Category>
    {
        TourCompanyContext db = new TourCompanyContext();
        public void Add(Category item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> Get()
        {
            return db.Categories.ToList();
        }

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }
    }
}
