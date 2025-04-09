
namespace EF_final_Project
{
    partial class ProductLineForm
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
            textimg = new TextBox();
            txtimg = new Label();
            txth = new TextBox();
            txthtml = new Label();
            txtdesc = new TextBox();
            bnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtDes = new Label();
            dataGridView1 = new DataGridView();
            txtID = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textimg
            // 
            textimg.Location = new Point(430, 258);
            textimg.Margin = new Padding(5);
            textimg.Name = "textimg";
            textimg.Size = new Size(269, 27);
            textimg.TabIndex = 36;
            // 
            // txtimg
            // 
            txtimg.AutoSize = true;
            txtimg.Font = new Font("Century", 10.8F);
            txtimg.ForeColor = SystemColors.ControlDarkDark;
            txtimg.Location = new Point(433, 230);
            txtimg.Name = "txtimg";
            txtimg.Size = new Size(143, 22);
            txtimg.TabIndex = 35;
            txtimg.Text = "Category Image";
            // 
            // txth
            // 
            txth.Location = new Point(66, 258);
            txth.Margin = new Padding(5);
            txth.Name = "txth";
            txth.Size = new Size(269, 27);
            txth.TabIndex = 34;
            // 
            // txthtml
            // 
            txthtml.AutoSize = true;
            txthtml.Font = new Font("Century", 10.8F);
            txthtml.ForeColor = SystemColors.ControlDarkDark;
            txthtml.Location = new Point(69, 230);
            txthtml.Name = "txthtml";
            txthtml.Size = new Size(147, 22);
            txthtml.TabIndex = 33;
            txthtml.Text = "Category HTML";
            // 
            // txtdesc
            // 
            txtdesc.Location = new Point(430, 147);
            txtdesc.Margin = new Padding(5);
            txtdesc.Name = "txtdesc";
            txtdesc.Size = new Size(269, 27);
            txtdesc.TabIndex = 32;
            // 
            // bnDelete
            // 
            bnDelete.BackColor = SystemColors.ActiveCaption;
            bnDelete.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            bnDelete.Location = new Point(818, 264);
            bnDelete.Name = "bnDelete";
            bnDelete.Size = new Size(146, 42);
            bnDelete.TabIndex = 31;
            bnDelete.Text = "Delete";
            bnDelete.UseVisualStyleBackColor = false;
            bnDelete.Click += bnDelete_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnEdit.Location = new Point(818, 175);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(146, 42);
            btnEdit.TabIndex = 30;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnAdd.Location = new Point(818, 87);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 42);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // txtDes
            // 
            txtDes.AutoSize = true;
            txtDes.Font = new Font("Century", 10.8F);
            txtDes.ForeColor = SystemColors.ControlDarkDark;
            txtDes.Location = new Point(433, 119);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(187, 22);
            txtDes.TabIndex = 28;
            txtDes.Text = "Category Description";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = SystemColors.GrayText;
            dataGridView1.Location = new Point(0, 341);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 100;
            dataGridView1.Size = new Size(1076, 243);
            dataGridView1.TabIndex = 37;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick_2;
            // 
            // txtID
            // 
            txtID.Location = new Point(69, 147);
            txtID.Margin = new Padding(5);
            txtID.Name = "txtID";
            txtID.Size = new Size(269, 27);
            txtID.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 10.8F);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(72, 119);
            label1.Name = "label1";
            label1.Size = new Size(112, 22);
            label1.TabIndex = 38;
            label1.Text = "Category ID";
            // 
            // ProductLineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 584);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textimg);
            Controls.Add(txtimg);
            Controls.Add(txth);
            Controls.Add(txthtml);
            Controls.Add(txtdesc);
            Controls.Add(bnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtDes);
            Name = "ProductLineForm";
            Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox textimg;
        private Label txtimg;
        private TextBox txth;
        private Label txthtml;
        private TextBox txtdesc;
        private Button bnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label txtDes;
        private DataGridView dataGridView1;
        private TextBox txtID;
        private Label label1;
    }
}