using Assignment14_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment14_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindContext dbContext;
        int EmpID;
        int ShipID;
        private void Form1_Load(object sender, EventArgs e)
        {
            dbContext = new NorthwindContext();

            var employees = dbContext.Employees.Select(e => new { e.EmployeeId, e.FirstName, e.LastName }).ToList();

            foreach (var employee in employees)
            {
                ListViewItem item = new ListViewItem(employee.FirstName);
                item.Tag = employee.EmployeeId;
                lvwEmployee.Items.Add(item);
            }


            var shippers = dbContext.Shippers.Select(s => new { s.ShipperId, s.CompanyName }).ToList();

            foreach (var shipper in shippers)
            {
                ListViewItem item = new ListViewItem(shipper.CompanyName);
                item.Tag = shipper.ShipperId;   
                lvwShipper.Items.Add(item);
            }
        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {

            {
                lvwOrder.Items.Clear();

                if (lvwEmployee.SelectedItems.Count == 0 && lvwShipper.SelectedItems.Count == 0)
                {
                    var orders = dbContext.Orders.Select(x => new { x.OrderId, x.OrderDate, x.ShipCity });

                    foreach (var order in orders)
                    {
                        ListViewItem item = new ListViewItem(order.OrderId.ToString());
                        item.SubItems.Add(order.OrderDate.ToString());
                        item.SubItems.Add(order.ShipCity);
                        lvwOrder.Items.Add(item);
                    }
                }
                else if (lvwShipper.SelectedItems.Count > 0 && lvwEmployee.SelectedItems.Count == 0)
                {
                    var orders = from x in dbContext.Orders
                                 where x.ShipVia == ShipID
                                 select new { x.OrderId, x.OrderDate, x.ShipCity };

                    foreach (var order in orders)
                    {
                        ListViewItem item = new ListViewItem(order.OrderId.ToString());
                        item.SubItems.Add(order.OrderDate.ToString());
                        item.SubItems.Add(order.ShipCity);
                        lvwShipper.Items.Add(item);
                    }
                }
                else if (lvwEmployee.SelectedItems.Count > 0 && lvwShipper.SelectedItems.Count == 0)
                {
                    var orders = from x in dbContext.Orders
                                 where x.EmployeeId == EmpID
                                 select new { x.OrderId, x.OrderDate, x.ShipCity };

                    foreach (var order in orders)
                    {
                        ListViewItem item = new ListViewItem(order.OrderId.ToString());
                        item.SubItems.Add(order.OrderDate.ToString());
                        item.SubItems.Add(order.ShipCity);
                        lvwOrder.Items.Add(item);
                    }
                }
                else if (lvwEmployee.SelectedItems.Count > 0 && lvwShipper.SelectedItems.Count > 0)
                {
                    var orders = from x in dbContext.Orders
                                 where x.EmployeeId == EmpID && x.ShipVia == ShipID
                                 select new { x.OrderId, x.OrderDate, x.ShipCity };

                    foreach (var order in orders)
                    {
                        ListViewItem item = new ListViewItem(order.OrderId.ToString());
                        item.SubItems.Add(order.OrderDate.ToString());
                        item.SubItems.Add(order.ShipCity);
                        lvwOrder.Items.Add(item);
                    }
                }
            }
        }

        private void lvwEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> selectedEmpIDs = new List<int>();
            foreach (ListViewItem selectedItem in lvwEmployee.SelectedItems)
            {
                int calisanID = (int)selectedItem.Tag;
                selectedEmpIDs.Add(EmpID);
            }

            if (selectedEmpIDs.Count > 0)
            {
                EmpID = (int)lvwEmployee.SelectedItems[0].Tag;
            }
            else
            {
                EmpID = 0;
            }
        }

        private void lvwShipper_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> selectedShipIDs = new List<int>();
            foreach (ListViewItem selectedItems in lvwShipper.SelectedItems)
            {
                int tedarikID = (int)selectedItems.Tag;
                selectedShipIDs.Add(ShipID);
            }
            if (selectedShipIDs.Count > 0)
            {
                ShipID = (int)lvwShipper.SelectedItems[0].Tag;
            }
            else
            {
                ShipID = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dbContext = new NorthwindContext();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dbContext = new NorthwindContext();
            int index = Convert.ToInt32(lvwOrder.SelectedItems[0].Text);
            Form2 form2 = new Form2(index);
            form2.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dbContext = new NorthwindContext();
            int index = Convert.ToInt32(lvwOrder.SelectedItems[0].Text);
            var order = dbContext.Orders.Find(index);
            if (order != null)
            {
                dbContext.Orders.Remove(order);
                dbContext.SaveChanges();
            }
        }
    }
}