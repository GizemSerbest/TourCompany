using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TourCompany.Models;

namespace TourCompany
{
   public class TourCompanyContext:DbContext
    {
        public TourCompanyContext()
        {
            Database.Connection.ConnectionString = @"server=.;database=TourCompanyDB;uid=sa;pwd=123456";
        }

        public DbSet<Tour> Tours { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
