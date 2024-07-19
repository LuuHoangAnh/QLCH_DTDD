namespace QLCHDTDD
{
    partial class HoaDonMua
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
            MaNV = new ComboBox();
            GhiChu = new TextBox();
            NgayMua = new DateTimePicker();
            TenNV = new TextBox();
            SoPhieuMua = new TextBox();
            MaDonMua = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvHoaDonMua = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Change = new Button();
            Save = new Button();
            Skip = new Button();
            Exit = new Button();
            Add = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonMua).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(390, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 22);
            label1.TabIndex = 0;
            label1.Text = "HÓA ĐƠN MUA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MaNV);
            groupBox1.Controls.Add(GhiChu);
            groupBox1.Controls.Add(NgayMua);
            groupBox1.Controls.Add(TenNV);
            groupBox1.Controls.Add(SoPhieuMua);
            groupBox1.Controls.Add(MaDonMua);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(962, 164);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // MaNV
            // 
            MaNV.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MaNV.FormattingEnabled = true;
            MaNV.Location = new Point(506, 49);
            MaNV.Name = "MaNV";
            MaNV.Size = new Size(158, 30);
            MaNV.TabIndex = 12;
            MaNV.SelectedIndexChanged += MaNV_SelectedIndexChanged;
            // 
            // GhiChu
            // 
            GhiChu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GhiChu.Location = new Point(792, 106);
            GhiChu.Name = "GhiChu";
            GhiChu.Size = new Size(131, 30);
            GhiChu.TabIndex = 11;
            // 
            // NgayMua
            // 
            NgayMua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NgayMua.Format = DateTimePickerFormat.Short;
            NgayMua.Location = new Point(792, 47);
            NgayMua.Name = "NgayMua";
            NgayMua.Size = new Size(131, 30);
            NgayMua.TabIndex = 10;
            // 
            // TenNV
            // 
            TenNV.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TenNV.Location = new Point(506, 106);
            TenNV.Name = "TenNV";
            TenNV.Size = new Size(158, 30);
            TenNV.TabIndex = 8;
            // 
            // SoPhieuMua
            // 
            SoPhieuMua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SoPhieuMua.Location = new Point(196, 106);
            SoPhieuMua.Name = "SoPhieuMua";
            SoPhieuMua.Size = new Size(125, 30);
            SoPhieuMua.TabIndex = 7;
            // 
            // MaDonMua
            // 
            MaDonMua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MaDonMua.Location = new Point(196, 49);
            MaDonMua.Name = "MaDonMua";
            MaDonMua.Size = new Size(125, 30);
            MaDonMua.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(708, 108);
            label7.Name = "label7";
            label7.Size = new Size(78, 22);
            label7.TabIndex = 5;
            label7.Text = "Ghi chú:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(692, 51);
            label6.Name = "label6";
            label6.Size = new Size(94, 22);
            label6.TabIndex = 4;
            label6.Text = "Ngày mua:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(68, 108);
            label5.Name = "label5";
            label5.Size = new Size(122, 22);
            label5.TabIndex = 3;
            label5.Text = "Số phiếu mua:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(374, 108);
            label4.Name = "label4";
            label4.Size = new Size(126, 22);
            label4.TabIndex = 2;
            label4.Text = "Tên nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(378, 51);
            label3.Name = "label3";
            label3.Size = new Size(122, 22);
            label3.TabIndex = 1;
            label3.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(76, 51);
            label2.Name = "label2";
            label2.Size = new Size(114, 22);
            label2.TabIndex = 0;
            label2.Text = "Mã đơn mua:";
            // 
            // dgvHoaDonMua
            // 
            dgvHoaDonMua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDonMua.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvHoaDonMua.Location = new Point(30, 221);
            dgvHoaDonMua.Name = "dgvHoaDonMua";
            dgvHoaDonMua.ReadOnly = true;
            dgvHoaDonMua.RowHeadersWidth = 51;
            dgvHoaDonMua.RowTemplate.Height = 29;
            dgvHoaDonMua.Size = new Size(929, 216);
            dgvHoaDonMua.TabIndex = 2;
            dgvHoaDonMua.CellClick += dgvHoaDonMua_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaDonMua";
            Column1.HeaderText = "Mã đơn mua";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "SoPhieuMua";
            Column2.HeaderText = "Số phiếu mua";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "MaNV";
            Column3.HeaderText = "Mã nhân viên";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "HoTen";
            Column4.HeaderText = "Tên nhân viên";
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
            // Column6
            // 
            Column6.DataPropertyName = "TongTien";
            Column6.HeaderText = "Tổng tiền";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "GhiChu";
            Column7.HeaderText = "Ghi chú";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Change
            // 
            Change.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Change.Location = new Point(272, 468);
            Change.Name = "Change";
            Change.Size = new Size(94, 29);
            Change.TabIndex = 4;
            Change.Text = "Sửa";
            Change.UseVisualStyleBackColor = true;
            Change.Click += Change_Click;
            // 
            // Save
            // 
            Save.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Save.Location = new Point(418, 468);
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
            Skip.Location = new Point(558, 468);
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
            Exit.Location = new Point(693, 468);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 8;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Add
            // 
            Add.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Add.Location = new Point(138, 468);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 9;
            Add.Text = "Thêm";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // HoaDonMua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(986, 526);
            Controls.Add(Add);
            Controls.Add(Exit);
            Controls.Add(Skip);
            Controls.Add(Save);
            Controls.Add(Change);
            Controls.Add(dgvHoaDonMua);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "HoaDonMua";
            Text = "HoaDonMua";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonMua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox4;
        private TextBox textBox2;
        private TextBox GhiChu;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox TongTien;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private DataGridView dgvHoaDonMua;
        private DateTimePicker NgayMua;
        private TextBox TenNV;
        private TextBox SoPhieuMua;
        private TextBox MaDonMua;
        private Button Change;
        private Button Save;
        private Button Skip;
        private Button Exit;
        private Button Add;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private ComboBox MaNV;
    }
}