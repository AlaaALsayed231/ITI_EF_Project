namespace EF_final_Project
{
    partial class OrderForm
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
            OrderDate = new Label();
            RequiredDate = new Label();
            ShippedDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            textComments = new TextBox();
            Comments = new Label();
            comboBox1 = new ComboBox();
            txtStatus = new TextBox();
            Customer = new Label();
            Status = new Label();
            dataGridView1 = new DataGridView();
            bnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // OrderDate
            // 
            OrderDate.AutoSize = true;
            OrderDate.Font = new Font("Century", 10.8F);
            OrderDate.ForeColor = SystemColors.ControlDarkDark;
            OrderDate.Location = new Point(24, 86);
            OrderDate.Name = "OrderDate";
            OrderDate.Size = new Size(104, 22);
            OrderDate.TabIndex = 0;
            OrderDate.Text = "Order Date";
            // 
            // RequiredDate
            // 
            RequiredDate.AutoSize = true;
            RequiredDate.Font = new Font("Century", 10.8F);
            RequiredDate.ForeColor = SystemColors.ControlDarkDark;
            RequiredDate.Location = new Point(24, 170);
            RequiredDate.Name = "RequiredDate";
            RequiredDate.Size = new Size(131, 22);
            RequiredDate.TabIndex = 1;
            RequiredDate.Text = "Required Date";
            // 
            // ShippedDate
            // 
            ShippedDate.AutoSize = true;
            ShippedDate.Font = new Font("Century", 10.8F);
            ShippedDate.ForeColor = SystemColors.ControlDarkDark;
            ShippedDate.Location = new Point(24, 254);
            ShippedDate.Name = "ShippedDate";
            ShippedDate.Size = new Size(122, 22);
            ShippedDate.TabIndex = 2;
            ShippedDate.Text = "Shipped Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Corbel", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dateTimePicker1.CalendarTitleForeColor = SystemColors.AppWorkspace;
            dateTimePicker1.Location = new Point(24, 121);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(24, 206);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(24, 283);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(250, 27);
            dateTimePicker3.TabIndex = 5;
            // 
            // textComments
            // 
            textComments.Location = new Point(396, 129);
            textComments.Multiline = true;
            textComments.Name = "textComments";
            textComments.Size = new Size(251, 104);
            textComments.TabIndex = 6;
            // 
            // Comments
            // 
            Comments.AutoSize = true;
            Comments.Font = new Font("Century", 10.8F);
            Comments.ForeColor = SystemColors.ControlDarkDark;
            Comments.Location = new Point(396, 97);
            Comments.Name = "Comments";
            Comments.Size = new Size(99, 22);
            Comments.TabIndex = 7;
            Comments.Text = "Comments";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(396, 293);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 28);
            comboBox1.TabIndex = 8;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(24, 355);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(261, 27);
            txtStatus.TabIndex = 9;
            // 
            // Customer
            // 
            Customer.AutoSize = true;
            Customer.Font = new Font("Century", 10.8F);
            Customer.ForeColor = SystemColors.ControlDarkDark;
            Customer.Location = new Point(396, 265);
            Customer.Name = "Customer";
            Customer.Size = new Size(91, 22);
            Customer.TabIndex = 11;
            Customer.Text = "Customer";
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Font = new Font("Century", 10.8F);
            Status.ForeColor = SystemColors.ControlDarkDark;
            Status.Location = new Point(24, 330);
            Status.Name = "Status";
            Status.Size = new Size(64, 22);
            Status.TabIndex = 13;
            Status.Text = "Status";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 426);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(943, 194);
            dataGridView1.TabIndex = 44;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // bnDelete
            // 
            bnDelete.BackColor = SystemColors.ActiveCaption;
            bnDelete.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            bnDelete.Location = new Point(781, 298);
            bnDelete.Name = "bnDelete";
            bnDelete.Size = new Size(150, 43);
            bnDelete.TabIndex = 47;
            bnDelete.Text = "Delete";
            bnDelete.UseVisualStyleBackColor = false;
            bnDelete.Click += bnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnEdit.Location = new Point(781, 206);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 43);
            btnEdit.TabIndex = 46;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnAdd.Location = new Point(781, 113);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 43);
            btnAdd.TabIndex = 45;
            btnAdd.Text = "Add Order";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 620);
            Controls.Add(bnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(Status);
            Controls.Add(Customer);
            Controls.Add(txtStatus);
            Controls.Add(comboBox1);
            Controls.Add(Comments);
            Controls.Add(textComments);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(ShippedDate);
            Controls.Add(RequiredDate);
            Controls.Add(OrderDate);
            Name = "OrderForm";
            Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OrderDate;
        private Label RequiredDate;
        private Label ShippedDate;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private TextBox textComments;
        private Label Comments;
        private ComboBox comboBox1;
        private TextBox txtStatus;
        private Label Customer;
        private Label Status;
        private DataGridView dataGridView1;
        private Button bnDelete;
        private Button btnEdit;
        private Button btnAdd;
    }
}