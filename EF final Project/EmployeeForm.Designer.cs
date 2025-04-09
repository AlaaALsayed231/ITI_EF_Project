namespace EF_final_Project
{
    partial class EmployeeForm
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
            office = new Label();
            comboBox1 = new ComboBox();
            txtex = new TextBox();
            txtExt = new Label();
            dataGridView1 = new DataGridView();
            txtJ = new TextBox();
            txtln = new TextBox();
            id = new TextBox();
            txtEm = new TextBox();
            bnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtEmail = new Label();
            ProductDescription = new Label();
            txtfn = new TextBox();
            txtJob = new Label();
            txtlastname = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // office
            // 
            office.AutoSize = true;
            office.Font = new Font("Century", 10.8F);
            office.ForeColor = SystemColors.ControlDarkDark;
            office.Location = new Point(27, 309);
            office.Name = "office";
            office.Size = new Size(54, 22);
            office.TabIndex = 49;
            office.Text = "office";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 346);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(269, 28);
            comboBox1.TabIndex = 48;
            // 
            // txtex
            // 
            txtex.Location = new Point(384, 260);
            txtex.Margin = new Padding(5);
            txtex.Name = "txtex";
            txtex.Size = new Size(269, 27);
            txtex.TabIndex = 45;
            // 
            // txtExt
            // 
            txtExt.AutoSize = true;
            txtExt.Font = new Font("Century", 10.8F);
            txtExt.ForeColor = SystemColors.ControlDarkDark;
            txtExt.Location = new Point(387, 232);
            txtExt.Name = "txtExt";
            txtExt.Size = new Size(93, 22);
            txtExt.TabIndex = 44;
            txtExt.Text = "Extention";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 404);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1026, 236);
            dataGridView1.TabIndex = 43;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // txtJ
            // 
            txtJ.Location = new Point(27, 260);
            txtJ.Margin = new Padding(5);
            txtJ.Name = "txtJ";
            txtJ.Size = new Size(269, 27);
            txtJ.TabIndex = 42;
            // 
            // txtln
            // 
            txtln.Location = new Point(27, 181);
            txtln.Margin = new Padding(5);
            txtln.Name = "txtln";
            txtln.Size = new Size(269, 27);
            txtln.TabIndex = 41;
            // 
            // id
            // 
            id.Location = new Point(27, 106);
            id.Margin = new Padding(5);
            id.Name = "id";
            id.Size = new Size(269, 27);
            id.TabIndex = 40;
            // 
            // txtEm
            // 
            txtEm.Location = new Point(384, 181);
            txtEm.Margin = new Padding(5);
            txtEm.Name = "txtEm";
            txtEm.Size = new Size(269, 27);
            txtEm.TabIndex = 38;
            // 
            // bnDelete
            // 
            bnDelete.BackColor = SystemColors.ActiveCaption;
            bnDelete.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            bnDelete.Location = new Point(841, 329);
            bnDelete.Name = "bnDelete";
            bnDelete.Size = new Size(163, 43);
            bnDelete.TabIndex = 37;
            bnDelete.Text = "Delete";
            bnDelete.UseVisualStyleBackColor = false;
            bnDelete.Click += bnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnEdit.Location = new Point(841, 217);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(163, 43);
            btnEdit.TabIndex = 36;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnAdd.Location = new Point(841, 106);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(163, 43);
            btnAdd.TabIndex = 35;
            btnAdd.Text = "Add Employee";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Font = new Font("Century", 10.8F);
            txtEmail.ForeColor = SystemColors.ControlDarkDark;
            txtEmail.Location = new Point(387, 153);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(61, 22);
            txtEmail.TabIndex = 33;
            txtEmail.Text = "Email";
            // 
            // ProductDescription
            // 
            ProductDescription.AutoSize = true;
            ProductDescription.Font = new Font("Century", 10.8F);
            ProductDescription.ForeColor = SystemColors.ControlDarkDark;
            ProductDescription.Location = new Point(390, 70);
            ProductDescription.Name = "ProductDescription";
            ProductDescription.Size = new Size(101, 22);
            ProductDescription.TabIndex = 32;
            ProductDescription.Text = "FirstName";
            // 
            // txtfn
            // 
            txtfn.Location = new Point(387, 106);
            txtfn.Margin = new Padding(5);
            txtfn.Name = "txtfn";
            txtfn.Size = new Size(269, 27);
            txtfn.TabIndex = 31;
            // 
            // txtJob
            // 
            txtJob.AutoSize = true;
            txtJob.Font = new Font("Century", 10.8F);
            txtJob.ForeColor = SystemColors.ControlDarkDark;
            txtJob.Location = new Point(27, 232);
            txtJob.Name = "txtJob";
            txtJob.Size = new Size(79, 22);
            txtJob.TabIndex = 30;
            txtJob.Text = "JobTitle";
            // 
            // txtlastname
            // 
            txtlastname.AutoSize = true;
            txtlastname.Font = new Font("Century", 10.8F);
            txtlastname.ForeColor = SystemColors.ControlDarkDark;
            txtlastname.Location = new Point(27, 153);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(97, 22);
            txtlastname.TabIndex = 29;
            txtlastname.Text = "LastName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10.8F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(27, 70);
            label2.Name = "label2";
            label2.Size = new Size(128, 22);
            label2.TabIndex = 28;
            label2.Text = "Employee ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 10.8F);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(378, 309);
            label1.Name = "label1";
            label1.Size = new Size(85, 22);
            label1.TabIndex = 51;
            label1.Text = "Manager";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(378, 344);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(269, 28);
            comboBox2.TabIndex = 50;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 640);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(office);
            Controls.Add(comboBox1);
            Controls.Add(txtex);
            Controls.Add(txtExt);
            Controls.Add(dataGridView1);
            Controls.Add(txtJ);
            Controls.Add(txtln);
            Controls.Add(id);
            Controls.Add(txtEm);
            Controls.Add(bnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(ProductDescription);
            Controls.Add(txtfn);
            Controls.Add(txtJob);
            Controls.Add(txtlastname);
            Controls.Add(label2);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label office;
        private ComboBox comboBox1;
        private TextBox txtex;
        private Label txtExt;
        private DataGridView dataGridView1;
        private TextBox txtJ;
        private TextBox txtln;
        private TextBox id;
        private TextBox txtEm;
        private Button bnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label txtEmail;
        private Label ProductDescription;
        private TextBox txtfn;
        private Label txtJob;
        private Label txtlastname;
        private Label label2;
        private Label label1;
        private ComboBox comboBox2;
    }
}