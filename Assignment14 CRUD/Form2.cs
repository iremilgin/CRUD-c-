using Assignment14_CRUD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment14_CRUD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        int id = 0;
        NorthwindContext dbContext;
        Order order;

        private void Form2_Load(object sender, EventArgs e)
        {
            dbContext = new NorthwindContext();
            cboxEmployee.DisplayMember = "FirstName";
            cboxEmployee.ValueMember = "EmployeeId";
            cboxEmployee.DataSource = dbContext.Employees.ToList();

            cboxShipper.DisplayMember = "CompanyName";
            cboxShipper.ValueMember = "ShipperId";
            cboxShipper.DataSource = dbContext.Shippers.ToList();
            if (id != 0)
            {
                order = dbContext.Orders.Find(id);
                btnform2.Text = "Update";
                cboxEmployee.SelectedIndex = (int)order.EmployeeId.Value - 1;
                dtpOrder.Value = order.OrderDate.Value;
                txtShipCity.Text = order.ShipCity.ToString();
                cboxShipper.SelectedIndex = (int)order.ShipVia.Value - 1;
            }
        }

        private void btnform2_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                dbContext = new NorthwindContext();
                Order order = new Order();
                int selectedValue = (int)cboxEmployee.SelectedValue;
                order.EmployeeId = selectedValue;
                order.OrderDate = dtpOrder.Value;
                order.ShipCity = txtShipCity.Text;

                int secilenIndis = (int)cboxShipper.SelectedValue;
                order.ShipVia = secilenIndis;

                dbContext.Orders.Add(order);
                dbContext.SaveChanges();
            }
            else if (id != 0)
            {
                order = dbContext.Orders.Find(id);
                int selectedValue = (int)cboxEmployee.SelectedValue;
                order.EmployeeId = selectedValue;
                order.OrderDate = dtpOrder.Value;
                order.ShipCity = txtShipCity.Text;

                int secilenIndis = (int)cboxShipper.SelectedValue;
                order.ShipVia = secilenIndis;

                dbContext.Orders.Update(order);
                dbContext.SaveChanges();
            }
        }
    }
}
