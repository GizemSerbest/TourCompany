using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourCompany.Models
{
   public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public virtual Customer Customer { get; set; }
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
        public int TourID { get; set; }
        public virtual Tour Tour { get; set; }
    }
}
