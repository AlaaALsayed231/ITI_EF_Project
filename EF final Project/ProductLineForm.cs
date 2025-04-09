using EF_final_Project.Context;
using EF_final_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_final_Project
{
    public partial class ProductLineForm : Form
    {
        private ProductContext dbContext = new ProductContext();
        public ProductLineForm()
        {
            InitializeComponent();
            LoadProductLines();
       
        txtID.ReadOnly = true;
        }


        private void LoadProductLines()
        {
          
                var productLines = dbContext.ProductLines.ToList();
                dataGridView1.DataSource = productLines
                 .Select(p => new { p.ID, p.DesclnText, p.DesclnHTML, p.Image }).ToList();

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
                var productLine = new ProductLine
                {
                    DesclnText = txtDes.Text,
                    DesclnHTML = txthtml.Text,
                    Image = txtimg.Text 
                };

            dbContext.ProductLines.Add(productLine);
            dbContext.SaveChanges(); 

               
                txtID.Text = productLine.ID.ToString();
                MessageBox.Show("New category Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProductLines();
            ClearInput();
            }
       


        private void dataGridView1_CellMouseClick_2(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells["ID"].Value.ToString(); 
                txtdesc.Text = row.Cells["DesclnText"].Value.ToString();
                txth.Text = row.Cells["DesclnHTML"].Value?.ToString();
                textimg.Text = row.Cells["Image"].Value?.ToString();
            }
        }

     
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
                int id = int.Parse(txtID.Text); 
                var productLine = dbContext.ProductLines.Find(id);

                if (productLine != null)
                {
                    productLine.DesclnText = txtdesc.Text;
                    productLine.DesclnHTML = txth.Text;
                    productLine.Image = textimg.Text;

                dbContext.SaveChanges();
                   MessageBox.Show("Product Line Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadProductLines();
                ClearInput();
                }
               
            }
        

       
        private void bnDelete_Click_1(object sender, EventArgs e)
        {
           
                int id = int.Parse(txtID.Text);
                var productLine = dbContext.ProductLines.Find(id);

                if (productLine != null)
                {
                dbContext.ProductLines.Remove(productLine);
                    dbContext.SaveChanges();

                    MessageBox.Show("Product Line Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadProductLines();
                    ClearInput();
                }
              
            }
      


        
        private void ClearInput()
        {
            txtID.Clear();
            txtdesc.Clear();
            txth.Clear();
            textimg.Clear();
        }
    }
}
    
