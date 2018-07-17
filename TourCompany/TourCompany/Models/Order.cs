using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourCompany.Models
{
   public class Order
    {
        public int OrderID { get; set; }
        
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public AirPlaneStatus AirPlaneStatus { get; set; }
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
