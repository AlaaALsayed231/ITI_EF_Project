namespace EF_final_Project
{
    partial class CustomerForm
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
            txtRes = new Label();
            comboBox1 = new ComboBox();
            txtPostalCode = new TextBox();
            PostalCode = new Label();
            txtCity = new TextBox();
            City = new Label();
            txtPhone = new Label();
            label4 = new Label();
            txtAddress = new TextBox();
            Address2 = new Label();
            txtAddress1 = new TextBox();
            Address1 = new Label();
            dataGridView1 = new DataGridView();
            txtPho = new TextBox();
            txtlastname = new TextBox();
            txtCode = new TextBox();
            txtFname = new TextBox();
            bnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            last = new Label();
            code = new Label();
            textCountry = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtRes
            // 
            txtRes.AutoSize = true;
            txtRes.Font = new Font("Century", 10.8F);
            txtRes.Location = new Point(394, 390);
            txtRes.Name = "txtRes";
            txtRes.Size = new Size(190, 22);
            txtRes.TabIndex = 99;
            txtRes.Text = "Sales Rep (Employee)";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(394, 427);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(269, 28);
            comboBox1.TabIndex = 98;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(46, 427);
            txtPostalCode.Margin = new Padding(5);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(269, 27);
            txtPostalCode.TabIndex = 97;
            // 
            // PostalCode
            // 
            PostalCode.AutoSize = true;
            PostalCode.Font = new Font("Century", 10.8F);
            PostalCode.Location = new Point(46, 399);
            PostalCode.Name = "PostalCode";
            PostalCode.Size = new Size(103, 22);
            PostalCode.TabIndex = 96;
            PostalCode.Text = "PostalCode";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(46, 339);
            txtCity.Margin = new Padding(5);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(269, 27);
            txtCity.TabIndex = 95;
            // 
            // City
            // 
            City.AutoSize = true;
            City.Font = new Font("Century", 10.8F);
            City.Location = new Point(46, 311);
            City.Name = "City";
            City.Size = new Size(46, 22);
            City.TabIndex = 94;
            City.Text = "City";
            // 
            // txtPhone
            // 
            txtPhone.AutoSize = true;
            txtPhone.Font = new Font("Century", 10.8F);
            txtPhone.Location = new Point(394, 143);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(62, 22);
            txtPhone.TabIndex = 93;
            txtPhone.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 10.8F);
            label4.Location = new Point(394, 60);
            label4.Name = "label4";
            label4.Size = new Size(106, 22);
            label4.TabIndex = 92;
            label4.Text = "First Name";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(394, 253);
            txtAddress.Margin = new Padding(5);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(269, 27);
            txtAddress.TabIndex = 91;
            // 
            // Address2
            // 
            Address2.AutoSize = true;
            Address2.Font = new Font("Century", 10.8F);
            Address2.Location = new Point(394, 225);
            Address2.Name = "Address2";
            Address2.Size = new Size(91, 22);
            Address2.TabIndex = 90;
            Address2.Text = "Address 2";
            // 
            // txtAddress1
            // 
            txtAddress1.Location = new Point(46, 253);
            txtAddress1.Margin = new Padding(5);
            txtAddress1.Name = "txtAddress1";
            txtAddress1.Size = new Size(269, 27);
            txtAddress1.TabIndex = 89;
            // 
            // Address1
            // 
            Address1.AutoSize = true;
            Address1.Font = new Font("Century", 10.8F);
            Address1.Location = new Point(46, 225);
            Address1.Name = "Address1";
            Address1.Size = new Size(91, 22);
            Address1.TabIndex = 88;
            Address1.Text = "Address 1";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 487);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1065, 176);
            dataGridView1.TabIndex = 87;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // txtPho
            // 
            txtPho.Location = new Point(394, 171);
            txtPho.Margin = new Padding(5);
            txtPho.Name = "txtPho";
            txtPho.Size = new Size(269, 27);
            txtPho.TabIndex = 86;
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(46, 171);
            txtlastname.Margin = new Padding(5);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(269, 27);
            txtlastname.TabIndex = 85;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(46, 96);
            txtCode.Margin = new Padding(5);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(269, 27);
            txtCode.TabIndex = 84;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(394, 96);
            txtFname.Margin = new Padding(5);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(269, 27);
            txtFname.TabIndex = 83;
            // 
            // bnDelete
            // 
            bnDelete.BackColor = SystemColors.ActiveCaption;
            bnDelete.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            bnDelete.Location = new Point(817, 318);
            bnDelete.Name = "bnDelete";
            bnDelete.Size = new Size(166, 43);
            bnDelete.TabIndex = 82;
            bnDelete.Text = "Delete";
            bnDelete.UseVisualStyleBackColor = false;
            bnDelete.Click += bnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnEdit.Location = new Point(817, 219);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(166, 43);
            btnEdit.TabIndex = 81;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnAdd.Location = new Point(817, 126);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(166, 43);
            btnAdd.TabIndex = 80;
            btnAdd.Text = "Add Customer";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // last
            // 
            last.AutoSize = true;
            last.Font = new Font("Century", 10.8F);
            last.Location = new Point(46, 143);
            last.Name = "last";
            last.Size = new Size(102, 22);
            last.TabIndex = 79;
            last.Text = "Last Name";
            // 
            // code
            // 
            code.AutoSize = true;
            code.Font = new Font("Century", 10.8F);
            code.Location = new Point(46, 60);
            code.Name = "code";
            code.Size = new Size(117, 22);
            code.TabIndex = 78;
            code.Text = "Customer ID";
            // 
            // textCountry
            // 
            textCountry.Location = new Point(394, 343);
            textCountry.Margin = new Padding(5);
            textCountry.Name = "textCountry";
            textCountry.Size = new Size(269, 27);
            textCountry.TabIndex = 101;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10.8F);
            label5.Location = new Point(394, 315);
            label5.Name = "label5";
            label5.Size = new Size(79, 22);
            label5.TabIndex = 100;
            label5.Text = "Country";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 663);
            Controls.Add(textCountry);
            Controls.Add(label5);
            Controls.Add(txtRes);
            Controls.Add(comboBox1);
            Controls.Add(txtPostalCode);
            Controls.Add(PostalCode);
            Controls.Add(txtCity);
            Controls.Add(City);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(Address2);
            Controls.Add(txtAddress1);
            Controls.Add(Address1);
            Controls.Add(dataGridView1);
            Controls.Add(txtPho);
            Controls.Add(txtlastname);
            Controls.Add(txtCode);
            Controls.Add(txtFname);
            Controls.Add(bnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(last);
            Controls.Add(code);
            Name = "CustomerForm";
            Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtRes;
        private ComboBox comboBox1;
        private TextBox txtPostalCode;
        private Label PostalCode;
        private TextBox txtCity;
        private Label City;
        private Label txtPhone;
        private Label label4;
        private TextBox txtAddress;
        private Label Address2;
        private TextBox txtAddress1;
        private Label Address1;
        private DataGridView dataGridView1;
        private TextBox txtPho;
        private TextBox txtlastname;
        private TextBox txtCode;
        private TextBox txtFname;
        private Button bnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label last;
        private Label code;
        private TextBox textCountry;
        private Label label5;
    }
}