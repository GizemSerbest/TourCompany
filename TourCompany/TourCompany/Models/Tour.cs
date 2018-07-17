using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourCompany.Models
{
   public class Tour
    {
        public int TourID { get; set; }
        public string TourName { get; set; }
        public int Limit { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public DateTime TourDate { get; set; }
    }
}
