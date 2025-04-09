namespace EF_final_Project
{
    partial class OfficeForm
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
            dataGridView1 = new DataGridView();
            txtAdd2 = new TextBox();
            txtCity = new TextBox();
            txtCode = new TextBox();
            txtAddress1 = new TextBox();
            bnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            City = new Label();
            code = new Label();
            txtCountry = new TextBox();
            Country = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtAddress2 = new Label();
            txtPostalCode = new TextBox();
            PostalCode = new Label();
            txtState = new TextBox();
            label2 = new Label();
            Territory = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 470);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1015, 167);
            dataGridView1.TabIndex = 65;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // txtAdd2
            // 
            txtAdd2.Location = new Point(404, 173);
            txtAdd2.Margin = new Padding(5);
            txtAdd2.Name = "txtAdd2";
            txtAdd2.Size = new Size(269, 27);
            txtAdd2.TabIndex = 64;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(44, 173);
            txtCity.Margin = new Padding(5);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(269, 27);
            txtCity.TabIndex = 63;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(44, 98);
            txtCode.Margin = new Padding(5);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(269, 27);
            txtCode.TabIndex = 62;
            // 
            // txtAddress1
            // 
            txtAddress1.Location = new Point(404, 98);
            txtAddress1.Margin = new Padding(5);
            txtAddress1.Name = "txtAddress1";
            txtAddress1.Size = new Size(269, 27);
            txtAddress1.TabIndex = 61;
            // 
            // bnDelete
            // 
            bnDelete.BackColor = SystemColors.ActiveCaption;
            bnDelete.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            bnDelete.Location = new Point(797, 295);
            bnDelete.Name = "bnDelete";
            bnDelete.Size = new Size(186, 43);
            bnDelete.TabIndex = 60;
            bnDelete.Text = "Delete";
            bnDelete.UseVisualStyleBackColor = false;
            bnDelete.Click += bnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnEdit.Location = new Point(797, 205);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(186, 43);
            btnEdit.TabIndex = 59;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnAdd.Location = new Point(797, 103);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(186, 43);
            btnAdd.TabIndex = 58;
            btnAdd.Text = "Add New Office";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // City
            // 
            City.AutoSize = true;
            City.Font = new Font("Century", 10.8F);
            City.ForeColor = SystemColors.ControlDarkDark;
            City.Location = new Point(44, 145);
            City.Name = "City";
            City.Size = new Size(46, 22);
            City.TabIndex = 53;
            City.Text = "City";
            // 
            // code
            // 
            code.AutoSize = true;
            code.Font = new Font("Century", 10.8F);
            code.ForeColor = SystemColors.ControlDarkDark;
            code.Location = new Point(44, 62);
            code.Name = "code";
            code.Size = new Size(95, 22);
            code.TabIndex = 52;
            code.Text = "Office ID :";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(44, 255);
            txtCountry.Margin = new Padding(5);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(269, 27);
            txtCountry.TabIndex = 67;
            // 
            // Country
            // 
            Country.AutoSize = true;
            Country.Font = new Font("Century", 10.8F);
            Country.ForeColor = SystemColors.ControlDarkDark;
            Country.Location = new Point(44, 227);
            Country.Name = "Country";
            Country.Size = new Size(79, 22);
            Country.TabIndex = 66;
            Country.Text = "Country";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(404, 255);
            txtPhone.Margin = new Padding(5);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(269, 27);
            txtPhone.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10.8F);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(404, 227);
            label3.Name = "label3";
            label3.Size = new Size(62, 22);
            label3.TabIndex = 68;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 10.8F);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(404, 62);
            label4.Name = "label4";
            label4.Size = new Size(86, 22);
            label4.TabIndex = 70;
            label4.Text = "Address1";
            // 
            // txtAddress2
            // 
            txtAddress2.AutoSize = true;
            txtAddress2.Font = new Font("Century", 10.8F);
            txtAddress2.ForeColor = SystemColors.ControlDarkDark;
            txtAddress2.Location = new Point(404, 145);
            txtAddress2.Name = "txtAddress2";
            txtAddress2.Size = new Size(86, 22);
            txtAddress2.TabIndex = 71;
            txtAddress2.Text = "Address2";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(404, 341);
            txtPostalCode.Margin = new Padding(5);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(269, 27);
            txtPostalCode.TabIndex = 75;
            // 
            // PostalCode
            // 
            PostalCode.AutoSize = true;
            PostalCode.Font = new Font("Century", 10.8F);
            PostalCode.ForeColor = SystemColors.ControlDarkDark;
            PostalCode.Location = new Point(404, 313);
            PostalCode.Name = "PostalCode";
            PostalCode.Size = new Size(103, 22);
            PostalCode.TabIndex = 74;
            PostalCode.Text = "PostalCode";
            // 
            // txtState
            // 
            txtState.Location = new Point(44, 341);
            txtState.Margin = new Padding(5);
            txtState.Name = "txtState";
            txtState.Size = new Size(269, 27);
            txtState.TabIndex = 73;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10.8F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(44, 313);
            label2.Name = "label2";
            label2.Size = new Size(54, 22);
            label2.TabIndex = 72;
            label2.Text = "State";
            // 
            // Territory
            // 
            Territory.AutoSize = true;
            Territory.Font = new Font("Century", 10.8F);
            Territory.ForeColor = SystemColors.ControlDarkDark;
            Territory.Location = new Point(167, 421);
            Territory.Name = "Territory";
            Territory.Size = new Size(87, 22);
            Territory.TabIndex = 77;
            Territory.Text = "Territory";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(260, 421);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(269, 28);
            comboBox1.TabIndex = 76;
            // 
            // OfficeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 637);
            Controls.Add(Territory);
            Controls.Add(comboBox1);
            Controls.Add(txtPostalCode);
            Controls.Add(PostalCode);
            Controls.Add(txtState);
            Controls.Add(label2);
            Controls.Add(txtAddress2);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtCountry);
            Controls.Add(Country);
            Controls.Add(dataGridView1);
            Controls.Add(txtAdd2);
            Controls.Add(txtCity);
            Controls.Add(txtCode);
            Controls.Add(txtAddress1);
            Controls.Add(bnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(City);
            Controls.Add(code);
            Name = "OfficeForm";
            Text = "OfficeForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PostalCode;
        private ComboBox comboBox2;
        private Label Territory;
        private ComboBox comboBox1;
        private TextBox txtex;
        private Label txtExt;
        private DataGridView dataGridView1;
        private TextBox txtAdd2;
        private TextBox txtCity;
        private TextBox txtCode;
        private TextBox txtAddress1;
        private Button bnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label txtEmail;
        private Label ProductDescription;
        private TextBox txtAddress;
        private Label txtJob;
        private Label City;
        private Label code;
        private TextBox txtCountry;
        private Label Country;
        private TextBox txtPhone;
        private Label label3;
        private Label label4;
        private Label txtAddress2;
        private TextBox txtPostalCode;
        private TextBox txtState;
        private Label label2;
    }
}