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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        EmployeeRepo erepo = new EmployeeRepo();
        TourCompanyContext db = new TourCompanyContext();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (LoginVerification.Verification(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Login Successful");
                RequestForm rf = new RequestForm();
                rf.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        public Employee GetEmployee()
        {
            Employee employee = new Employee();
            List<Employee> list = new List<Employee>();
            list = db.Employees.ToList();

            foreach(Employee item in list)
            {
                if(item.Username == txtUsername.Text)
                {
                    employee = item;
                }
            }

            return employee;
        }
    }
}
