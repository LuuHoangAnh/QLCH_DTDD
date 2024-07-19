namespace QLCHDTDD
{
    partial class NhanVien
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
            label1 = new Label();
            dgvNhanVien = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            NgaySinh = new DateTimePicker();
            rdbNu = new RadioButton();
            rdbNam = new RadioButton();
            SoDienThoai = new TextBox();
            DiaChi = new TextBox();
            HoTen = new TextBox();
            MaNV = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Add = new Button();
            Fix = new Button();
            Del = new Button();
            Save = new Button();
            Skip = new Button();
            Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(479, 9);
            label1.Name = "label1";
            label1.Size = new Size(260, 26);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvNhanVien.Location = new Point(194, 280);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 29;
            dgvNhanVien.Size = new Size(803, 239);
            dgvNhanVien.TabIndex = 1;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaNV";
            Column1.HeaderText = "Mã nhân viên";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "HoTen";
            Column2.HeaderText = "Họ tên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "NgaySinh";
            Column3.HeaderText = "Ngày sinh";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "GioiTinh";
            Column4.HeaderText = "Giới tính";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "DiaChi";
            Column5.HeaderText = "Địa chỉ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "SoDienThoai";
            Column6.HeaderText = "Số điện thoại";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NgaySinh);
            groupBox1.Controls.Add(rdbNu);
            groupBox1.Controls.Add(rdbNam);
            groupBox1.Controls.Add(SoDienThoai);
            groupBox1.Controls.Add(DiaChi);
            groupBox1.Controls.Add(HoTen);
            groupBox1.Controls.Add(MaNV);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(194, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 239);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // NgaySinh
            // 
            NgaySinh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NgaySinh.Format = DateTimePickerFormat.Short;
            NgaySinh.Location = new Point(307, 94);
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Size = new Size(250, 30);
            NgaySinh.TabIndex = 12;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbNu.Location = new Point(438, 128);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(56, 26);
            rdbNu.TabIndex = 11;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Checked = true;
            rdbNam.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbNam.Location = new Point(309, 128);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(68, 26);
            rdbNam.TabIndex = 10;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // SoDienThoai
            // 
            SoDienThoai.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SoDienThoai.Location = new Point(307, 206);
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.Size = new Size(187, 30);
            SoDienThoai.TabIndex = 9;
            // 
            // DiaChi
            // 
            DiaChi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DiaChi.Location = new Point(307, 168);
            DiaChi.Name = "DiaChi";
            DiaChi.Size = new Size(238, 30);
            DiaChi.TabIndex = 8;
            // 
            // HoTen
            // 
            HoTen.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HoTen.Location = new Point(309, 51);
            HoTen.Name = "HoTen";
            HoTen.Size = new Size(236, 30);
            HoTen.TabIndex = 7;
            // 
            // MaNV
            // 
            MaNV.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MaNV.Location = new Point(309, 12);
            MaNV.Name = "MaNV";
            MaNV.Size = new Size(123, 30);
            MaNV.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(183, 204);
            label7.Name = "label7";
            label7.Size = new Size(120, 22);
            label7.TabIndex = 5;
            label7.Text = "Số điện thoại:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(229, 168);
            label6.Name = "label6";
            label6.Size = new Size(74, 22);
            label6.TabIndex = 4;
            label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(216, 128);
            label5.Name = "label5";
            label5.Size = new Size(87, 22);
            label5.TabIndex = 3;
            label5.Text = "Giới tính:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(209, 94);
            label4.Name = "label4";
            label4.Size = new Size(94, 22);
            label4.TabIndex = 2;
            label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(228, 51);
            label3.Name = "label3";
            label3.Size = new Size(75, 22);
            label3.TabIndex = 1;
            label3.Text = "Họ Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(181, 12);
            label2.Name = "label2";
            label2.Size = new Size(122, 22);
            label2.TabIndex = 0;
            label2.Text = "Mã nhân viên:";
            // 
            // Add
            // 
            Add.Location = new Point(194, 567);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 3;
            Add.Text = "Thêm";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Fix
            // 
            Fix.Location = new Point(320, 567);
            Fix.Name = "Fix";
            Fix.Size = new Size(94, 29);
            Fix.TabIndex = 4;
            Fix.Text = "Sửa";
            Fix.UseVisualStyleBackColor = true;
            Fix.Click += Fix_Click;
            // 
            // Del
            // 
            Del.Location = new Point(440, 567);
            Del.Name = "Del";
            Del.Size = new Size(94, 29);
            Del.TabIndex = 5;
            Del.Text = "Xóa";
            Del.UseVisualStyleBackColor = true;
            Del.Click += Del_Click;
            // 
            // Save
            // 
            Save.Location = new Point(557, 567);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 6;
            Save.Text = "Lưu";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Skip
            // 
            Skip.Location = new Point(781, 567);
            Skip.Name = "Skip";
            Skip.Size = new Size(94, 29);
            Skip.TabIndex = 7;
            Skip.Text = "Bỏ qua";
            Skip.UseVisualStyleBackColor = true;
            Skip.Click += Skip_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(903, 567);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 8;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // NhanVien
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
            Controls.Add(groupBox1);
            Controls.Add(dgvNhanVien);
            Controls.Add(label1);
            Name = "NhanVien";
            Text = "Nhân viên";
            Load += NhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvNhanVien;
        private GroupBox groupBox1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private RadioButton rdbNu;
        private RadioButton rdbNam;
        private TextBox SoDienThoai;
        private TextBox DiaChi;
        private TextBox HoTen;
        private TextBox MaNV;
        private DateTimePicker NgaySinh;
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