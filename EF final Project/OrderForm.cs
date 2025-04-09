using EF_final_Project.Context;
using EF_final_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EF_final_Project
{
    public partial class OrderForm : Form
    {
        private ProductContext dbContext = new ProductContext();
        public OrderForm()
        {
            InitializeComponent();
            GetCustomers();
            GetOrders();
        }

        private void GetCustomers()
        {

            var customers = dbContext.Customers
                .Select(c => new { c.ID, FullName = c.FirstName + " " + c.LastName }).ToList();

             customers.Insert(0, new { ID = 0, FullName = " Select Customer " });

            comboBox1.DataSource = customers;
            comboBox1.DisplayMember = "FullName";
            comboBox1.ValueMember = "ID";

        }

        private void GetOrders()
        {
            var orders = dbContext.Orders
                .Select(o => new {o.ID,o.OrderDate, o.ReqiredDate,o.ShippedDate,o.CustomerID,
                    Customer = o.Customer.FirstName + " " + o.Customer.LastName,
                    o.Status, o.Comments
                }).ToList();

            dataGridView1.DataSource = orders;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                OrderDate = dateTimePicker1.Value,
                ReqiredDate = dateTimePicker2.Value,
                ShippedDate = dateTimePicker3.Value,
                CustomerID = (int)comboBox1.SelectedValue,
                Status = int.Parse(txtStatus.Text),
                Comments = textComments.Text
            };

            dbContext.Orders.Add(order);
            dbContext.SaveChanges();

            GetOrders();
            MessageBox.Show("Order Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["OrderDate"].Value);
                dateTimePicker2.Value = Convert.ToDateTime(row.Cells["ReqiredDate"].Value);
                dateTimePicker3.Value = row.Cells["ShippedDate"].Value != null ? Convert.ToDateTime(row.Cells["ShippedDate"].Value) : DateTime.Now;
                txtStatus.Text = row.Cells["Status"].Value.ToString();
                textComments.Text = row.Cells["Comments"].Value?.ToString();
                comboBox1.SelectedValue = row.Cells["CustomerID"].Value;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                var order = dbContext.Orders.Find(id);
                if (order != null)
                {
                    order.OrderDate = dateTimePicker1.Value;
                    order.ReqiredDate = dateTimePicker2.Value;
                    order.ShippedDate = dateTimePicker3.Value;
                    order.CustomerID = (int)comboBox1.SelectedValue;
                    order.Status = int.Parse(txtStatus.Text);
                    order.Comments = textComments.Text;

                    dbContext.SaveChanges();
                }
            }
            GetOrders();
            MessageBox.Show("Order Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                var order = dbContext.Orders.Find(id);
                if (order != null)
                {
                    dbContext.Orders.Remove(order);
                    dbContext.SaveChanges();
                }
            }
            GetOrders();
            MessageBox.Show("Order Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }
        private void ClearInputs()
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
            txtStatus.Clear();
            textComments.Clear();
            
        }

    }
}