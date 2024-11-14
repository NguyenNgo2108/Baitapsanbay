namespace SanBay
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            tbSoGioBay = new TextBox();
            tbTenMB = new TextBox();
            tbMaMB = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnSua = new Button();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            dtpNamSX = new DateTimePicker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNamSX);
            groupBox1.Controls.Add(tbSoGioBay);
            groupBox1.Controls.Add(tbTenMB);
            groupBox1.Controls.Add(tbMaMB);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 295);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // tbSoGioBay
            // 
            tbSoGioBay.Location = new Point(119, 198);
            tbSoGioBay.Name = "tbSoGioBay";
            tbSoGioBay.Size = new Size(148, 27);
            tbSoGioBay.TabIndex = 7;
            tbSoGioBay.TextChanged += tbSoGioBay_TextChanged;
            // 
            // tbTenMB
            // 
            tbTenMB.Location = new Point(119, 90);
            tbTenMB.Name = "tbTenMB";
            tbTenMB.Size = new Size(148, 27);
            tbTenMB.TabIndex = 5;
            tbTenMB.TextChanged += tbTenMB_TextChanged;
            // 
            // tbMaMB
            // 
            tbMaMB.Location = new Point(119, 38);
            tbMaMB.Name = "tbMaMB";
            tbMaMB.Size = new Size(148, 27);
            tbMaMB.TabIndex = 4;
            tbMaMB.TextChanged += tbMaMB_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 201);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "Số giờ bay:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 143);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 2;
            label3.Text = "Năm sản xuất:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 90);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên máy bay:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã máy bay:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Location = new Point(12, 313);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(273, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(150, 35);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(14, 35);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(291, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(497, 426);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ liệu";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(508, 382);
            dataGridView1.TabIndex = 0;
            // 
            // dtpNamSX
            // 
            dtpNamSX.Location = new Point(119, 143);
            dtpNamSX.Name = "dtpNamSX";
            dtpNamSX.Size = new Size(148, 27);
            dtpNamSX.TabIndex = 8;
            dtpNamSX.ValueChanged += dtpNamSX_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox tbSoGioBay;
        private TextBox tbTenMB;
        private TextBox tbMaMB;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dataGridView1;
        private DateTimePicker dtpNamSX;
    }
}
