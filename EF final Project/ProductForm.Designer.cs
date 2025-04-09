namespace EF_final_Project
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            ProductName = new Label();
            Scale = new Label();
            QtyInStock = new Label();
            BuyPrice = new Label();
            ProductDescription = new Label();
            Description = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            bnDelete = new Button();
            price = new TextBox();
            stock = new TextBox();
            id = new TextBox();
            name = new TextBox();
            proScale = new TextBox();
            dataGridView1 = new DataGridView();
            vender = new TextBox();
            Vendor = new Label();
            sugPrice = new TextBox();
            msrp = new Label();
            comboBox1 = new ComboBox();
            Category = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10.8F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(41, 81);
            label2.Name = "label2";
            label2.Size = new Size(106, 22);
            label2.TabIndex = 2;
            label2.Text = "Product ID ";
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Font = new Font("Century", 10.8F);
            ProductName.ForeColor = SystemColors.ControlDarkDark;
            ProductName.Location = new Point(41, 164);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(135, 22);
            ProductName.TabIndex = 4;
            ProductName.Text = "Product Name ";
            // 
            // Scale
            // 
            Scale.AutoSize = true;
            Scale.Font = new Font("Century", 10.8F);
            Scale.ForeColor = SystemColors.ControlDarkDark;
            Scale.Location = new Point(41, 243);
            Scale.Name = "Scale";
            Scale.Size = new Size(64, 22);
            Scale.TabIndex = 6;
            Scale.Text = "Scale :";
            // 
            // QtyInStock
            // 
            QtyInStock.AutoSize = true;
            QtyInStock.Font = new Font("Century", 10.8F);
            QtyInStock.ForeColor = SystemColors.ControlDarkDark;
            QtyInStock.Location = new Point(41, 323);
            QtyInStock.Name = "QtyInStock";
            QtyInStock.Size = new Size(105, 22);
            QtyInStock.TabIndex = 12;
            QtyInStock.Text = "QtyInStock";
            // 
            // BuyPrice
            // 
            BuyPrice.AutoSize = true;
            BuyPrice.Font = new Font("Century", 10.8F);
            BuyPrice.ForeColor = SystemColors.ControlDarkDark;
            BuyPrice.Location = new Point(378, 164);
            BuyPrice.Name = "BuyPrice";
            BuyPrice.Size = new Size(92, 22);
            BuyPrice.TabIndex = 10;
            BuyPrice.Text = "BuyPrice ";
            // 
            // ProductDescription
            // 
            ProductDescription.AutoSize = true;
            ProductDescription.Font = new Font("Century", 10.8F);
            ProductDescription.ForeColor = SystemColors.ControlDarkDark;
            ProductDescription.Location = new Point(381, 81);
            ProductDescription.Name = "ProductDescription";
            ProductDescription.Size = new Size(181, 22);
            ProductDescription.TabIndex = 8;
            ProductDescription.Text = "Product Description ";
            // 
            // Description
            // 
            Description.Location = new Point(378, 117);
            Description.Margin = new Padding(5);
            Description.Name = "Description";
            Description.Size = new Size(269, 27);
            Description.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(772, 112);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 42);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            btnEdit.Location = new Point(772, 223);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(146, 42);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // bnDelete
            // 
            bnDelete.BackColor = SystemColors.ActiveCaption;
            bnDelete.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            bnDelete.Location = new Point(772, 338);
            bnDelete.Name = "bnDelete";
            bnDelete.Size = new Size(146, 42);
            bnDelete.TabIndex = 15;
            bnDelete.Text = "Delete";
            bnDelete.UseVisualStyleBackColor = false;
            bnDelete.Click += bnDelete_Click;
            // 
            // price
            // 
            price.Location = new Point(375, 192);
            price.Margin = new Padding(5);
            price.Name = "price";
            price.Size = new Size(269, 27);
            price.TabIndex = 16;
            // 
            // stock
            // 
            stock.Location = new Point(38, 351);
            stock.Margin = new Padding(5);
            stock.Name = "stock";
            stock.Size = new Size(269, 27);
            stock.TabIndex = 17;
            // 
            // id
            // 
            id.Location = new Point(41, 117);
            id.Margin = new Padding(5);
            id.Name = "id";
            id.Size = new Size(269, 27);
            id.TabIndex = 18;
            // 
            // name
            // 
            name.Location = new Point(41, 192);
            name.Margin = new Padding(5);
            name.Name = "name";
            name.Size = new Size(269, 27);
            name.TabIndex = 19;
            // 
            // proScale
            // 
            proScale.Location = new Point(41, 271);
            proScale.Margin = new Padding(5);
            proScale.Name = "proScale";
            proScale.Size = new Size(269, 27);
            proScale.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 494);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(992, 151);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // vender
            // 
            vender.Location = new Point(375, 271);
            vender.Margin = new Padding(5);
            vender.Name = "vender";
            vender.Size = new Size(269, 27);
            vender.TabIndex = 23;
            // 
            // Vendor
            // 
            Vendor.AutoSize = true;
            Vendor.Font = new Font("Century", 10.8F);
            Vendor.ForeColor = SystemColors.ControlDarkDark;
            Vendor.Location = new Point(378, 243);
            Vendor.Name = "Vendor";
            Vendor.Size = new Size(70, 22);
            Vendor.TabIndex = 22;
            Vendor.Text = "Vendor";
            // 
            // sugPrice
            // 
            sugPrice.Location = new Point(375, 351);
            sugPrice.Margin = new Padding(5);
            sugPrice.Name = "sugPrice";
            sugPrice.Size = new Size(269, 27);
            sugPrice.TabIndex = 25;
            // 
            // msrp
            // 
            msrp.AutoSize = true;
            msrp.Font = new Font("Century", 10.8F);
            msrp.ForeColor = SystemColors.ControlDarkDark;
            msrp.Location = new Point(378, 323);
            msrp.Name = "msrp";
            msrp.Size = new Size(213, 22);
            msrp.TabIndex = 24;
            msrp.Text = "MSRP (Suggested Price)";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(217, 442);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(269, 28);
            comboBox1.TabIndex = 26;
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.Font = new Font("Century", 10.8F);
            Category.ForeColor = SystemColors.ControlDarkDark;
            Category.Location = new Point(112, 442);
            Category.Name = "Category";
            Category.Size = new Size(99, 22);
            Category.TabIndex = 27;
            Category.Text = "Categories";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 645);
            Controls.Add(Category);
            Controls.Add(comboBox1);
            Controls.Add(sugPrice);
            Controls.Add(msrp);
            Controls.Add(vender);
            Controls.Add(Vendor);
            Controls.Add(dataGridView1);
            Controls.Add(proScale);
            Controls.Add(name);
            Controls.Add(id);
            Controls.Add(stock);
            Controls.Add(price);
            Controls.Add(bnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(QtyInStock);
            Controls.Add(BuyPrice);
            Controls.Add(ProductDescription);
            Controls.Add(Description);
            Controls.Add(Scale);
            Controls.Add(ProductName);
            Controls.Add(label2);
            Name = "ProductForm";
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label ProductName;
        private Label Scale;
        private Label QtyInStock;
        private Label BuyPrice;
        private Label ProductDescription;
        private TextBox Description;
        private Button btnAdd;
        private Button btnEdit;
        private Button bnDelete;
        private TextBox price;
        private TextBox stock;
        private TextBox id;
        private TextBox name;
        private TextBox proScale;
        private DataGridView dataGridView1;
        private TextBox vender;
        private Label Vendor;
        private TextBox sugPrice;
        private Label msrp;
        private ComboBox comboBox1;
        private Label Category;
    }
}