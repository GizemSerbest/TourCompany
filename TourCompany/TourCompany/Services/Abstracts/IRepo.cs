using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourCompany.Services.Abstracts
{
    interface IRepo<T>
    {
        void Add(T item);
        void Update(T item);
        List<T> Get();
        void Delete(int id);

    }
}
