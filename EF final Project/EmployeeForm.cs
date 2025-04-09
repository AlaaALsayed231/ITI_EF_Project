using EF_final_Project.Context;
using EF_final_Project.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EF_final_Project
{
    public partial class EmployeeForm : Form
    {
        private readonly ProductContext _context = new ProductContext();

        public EmployeeForm()
        {
            InitializeComponent();
            GetEmployees();
            GetManagers();
           GetOffices();
        }

        private void GetEmployees()
        { 
            var Employees = _context.Employees
                   .Select(e => new{e.ID,e.FirstName,e.LastName,e.Email,e.Extention,e.JobTitle,
                       Office = e.office.City,
                       Manager = e.Manager.FirstName + " " + e.Manager.LastName
                   }).ToList();

            dataGridView1.DataSource = Employees;
        }

        private void GetManagers()
        {
            var managers = _context.Employees.ToList();
            managers.Insert(0, new Employee { ID = 0, FirstName = "-- Select Manager --" }); 

            comboBox2.DataSource = managers;
            comboBox2.DisplayMember = "FirstName";
            comboBox2.ValueMember = "ID";
        }

        private void GetOffices()
        {
            var offices = _context.Offices.ToList();

            offices.Insert(0, new Office { Code = 0, City = "-- Select office --" });

            comboBox1.DataSource = offices;
            comboBox1.DisplayMember = "City";
            comboBox1.ValueMember = "Code";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            var selectedOffice = comboBox1.SelectedValue as int?;
            var selectedManager = (int)comboBox2.SelectedValue;

            var employee = new Employee
            {
                FirstName = txtfn.Text,
                LastName = txtln.Text,
                Email = txtEm.Text,
                JobTitle = txtJ.Text,
                Extention = txtex.Text,
                OfficeCode = selectedOffice.Value,
                reportTo = selectedManager
            };

            _context.Employees.Add(employee);
            _context.SaveChanges();
            GetEmployees();
            GetManagers();
            ClearInputs();
            MessageBox.Show("Employee Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                var employee = _context.Employees.Find(id);

                if (employee != null)
                {
                    employee.FirstName = txtfn.Text;
                    employee.LastName = txtln.Text;
                    employee.Email = txtEm.Text;
                    employee.JobTitle = txtJ.Text;
                    employee.Extention = txtex.Text;
                    employee.OfficeCode = (int)comboBox1.SelectedValue;
                    employee.reportTo = (int?)comboBox2.SelectedValue;

                    _context.SaveChanges();
                    GetEmployees();
                    ClearInputs();
                    MessageBox.Show("Employee Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id.Text = row.Cells["ID"].Value.ToString();
                txtfn.Text = row.Cells["FirstName"].Value.ToString();
                txtln.Text = row.Cells["LastName"].Value.ToString();
                txtEm.Text = row.Cells["Email"].Value?.ToString();
                txtex.Text = row.Cells["Extention"].Value?.ToString();
                txtJ.Text = row.Cells["JobTitle"].Value?.ToString();

                comboBox1.SelectedValue = _context.Offices
                    .FirstOrDefault(o => o.City == row.Cells["Office"].Value.ToString())?.Code;

                comboBox2.SelectedValue = _context.Employees
                    .FirstOrDefault(m => m.FirstName + " " + m.LastName == row.Cells["Manager"].Value.ToString())?.ID;
            }
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                var employee = _context.Employees.Find(id);

                if (employee != null)
                {
                    _context.Employees.Remove(employee);
                    _context.SaveChanges();
                   GetEmployees();
                    GetManagers();
                    ClearInputs();
                    MessageBox.Show("Employee Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }
        }

        private void ClearInputs()
        {
            txtfn.Clear();
            txtln.Clear();
            txtEm.Clear();
            txtex.Clear();
            txtJ.Clear();
            comboBox1.SelectedIndex = 0; 
            comboBox2.SelectedIndex = 0; 
        }
    }
}
