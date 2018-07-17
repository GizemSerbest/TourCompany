using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Models;

namespace TourCompany.Services.Concretes
{
    static class PriceCalculator
    {
        static public Decimal GetPrice(Decimal TourPrice, CustomerType customerType, AirPlaneStatus airPlaneStatus)
        {
            decimal total = TourPrice;
            if(customerType == CustomerType.Child)
            {
                total = 0m;
            }
            if(customerType == CustomerType.Student)
            {
                total = total - (total * 0.10m);
            }
            if(customerType == CustomerType.Oldage)
            {
                total = total - (total * 0.05m);
            }

            if(airPlaneStatus == AirPlaneStatus.available)
            {
                total = total + 150;
            }
            

            return total;
        } 
    }
}
