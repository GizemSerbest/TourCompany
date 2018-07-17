using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourCompany.Models;
using TourCompany.Services.Concretes;

namespace TourCompany
{
    public partial class SalesOperationsForm : Form
    {
        public SalesOperationsForm()
        {
            InitializeComponent();
        }
        Form requestform = new Form();
        Tour tour = new Tour();
        TourRepo trepo = new TourRepo();
        Order ord = new Order();
        OrderRepo orepo = new OrderRepo();
        OrderDetailRepo odrepo = new OrderDetailRepo();
        CustomerRepo crepo = new CustomerRepo();
        Customer cus = new Customer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
         
            
            cus.CustomerName = txtCname.Text;
            cus.CustomerSurname = txtCsName.Text;
          
         
            if (chbStandart.Checked)
            {
                cus.CustomerType = 0;
            }
            else if (chbStudent.Checked)
            {
                cus.CustomerType = (CustomerType)1;
            }
            else if (chbChild.Checked)
            {
                cus.CustomerType = (CustomerType)2;
            }
            else if (chbOldAge.Checked)
            {
                cus.CustomerType = (CustomerType)3;

            }
            if (chbMale.Checked)
            {
                cus.GenderType = (GenderType)0;
            }
            else if(chbFemale.Checked)
            {
                cus.GenderType = (GenderType)1;
            }
            if (checkBox1.Checked)
            {
                ord.AirPlaneStatus = 0;
            }else if (checkBox2.Checked)
            {
                ord.AirPlaneStatus = (AirPlaneStatus)1;
            }

            crepo.Add(cus);
     
            requestform = Application.OpenForms["RequestForm"];
            Tour item = new Tour();
            item = ((RequestForm)requestform).GetTour();
            
                ListViewItem li = new ListViewItem();
                li.Text = item.TourName;
                li.SubItems.Add(cus.CustomerName + "" + cus.CustomerSurname);
                li.SubItems.Add(cus.GenderType.ToString());
                li.SubItems.Add(cus.CustomerType.ToString());
                li.SubItems.Add(PriceCalculator.GetPrice(item.Price,cus.CustomerType,ord.AirPlaneStatus).ToString());
                li.SubItems.Add(ord.AirPlaneStatus.ToString());

                lstSalesOperations.Items.Add(li);
            


        }

        private void chbMale_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chbStandart_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        
        
        private void btnComplete_Click(object sender, EventArgs e)
        {
            Form loginform = new Form();
            loginform = Application.OpenForms["LoginForm"];

            decimal total = 0;
            Order order = new Order();
            Tour tour = new Tour();
            tour = ((RequestForm)requestform).GetTour();
            

            foreach(ListViewItem item in lstSalesOperations.Items)
            {
                total = decimal.Parse(item.SubItems[4].Text) + total;
                tour.Limit = tour.Limit - 1;
                trepo.Update(tour);
            }

            order.TotalPrice = total;
            order.OrderDate = DateTime.Now;
            order.AirPlaneStatus = ord.AirPlaneStatus;
            order.EmployeeID = ((LoginForm)loginform).GetEmployee().EmployeeID;
            orepo.Add(order);
            

            foreach(ListViewItem item in lstSalesOperations.Items)
            {
                OrderDetail od = new OrderDetail();
                od.OrderID = order.OrderID;
                od.Customer = cus;
                od.TourID = tour.TourID;
                odrepo.Add(od);


            }

            MessageBox.Show("Your Order is Completed. Order ID : " + order.OrderID + " Total Price : " + total);


        }
    }
}
