using EF_final_Project.Context;
using EF_final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EF_final_Project
{
    public partial class OfficeForm : Form
    {
        private readonly ProductContext _context = new ProductContext();

        public OfficeForm()
        {
            InitializeComponent();
            GetOffices();
            GetTerritories();
            txtCode.ReadOnly = true;
        }

        private void GetOffices()
        {
            var offices = _context.Offices
                .Select(o => new { o.Code,o.City,o.Phone, o.Address1,o.Address2,o.State,o.Country,o.PostalCode,o.Territory}).ToList();

            dataGridView1.DataSource = offices;
        }

      
        private void GetTerritories()
        {
            comboBox1.DataSource = new List<string> { "North America", "Europe", "Asia", "Middle East & Africa" };
        }

       
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            var office = new Office
            {
                City = txtCity.Text,
                Phone = txtPhone.Text,
                Address1 = txtAddress1.Text,
                Address2 = txtAdd2.Text,
                State = txtState.Text,
                Country = txtCountry.Text,
                PostalCode = int.Parse(txtPostalCode.Text),
                Territory = comboBox1.SelectedItem.ToString()
            };

            _context.Offices.Add(office);
            _context.SaveChanges();
            GetOffices();
            ClearInputs();
            MessageBox.Show("Office Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtCode.Text = row.Cells["Code"].Value.ToString();
                txtCity.Text = row.Cells["City"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtAddress1.Text = row.Cells["Address1"].Value?.ToString();
                txtAdd2.Text = row.Cells["Address2"].Value?.ToString();
                txtState.Text = row.Cells["State"].Value?.ToString();
                txtCountry.Text = row.Cells["Country"].Value?.ToString();
                txtPostalCode.Text = row.Cells["PostalCode"].Value.ToString();

                comboBox1.SelectedIndex = comboBox1.FindStringExact(row.Cells["Territory"].Value?.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Code"].Value);
                var office = _context.Offices.Find(id);

                if (office != null)
                {
                    office.City = txtCity.Text;
                    office.Phone = txtPhone.Text;
                    office.Address1 = txtAddress1.Text;
                    office.Address2 = txtAdd2.Text;
                    office.State = txtState.Text;
                    office.Country = txtCountry.Text;
                    office.PostalCode = int.Parse(txtPostalCode.Text);
                    office.Territory = comboBox1.SelectedItem.ToString();

                    _context.SaveChanges();
                    GetOffices();
                    ClearInputs();
                    MessageBox.Show("Office Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }


        private void bnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Code"].Value);
                var office = _context.Offices.Find(id);

                if (office != null)
                {
                    _context.Offices.Remove(office);
                    _context.SaveChanges();
                    GetOffices();
                    ClearInputs();
                    MessageBox.Show("Office Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
          
        }
        private void ClearInputs()
        {
            txtCode.Clear();
            txtCity.Clear();
            txtPhone.Clear();
            txtAddress1.Clear();
            txtAdd2.Clear();
            txtState.Clear();
            txtCountry.Clear();
            txtPostalCode.Clear();
            comboBox1.SelectedIndex = -1; 
        }
    }
}
