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
    public partial class RequestForm : Form
    {
        public RequestForm()
        {
            InitializeComponent();
        }
        CategoryRepo cp = new CategoryRepo();
        TourRepo tp = new TourRepo();
        Customer cus = new Customer();

        private void RequestForm_Load(object sender, EventArgs e)
        {
            Form form = new Form();
            form = Application.OpenForms["LoginForm"];
            label3.Text = ((LoginForm)form).GetEmployee().Username;
        }
        
           

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Tour> tours = new List<Tour>();

            foreach (Tour item in tp.Get())
            {
                if (item.CategoryID == ((Category)(cmbCategories.SelectedItem)).CategoryID)
                {
                    tours.Add(item);
                }
            }
            cmbTours.DataSource = tours;
            cmbTours.DisplayMember = "TourName";
        }

        private void chbAbroad_CheckedChanged(object sender, EventArgs e)
        {
            List<Category> Categories = new List<Category>();
            foreach (Category item in cp.Get())
            {

                if (chbAbroad.Checked && (Convert.ToString(item.MainPlace) == (Enum.GetName(typeof(MainPlace), 0))))
                {
                    Categories.Add(item);

                }
                else if (chbDomestic.Checked && (Convert.ToString(item.MainPlace) == (Enum.GetName(typeof(MainPlace), 1))))
                {
                    Categories.Add(item);


                }
                else if (chbDomestic.Checked && chbAbroad.Checked)
                {
                    Categories.Add(item);

                }
          
            }
            cmbCategories.DataSource = Categories;
            cmbCategories.DisplayMember = "CategoryName";


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            ListViewItem lst = new ListViewItem();
            lst.Text = ((Category)cmbCategories.SelectedItem).CategoryName;
            lst.SubItems.Add(((Tour)cmbTours.SelectedItem).TourName);
            lst.SubItems.Add(((Tour)cmbTours.SelectedItem).Limit.ToString());
            lst.SubItems.Add(((Tour)cmbTours.SelectedItem).Price.ToString());
            lst.SubItems.Add(((Tour)cmbTours.SelectedItem).TourDate.ToString());
            listView1.Items.Add(lst);

        }

        private void btnSalesOperation_Click(object sender, EventArgs e)
        {
            SalesOperationsForm sfrm = new SalesOperationsForm();
           
            sfrm.Show();

        }
        public Tour GetTour()
        {
            

            return (Tour)cmbTours.SelectedItem;
        }

        private void chbDomestic_CheckedChanged(object sender, EventArgs e)
        {
            List<Category> Categories = new List<Category>();
            foreach (Category item in cp.Get())
            {

                if (chbAbroad.Checked && (Convert.ToString(item.MainPlace) == (Enum.GetName(typeof(MainPlace), 0))))
                {
                    Categories.Add(item);

                }
                else if (chbDomestic.Checked && (Convert.ToString(item.MainPlace) == (Enum.GetName(typeof(MainPlace), 1))))
                {
                    Categories.Add(item);


                }
                else if (chbDomestic.Checked && chbAbroad.Checked)
                {
                    Categories.Add(item);

                }

            }
            cmbCategories.DataSource = Categories;
            cmbCategories.DisplayMember = "CategoryName";

        }
    }
}
