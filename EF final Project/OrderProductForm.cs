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

namespace EF_final_Project
{
    public partial class OrderProductForm : Form
    {

        private readonly ProductContext _context = new ProductContext();
        public OrderProductForm()
        {
            InitializeComponent();
            GetOrders();
            GetProducts();
            GetOrderProducts();
        }


        private void GetOrders()
        {
            var orders = _context.Orders.Select(o => new { o.ID, Name = "Order " + o.ID }).ToList();
            orders.Insert(0, new { ID = 0, Name = "-- Select Order --" });

            comboBox1.DataSource = orders;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
        }

        private void GetProducts()
        {
            var products = _context.Products.Select(p => new { p.Code, p.Name }).ToList();
            products.Insert(0, new { Code = 0, Name = "-- Select Product --" });

            comboBox2.DataSource = products;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Code";
        }

       
        private void GetOrderProducts()
        {
            var orderProducts = _context.OrderProducts
                .Select(op => new{op.ID,
                    Order = "Order " + op.OrderID,op.Order.OrderDate,
                    Product = op.Product.Name,op.Product.PdtDescription, op.Product.Vender,
                    op.Qty,
                    op.PriceEach
                }).ToList();

            dataGridView1.DataSource = orderProducts;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var orderProduct = new OrderProduct
            {
                OrderID = (int)comboBox1.SelectedValue,
                ProductCode = (int)comboBox2.SelectedValue,
                Qty = int.Parse(txtQty.Text),
                PriceEach = int.Parse(textPriceEach.Text)
            };

            _context.OrderProducts.Add(orderProduct);
            _context.SaveChanges();
            GetOrderProducts();
            MessageBox.Show("Order Product Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtQty.Text = row.Cells["Qty"].Value.ToString();
                textPriceEach.Text = row.Cells["PriceEach"].Value.ToString();

                comboBox1.SelectedValue = _context.Orders
                       .FirstOrDefault(o => "Order " + o.ID == row.Cells["Order"].Value.ToString())?.ID;

                comboBox2.SelectedValue = _context.Products
                    .FirstOrDefault(p => p.Name == row.Cells["Product"].Value.ToString())?.Code;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                var orderProduct = _context.OrderProducts.Find(id);

                if (orderProduct != null)
                {
                    orderProduct.OrderID = (int)comboBox1.SelectedValue;
                    orderProduct.ProductCode = (int)comboBox2.SelectedValue;
                    orderProduct.Qty = int.Parse(txtQty.Text);
                    orderProduct.PriceEach = int.Parse(textPriceEach.Text);

                    _context.SaveChanges();
                    GetOrderProducts();
                    MessageBox.Show("Order Product Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                }
            }
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                var orderProduct = _context.OrderProducts.Find(id);

                if (orderProduct != null)
                {
                    _context.OrderProducts.Remove(orderProduct);
                    _context.SaveChanges();
                    GetOrderProducts();
                    MessageBox.Show("Order Product Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                }
            }
        }

     
        private void ClearInputs()
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0; 
            txtQty.Clear();
            textPriceEach.Clear();
        }
    }
}

