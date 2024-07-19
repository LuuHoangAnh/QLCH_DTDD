namespace QLCHDTDD
{
    partial class HoaDonBan
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
            label3 = new Label();
            GhiChu = new TextBox();
            TenKH = new TextBox();
            TenNV = new TextBox();
            MaDonBan = new TextBox();
            MaNV = new ComboBox();
            NgayBan = new DateTimePicker();
            label13 = new Label();
            label12 = new Label();
            MaKH = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            Skip = new Button();
            Save = new Button();
            Del = new Button();
            Change = new Button();
            Add = new Button();
            Exit = new Button();
            XemChiTiet = new Button();
            dgvHoaDonBan = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            label17 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonBan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(522, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 22);
            label1.TabIndex = 0;
            label1.Text = "HÓA ĐƠN BÁN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(GhiChu);
            groupBox1.Controls.Add(TenKH);
            groupBox1.Controls.Add(TenNV);
            groupBox1.Controls.Add(MaDonBan);
            groupBox1.Controls.Add(MaNV);
            groupBox1.Controls.Add(NgayBan);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(MaKH);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(60, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1053, 214);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(690, 34);
            label3.Name = "label3";
            label3.Size = new Size(78, 22);
            label3.TabIndex = 23;
            label3.Text = "Ghi chú:";
            // 
            // GhiChu
            // 
            GhiChu.Location = new Point(772, 31);
            GhiChu.Multiline = true;
            GhiChu.Name = "GhiChu";
            GhiChu.Size = new Size(227, 127);
            GhiChu.TabIndex = 22;
            // 
            // TenKH
            // 
            TenKH.Location = new Point(462, 133);
            TenKH.Name = "TenKH";
            TenKH.Size = new Size(181, 30);
            TenKH.TabIndex = 21;
            // 
            // TenNV
            // 
            TenNV.Location = new Point(154, 133);
            TenNV.Name = "TenNV";
            TenNV.Size = new Size(151, 30);
            TenNV.TabIndex = 20;
            // 
            // MaDonBan
            // 
            MaDonBan.Location = new Point(154, 31);
            MaDonBan.Name = "MaDonBan";
            MaDonBan.Size = new Size(151, 30);
            MaDonBan.TabIndex = 15;
            // 
            // MaNV
            // 
            MaNV.FormattingEnabled = true;
            MaNV.Location = new Point(154, 82);
            MaNV.Name = "MaNV";
            MaNV.Size = new Size(151, 30);
            MaNV.TabIndex = 13;
            MaNV.SelectedIndexChanged += MaNV_SelectedIndexChanged;
            // 
            // NgayBan
            // 
            NgayBan.Format = DateTimePickerFormat.Short;
            NgayBan.Location = new Point(462, 28);
            NgayBan.Name = "NgayBan";
            NgayBan.Size = new Size(151, 30);
            NgayBan.TabIndex = 12;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(319, 136);
            label13.Name = "label13";
            label13.Size = new Size(137, 22);
            label13.TabIndex = 8;
            label13.Text = "Tên khách hàng:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(22, 136);
            label12.Name = "label12";
            label12.Size = new Size(126, 22);
            label12.TabIndex = 7;
            label12.Text = "Tên nhân viên:";
            // 
            // MaKH
            // 
            MaKH.FormattingEnabled = true;
            MaKH.Location = new Point(462, 81);
            MaKH.Name = "MaKH";
            MaKH.Size = new Size(151, 30);
            MaKH.TabIndex = 0;
            MaKH.SelectedIndexChanged += MaKH_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(366, 34);
            label8.Name = "label8";
            label8.Size = new Size(90, 22);
            label8.TabIndex = 6;
            label8.Text = "Ngày bán:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(323, 82);
            label7.Name = "label7";
            label7.Size = new Size(133, 22);
            label7.TabIndex = 5;
            label7.Text = "Mã khách hàng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(26, 84);
            label6.Name = "label6";
            label6.Size = new Size(122, 22);
            label6.TabIndex = 4;
            label6.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 33);
            label2.Name = "label2";
            label2.Size = new Size(110, 22);
            label2.TabIndex = 0;
            label2.Text = "Mã đơn bán:";
            // 
            // Skip
            // 
            Skip.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Skip.Location = new Point(886, 585);
            Skip.Name = "Skip";
            Skip.Size = new Size(94, 29);
            Skip.TabIndex = 19;
            Skip.Text = "Bỏ Qua";
            Skip.UseVisualStyleBackColor = true;
            Skip.Click += Skip_Click;
            // 
            // Save
            // 
            Save.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Save.Location = new Point(453, 585);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 18;
            Save.Text = "Lưu";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Del
            // 
            Del.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Del.Location = new Point(322, 585);
            Del.Name = "Del";
            Del.Size = new Size(94, 29);
            Del.TabIndex = 17;
            Del.Text = "Xóa";
            Del.UseVisualStyleBackColor = true;
            Del.Click += Del_Click;
            // 
            // Change
            // 
            Change.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Change.Location = new Point(189, 585);
            Change.Name = "Change";
            Change.Size = new Size(94, 29);
            Change.TabIndex = 16;
            Change.Text = "Sửa";
            Change.UseVisualStyleBackColor = true;
            Change.Click += Change_Click;
            // 
            // Add
            // 
            Add.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Add.Location = new Point(60, 585);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 15;
            Add.Text = "Thêm";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Exit
            // 
            Exit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Exit.Location = new Point(1019, 585);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 10;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // XemChiTiet
            // 
            XemChiTiet.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            XemChiTiet.Location = new Point(959, 536);
            XemChiTiet.Name = "XemChiTiet";
            XemChiTiet.Size = new Size(154, 29);
            XemChiTiet.TabIndex = 9;
            XemChiTiet.Text = "Xem chi tiết";
            XemChiTiet.UseVisualStyleBackColor = true;
            XemChiTiet.Click += XemChiTiet_Click;
            // 
            // dgvHoaDonBan
            // 
            dgvHoaDonBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDonBan.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column8, Column7 });
            dgvHoaDonBan.Location = new Point(60, 260);
            dgvHoaDonBan.Name = "dgvHoaDonBan";
            dgvHoaDonBan.ReadOnly = true;
            dgvHoaDonBan.RowHeadersWidth = 51;
            dgvHoaDonBan.RowTemplate.Height = 29;
            dgvHoaDonBan.Size = new Size(1053, 270);
            dgvHoaDonBan.TabIndex = 2;
            dgvHoaDonBan.CellClick += dgvHoaDonBan_CellClick;
            dgvHoaDonBan.CellValueChanged += dgvHoaDonBan_CellValueChanged;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaDonBan";
            Column1.HeaderText = "Mã đơn bán";
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
            Column4.DataPropertyName = "MaKH";
            Column4.HeaderText = "Mã khách hàng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "HoTenKH";
            Column5.HeaderText = "Tên khách hàng";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "NgayBan";
            Column6.HeaderText = "Ngày bán";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "TongTien";
            Column8.HeaderText = "Thanh toán";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 125;
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
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1043, 674);
            label17.Name = "label17";
            label17.Size = new Size(0, 20);
            label17.TabIndex = 11;
            // 
            // HoaDonBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1158, 626);
            Controls.Add(Skip);
            Controls.Add(Save);
            Controls.Add(Del);
            Controls.Add(Change);
            Controls.Add(Add);
            Controls.Add(Exit);
            Controls.Add(XemChiTiet);
            Controls.Add(label17);
            Controls.Add(dgvHoaDonBan);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "HoaDonBan";
            Text = "HoaDonBan";
            Load += HoaDonBan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonBan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private DataGridView dgvHoaDonBan;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox MaKH;
        private Label label13;
        private Label label12;
        private ComboBox MaNV;
        private DateTimePicker NgayBan;
        private TextBox MaDonBan;
        private TextBox TenNV;
        private TextBox TenKH;
        private Button XemChiTiet;
        private Button Exit;
        private Label label17;
        private Button Add;
        private Button Change;
        private Button Del;
        private Button Save;
        private Button Skip;
        private Label label3;
        private TextBox GhiChu;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column7;
    }
}