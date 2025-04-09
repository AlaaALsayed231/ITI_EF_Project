namespace EF_final_Project
{
    partial class OrderProductForm
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
            Order = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            Qty = new Label();
            txtQty = new TextBox();
            label2 = new Label();
            textPriceEach = new TextBox();
            dataGridView1 = new DataGridView();
            bnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Order
            // 
            Order.AutoSize = true;
            Order.Font = new Font("Century", 10.8F);
            Order.ForeColor = SystemColors.ControlDarkDark;
            Order.Location = new Point(68, 114);
            Order.Name = "Order";
            Order.Size = new Size(114, 22);
            Order.TabIndex = 13;
            Order.Text = "Select Order";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(68, 149);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 28);
            comboBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 10.8F);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(442, 110);
            label1.Name = "label1";
            label1.Size = new Size(135, 22);
            label1.TabIndex = 15;
            label1.Text = " Select Product";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(442, 145);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(251, 28);
            comboBox2.TabIndex = 14;
            // 
            // Qty
            // 
            Qty.AutoSize = true;
            Qty.Font = new Font("Century", 10.8F);
            Qty.ForeColor = SystemColors.ControlDarkDark;
            Qty.Location = new Point(68, 220);
            Qty.Name = "Qty";
            Qty.Size = new Size(41, 22);
            Qty.TabIndex = 17;
            Qty.Text = "Qty";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(68, 245);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(251, 27);
            txtQty.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10.8F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(442, 216);
            label2.Name = "label2";
            label2.Size = new Size(170, 22);
            label2.TabIndex = 19;
            label2.Text = "Price Each Product";
            // 
            // textPriceEach
            // 
            textPriceEach.Location = new Point(442, 241);
            textPriceEach.Name = "textPriceEach";
            textPriceEach.Size = new Size(251, 27);
            textPriceEach.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 329);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(960, 216);
            dataGridView1.TabIndex = 45;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // bnDelete
            // 
            bnDelete.BackColor = SystemColors.ActiveCaption;
            bnDelete.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            bnDelete.Location = new Point(788, 273);
            bnDelete.Name = "bnDelete";
            bnDelete.Size = new Size(150, 43);
            bnDelete.TabIndex = 50;
            bnDelete.Text = "Delete";
            bnDelete.UseVisualStyleBackColor = false;
            bnDelete.Click += bnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnEdit.Location = new Point(788, 195);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 43);
            btnEdit.TabIndex = 49;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnAdd.Location = new Point(788, 108);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 43);
            btnAdd.TabIndex = 48;
            btnAdd.Text = "Add Order";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // OrderProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 545);
            Controls.Add(bnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(textPriceEach);
            Controls.Add(Qty);
            Controls.Add(txtQty);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(Order);
            Controls.Add(comboBox1);
            Name = "OrderProductForm";
            Text = "OrderProductForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Order;
        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox2;
        private Label Qty;
        private TextBox txtQty;
        private Label label2;
        private TextBox textPriceEach;
        private DataGridView dataGridView1;
        private Button bnDelete;
        private Button btnEdit;
        private Button btnAdd;
    }
}