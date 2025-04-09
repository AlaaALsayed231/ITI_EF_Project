using EF_final_Project.Context;
using EF_final_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EF_final_Project
{
    public partial class CustomerForm : Form
    {

        private readonly ProductContext _context = new ProductContext();
        public CustomerForm()
        {
            InitializeComponent();
            GetSalesReps();
            GetCustomers();
            txtCode.ReadOnly = true;
        }



        private void GetCustomers()
        {
            var customers = _context.Customers
                .Select(c => new{ c.ID,c.FirstName,c.LastName,c.Phone,c.Address1,c.Address2,c.City,c.PostalCode,c.Country,
                    SalesRep = c.Employee.FirstName + " " + c.Employee.LastName
                }).ToList();

            dataGridView1.DataSource = customers;
        }

        private void GetSalesReps()
        {
            var salesReps = _context.Employees.ToList();
            salesReps.Insert(0, new Employee { ID = 0, FirstName = "-- Select Sales Rep --" });

            comboBox1.DataSource = salesReps;
            comboBox1.DisplayMember = "FirstName";
            comboBox1.ValueMember = "ID";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selectedSalesRep = (int)comboBox1.SelectedValue;
            int postalCode;

            bool isPostalCodeValid = int.TryParse(txtPostalCode.Text, out postalCode);

            var customer = new Customer
            {
                FirstName = txtFname.Text,
                LastName = txtlastname.Text,
                Phone = txtPho.Text,
                Address1 = txtAddress1.Text,
                Address2 = txtAddress.Text,
                City = txtCity.Text,
                
                PostalCode = isPostalCodeValid ? postalCode : 0,
                Country = textCountry.Text,
                SalesRepEmployeeNum = selectedSalesRep
            };

            _context.Customers.Add(customer);
            _context.SaveChanges();
           GetCustomers();
            ClearInputs();
            MessageBox.Show("Customer Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells["ID"].Value != null)
                    txtCode.Text = row.Cells["ID"].Value.ToString();

                if (row.Cells["FirstName"].Value != null)
                    txtFname.Text = row.Cells["FirstName"].Value.ToString();

                if (row.Cells["LastName"].Value != null)
                    txtlastname.Text = row.Cells["LastName"].Value.ToString();

                if (row.Cells["Phone"].Value != null)
                    txtPho.Text = row.Cells["Phone"].Value.ToString();

                if (row.Cells["Address1"].Value != null)
                    txtAddress1.Text = row.Cells["Address1"].Value.ToString();

                if (row.Cells["Address2"].Value != null)
                    txtAddress.Text = row.Cells["Address2"].Value.ToString();

                if (row.Cells["City"].Value != null)
                    txtCity.Text = row.Cells["City"].Value.ToString();

                if (row.Cells["PostalCode"].Value != null)
                    txtPostalCode.Text = row.Cells["PostalCode"].Value.ToString();

                if (row.Cells["Country"].Value != null)
                    textCountry.Text = row.Cells["Country"].Value.ToString();

                if (_context != null && _context.Employees != null && row.Cells["SalesRep"].Value != null)
                {
                    string salesRepName = row.Cells["SalesRep"].Value.ToString();
                    var employee = _context.Employees.FirstOrDefault(e => (e.FirstName + " " + e.LastName) == salesRepName);
                    if (employee != null)
                    {
                        comboBox1.SelectedValue = employee.ID;
                    }
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                var customer = _context.Customers.Find(id);

                if (customer != null)
                {
                    customer.FirstName = txtFname.Text;
                    customer.LastName = txtlastname.Text;
                    customer.Phone = txtPho.Text;
                    customer.Address1 = txtAddress1.Text;
                    customer.Address2 = txtAddress.Text;
                    customer.City = txtCity.Text;

                    int postalCode;
                    customer.PostalCode = int.TryParse(txtPostalCode.Text, out postalCode) ? postalCode : 0;

                    customer.Country = textCountry.Text;
                    customer.SalesRepEmployeeNum = (int)comboBox1.SelectedValue;

                    _context.SaveChanges();
                    GetCustomers();
                    ClearInputs();
                    MessageBox.Show("Customer Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                var customer = _context.Customers.Find(id);

                if (customer != null)
                {
                    var confirmResult = MessageBox.Show("Are you sure you want to delete this customer", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                   
                    if (confirmResult == DialogResult.Yes)
                    {
                        _context.Customers.Remove(customer);
                        _context.SaveChanges();
                        GetCustomers();
                        ClearInputs();
                        MessageBox.Show("Customer Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               
            }
        }

        private void ClearInputs()
        {
            txtCode.Clear();
            txtFname.Clear();
            txtlastname.Clear();
            txtPho.Clear();
            txtAddress1.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtPostalCode.Clear();
            textCountry.Clear();
            comboBox1.SelectedIndex = 0; 
        }
    }
}

