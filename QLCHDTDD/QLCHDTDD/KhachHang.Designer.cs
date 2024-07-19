namespace QLCHDTDD
{
    partial class KhachHang
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtGhiChu = new TextBox();
            txtSDT = new TextBox();
            txtCCCD = new TextBox();
            txtDiaChi = new TextBox();
            txtHoTen = new TextBox();
            txtMaKH = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvKhachHang = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Add = new Button();
            Fix = new Button();
            Del = new Button();
            Save = new Button();
            Skip = new Button();
            Exit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(458, 9);
            label1.Name = "label1";
            label1.Size = new Size(249, 22);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC KHÁCH HÀNG";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtCCCD);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(156, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 179);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGhiChu.Location = new Point(590, 109);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(177, 30);
            txtGhiChu.TabIndex = 11;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDT.Location = new Point(590, 69);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(177, 30);
            txtSDT.TabIndex = 10;
            // 
            // txtCCCD
            // 
            txtCCCD.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCCCD.Location = new Point(590, 26);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(177, 30);
            txtCCCD.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(179, 112);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(204, 30);
            txtDiaChi.TabIndex = 8;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoTen.Location = new Point(179, 66);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(204, 30);
            txtHoTen.TabIndex = 7;
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKH.Location = new Point(179, 22);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(162, 30);
            txtMaKH.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(506, 114);
            label7.Name = "label7";
            label7.Size = new Size(78, 22);
            label7.TabIndex = 5;
            label7.Text = "Ghi chú:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(464, 71);
            label6.Name = "label6";
            label6.Size = new Size(120, 22);
            label6.TabIndex = 4;
            label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(417, 31);
            label5.Name = "label5";
            label5.Size = new Size(167, 22);
            label5.TabIndex = 3;
            label5.Text = "Căn cước công dân:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(99, 114);
            label4.Name = "label4";
            label4.Size = new Size(74, 22);
            label4.TabIndex = 2;
            label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(105, 71);
            label3.Name = "label3";
            label3.Size = new Size(68, 22);
            label3.TabIndex = 1;
            label3.Text = "Họ tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 27);
            label2.Name = "label2";
            label2.Size = new Size(133, 22);
            label2.TabIndex = 0;
            label2.Text = "Mã khách hàng:";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvKhachHang.Location = new Point(156, 259);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.RowTemplate.Height = 29;
            dgvKhachHang.Size = new Size(803, 268);
            dgvKhachHang.TabIndex = 2;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaKH";
            Column1.HeaderText = "Mã khách hàng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "HoTenKH";
            Column2.HeaderText = "Họ tên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "DiaChi";
            Column3.HeaderText = "Địa chỉ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "CCCD";
            Column4.HeaderText = "Căn cước công dân";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "SoDienThoai";
            Column5.HeaderText = "Số điện thoại";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "GhiChu";
            Column6.HeaderText = "Ghi chú";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Add
            // 
            Add.Location = new Point(156, 569);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 3;
            Add.Text = "Thêm";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Fix
            // 
            Fix.Location = new Point(276, 569);
            Fix.Name = "Fix";
            Fix.Size = new Size(94, 29);
            Fix.TabIndex = 4;
            Fix.Text = "Sửa";
            Fix.UseVisualStyleBackColor = true;
            Fix.Click += Fix_Click;
            // 
            // Del
            // 
            Del.Location = new Point(393, 569);
            Del.Name = "Del";
            Del.Size = new Size(94, 29);
            Del.TabIndex = 5;
            Del.Text = "Xóa";
            Del.UseVisualStyleBackColor = true;
            Del.Click += Del_Click;
            // 
            // Save
            // 
            Save.Location = new Point(516, 569);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 6;
            Save.Text = "Lưu";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Skip
            // 
            Skip.Location = new Point(746, 569);
            Skip.Name = "Skip";
            Skip.Size = new Size(94, 29);
            Skip.TabIndex = 7;
            Skip.Text = "Bỏ Qua";
            Skip.UseVisualStyleBackColor = true;
            Skip.Click += Skip_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(865, 569);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 8;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // KhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1158, 626);
            Controls.Add(Exit);
            Controls.Add(Skip);
            Controls.Add(Save);
            Controls.Add(Del);
            Controls.Add(Fix);
            Controls.Add(Add);
            Controls.Add(dgvKhachHang);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "KhachHang";
            Text = "KhachHang";
            Load += KhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtHoTen;
        private TextBox txtMaKH;
        private TextBox txtDiaChi;
        private TextBox txtGhiChu;
        private TextBox txtSDT;
        private TextBox txtCCCD;
        private DataGridView dgvKhachHang;
        private Button Add;
        private Button Fix;
        private Button Del;
        private Button Save;
        private Button Skip;
        private Button Exit;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}