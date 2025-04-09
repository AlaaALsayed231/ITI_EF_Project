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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace EF_final_Project
{
    public partial class ProductForm : Form
    {

        private ProductContext dbContext = new ProductContext();
        public ProductForm()
        {

            InitializeComponent();
            GetProductLines();
            GetProducts();

        }

        private void GetProducts()
        {
          var products = dbContext.Products
          .Select(p => new { p.Code,p.Name, p.Scale,p.Vender,p.PdtDescription,p.QlylnStock, p.BuyPrice, p.MSRP, ProductLine = p.ProductLine.DesclnText}).ToList();

         dataGridView1.DataSource = products;
        }


        private void GetProductLines()
        {
           var productLines = dbContext.ProductLines.ToList();
             comboBox1.DataSource = productLines;
           comboBox1.DisplayMember = "DesclnText";
           comboBox1.ValueMember = "ID";
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            
                var product = new Product
                {
                    Name = name.Text,
                    Scale =int.Parse(proScale.Text),
                    Vender = vender.Text,
                    PdtDescription = Description.Text,
                    QlylnStock = int.Parse(stock.Text),
                    BuyPrice = decimal.Parse(price.Text),
                    MSRP = sugPrice.Text,
                    ProductlnID = (int)comboBox1.SelectedValue
                };

                dbContext.Products.Add(product);
                dbContext.SaveChanges();
                GetProducts();
            ClearInputs();
            }

     

        private void btnEdit_Click(object sender, EventArgs e)
        {

                int code = int.Parse(id.Text);
                var product = dbContext.Products.Find(code);

                if (product != null)
                {
                    product.Name = name.Text;
                    product.Scale =int.Parse(proScale.Text);
                    product.Vender = vender.Text;
                    product.PdtDescription = Description.Text;
                    product.QlylnStock = int.Parse(stock.Text);
                    product.BuyPrice = decimal.Parse(price.Text);
                    product.MSRP = sugPrice.Text;
                    product.ProductlnID = (int)comboBox1.SelectedValue;

                    dbContext.SaveChanges();
                    GetProducts();
                }

            dataGridView1.EndEdit();
            dbContext.SaveChanges();
            ClearInputs();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id.Text = row.Cells["Code"].Value.ToString();
                name.Text = row.Cells["Name"].Value.ToString();
                proScale.Text = row.Cells["Scale"].Value?.ToString();
                vender.Text = row.Cells["Vender"].Value?.ToString();
                Description.Text = row.Cells["PdtDescription"].Value?.ToString();
                stock.Text = row.Cells["QlylnStock"].Value.ToString();
                price.Text = row.Cells["BuyPrice"].Value.ToString();
                sugPrice.Text = row.Cells["MSRP"].Value?.ToString();


                comboBox1.SelectedIndex = comboBox1.FindStringExact(row.Cells["ProductLine"].Value?.ToString());
            }
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {
          
            int code = int.Parse(id.Text);  
            var product = dbContext.Products.Find(code);  

                if (product != null)
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete {product.Name}?", "Confirm Delete",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                    dbContext.Products.Remove(product);
                    dbContext.SaveChanges();
                        MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetProducts();
                        ClearInputs();
                    }
                }
                
            }

        private void ClearInputs()
        {
            id.Clear();
            name.Clear();
            proScale.Clear();
            vender.Clear();
            Description.Clear();
            stock.Clear();
            price.Clear();
            sugPrice.Clear();
            
        }
    }



    }

