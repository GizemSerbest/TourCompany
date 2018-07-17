using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourCompany.Models
{
   public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public GenderType GenderType { get; set; }
        public CustomerType CustomerType { get; set; }
        public virtual ICollection<Tour> CustomerTours { get; set; }
    }
}
