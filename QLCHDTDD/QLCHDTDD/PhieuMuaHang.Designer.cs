namespace QLCHDTDD
{
    partial class PhieuMuaHang
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
            Ngay = new DateTimePicker();
            label6 = new Label();
            TenNhaCungCap = new TextBox();
            label5 = new Label();
            SoPhieuMua = new TextBox();
            label4 = new Label();
            TenNV = new TextBox();
            label3 = new Label();
            label2 = new Label();
            MaNV = new ComboBox();
            dgvPhieuMuaHang = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Add = new Button();
            Change = new Button();
            Del = new Button();
            Save = new Button();
            Skip = new Button();
            Exit = new Button();
            ChiTietPhieuMuaHang = new Button();
            ThanhToan = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuaHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(532, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 22);
            label1.TabIndex = 0;
            label1.Text = "PHIẾU MUA HÀNG";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Ngay);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TenNhaCungCap);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(SoPhieuMua);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TenNV);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(MaNV);
            groupBox1.Location = new Point(208, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 183);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // Ngay
            // 
            Ngay.Format = DateTimePickerFormat.Short;
            Ngay.Location = new Point(573, 82);
            Ngay.Name = "Ngay";
            Ngay.Size = new Size(145, 27);
            Ngay.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(473, 86);
            label6.Name = "label6";
            label6.Size = new Size(94, 22);
            label6.TabIndex = 8;
            label6.Text = "Ngày mua:";
            // 
            // TenNhaCungCap
            // 
            TenNhaCungCap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TenNhaCungCap.Location = new Point(573, 31);
            TenNhaCungCap.Name = "TenNhaCungCap";
            TenNhaCungCap.Size = new Size(145, 30);
            TenNhaCungCap.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(415, 34);
            label5.Name = "label5";
            label5.Size = new Size(152, 22);
            label5.TabIndex = 6;
            label5.Text = "Tên nhà cung cấp:";
            // 
            // SoPhieuMua
            // 
            SoPhieuMua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SoPhieuMua.Location = new Point(205, 31);
            SoPhieuMua.Name = "SoPhieuMua";
            SoPhieuMua.Size = new Size(151, 30);
            SoPhieuMua.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(77, 34);
            label4.Name = "label4";
            label4.Size = new Size(122, 22);
            label4.TabIndex = 4;
            label4.Text = "Số phiếu mua:";
            // 
            // TenNV
            // 
            TenNV.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TenNV.Location = new Point(205, 137);
            TenNV.Name = "TenNV";
            TenNV.Size = new Size(151, 30);
            TenNV.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(73, 140);
            label3.Name = "label3";
            label3.Size = new Size(126, 22);
            label3.TabIndex = 2;
            label3.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(77, 87);
            label2.Name = "label2";
            label2.Size = new Size(122, 22);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên:";
            // 
            // MaNV
            // 
            MaNV.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MaNV.FormattingEnabled = true;
            MaNV.Location = new Point(205, 83);
            MaNV.Name = "MaNV";
            MaNV.Size = new Size(151, 30);
            MaNV.TabIndex = 0;
            MaNV.SelectedIndexChanged += MaNV_SelectedIndexChanged_1;
            // 
            // dgvPhieuMuaHang
            // 
            dgvPhieuMuaHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuMuaHang.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvPhieuMuaHang.Location = new Point(257, 271);
            dgvPhieuMuaHang.Name = "dgvPhieuMuaHang";
            dgvPhieuMuaHang.ReadOnly = true;
            dgvPhieuMuaHang.RowHeadersWidth = 51;
            dgvPhieuMuaHang.RowTemplate.Height = 29;
            dgvPhieuMuaHang.Size = new Size(698, 214);
            dgvPhieuMuaHang.TabIndex = 2;
            dgvPhieuMuaHang.CellClick += dgvPhieuMuaHang_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "SoPhieuMua";
            Column1.HeaderText = "Số phiếu mua";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "MaNV";
            Column2.HeaderText = "Mã nhân viên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "HoTen";
            Column3.HeaderText = "Tên nhân viên";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "TenNhaCungCap";
            Column4.HeaderText = "Tên nhà cung cấp";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Ngay";
            Column5.HeaderText = "Ngày mua";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Add
            // 
            Add.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Add.Location = new Point(257, 572);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 3;
            Add.Text = "Thêm";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Change
            // 
            Change.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Change.Location = new Point(368, 572);
            Change.Name = "Change";
            Change.Size = new Size(94, 29);
            Change.TabIndex = 4;
            Change.Text = "Sửa";
            Change.UseVisualStyleBackColor = true;
            Change.Click += Change_Click;
            // 
            // Del
            // 
            Del.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Del.Location = new Point(484, 572);
            Del.Name = "Del";
            Del.Size = new Size(94, 29);
            Del.TabIndex = 5;
            Del.Text = "Xóa";
            Del.UseVisualStyleBackColor = true;
            Del.Click += Del_Click;
            // 
            // Save
            // 
            Save.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Save.Location = new Point(602, 572);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 6;
            Save.Text = "Lưu";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Skip
            // 
            Skip.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Skip.Location = new Point(748, 572);
            Skip.Name = "Skip";
            Skip.Size = new Size(94, 29);
            Skip.TabIndex = 7;
            Skip.Text = "Bỏ Qua";
            Skip.UseVisualStyleBackColor = true;
            Skip.Click += Skip_Click;
            // 
            // Exit
            // 
            Exit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Exit.Location = new Point(861, 572);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 8;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // ChiTietPhieuMuaHang
            // 
            ChiTietPhieuMuaHang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ChiTietPhieuMuaHang.Location = new Point(748, 508);
            ChiTietPhieuMuaHang.Name = "ChiTietPhieuMuaHang";
            ChiTietPhieuMuaHang.Size = new Size(207, 29);
            ChiTietPhieuMuaHang.TabIndex = 9;
            ChiTietPhieuMuaHang.Text = "Xem chi tiết";
            ChiTietPhieuMuaHang.UseVisualStyleBackColor = true;
            ChiTietPhieuMuaHang.Click += ChiTietPhieuMuaHang_Click;
            // 
            // ThanhToan
            // 
            ThanhToan.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ThanhToan.Location = new Point(261, 508);
            ThanhToan.Name = "ThanhToan";
            ThanhToan.Size = new Size(144, 29);
            ThanhToan.TabIndex = 10;
            ThanhToan.Text = "Thanh toán";
            ThanhToan.UseVisualStyleBackColor = true;
            ThanhToan.Click += ThanhToan_Click;
            // 
            // PhieuMuaHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1158, 626);
            Controls.Add(ThanhToan);
            Controls.Add(ChiTietPhieuMuaHang);
            Controls.Add(Exit);
            Controls.Add(Skip);
            Controls.Add(Save);
            Controls.Add(Del);
            Controls.Add(Change);
            Controls.Add(Add);
            Controls.Add(dgvPhieuMuaHang);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "PhieuMuaHang";
            Text = "PhieuMuaHang";
            Load += PhieuMuaHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuaHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox TenNV;
        private Label label3;
        private Label label2;
        private ComboBox MaNV;
        private DataGridView dgvPhieuMuaHang;
        private DateTimePicker Ngay;
        private Label label6;
        private TextBox TenNhaCungCap;
        private Label label5;
        private TextBox SoPhieuMua;
        private Label label4;
        private Button Add;
        private Button Change;
        private Button Del;
        private Button Save;
        private Button Skip;
        private Button Exit;
        private Button ChiTietPhieuMuaHang;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button ThanhToan;
    }
}