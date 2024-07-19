namespace QLCHDTDD
{
    partial class ChiTietHoaDonBan
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
            MaHD = new TextBox();
            DonGia = new TextBox();
            SoLuong = new TextBox();
            TenMH = new TextBox();
            MaMH = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvCTHoaDonBan = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            TongTien = new TextBox();
            Add = new Button();
            Change = new Button();
            Del = new Button();
            Save = new Button();
            Skip = new Button();
            Exit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTHoaDonBan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(333, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 22);
            label1.TabIndex = 0;
            label1.Text = "CHI TIẾT HOÁ ĐƠN BÁN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MaHD);
            groupBox1.Controls.Add(DonGia);
            groupBox1.Controls.Add(SoLuong);
            groupBox1.Controls.Add(TenMH);
            groupBox1.Controls.Add(MaMH);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(855, 176);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // MaHD
            // 
            MaHD.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MaHD.Location = new Point(220, 37);
            MaHD.Name = "MaHD";
            MaHD.Size = new Size(97, 30);
            MaHD.TabIndex = 10;
            // 
            // DonGia
            // 
            DonGia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DonGia.Location = new Point(604, 81);
            DonGia.Name = "DonGia";
            DonGia.Size = new Size(125, 30);
            DonGia.TabIndex = 9;
            // 
            // SoLuong
            // 
            SoLuong.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SoLuong.Location = new Point(604, 39);
            SoLuong.Name = "SoLuong";
            SoLuong.Size = new Size(125, 30);
            SoLuong.TabIndex = 8;
            // 
            // TenMH
            // 
            TenMH.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TenMH.Location = new Point(220, 125);
            TenMH.Name = "TenMH";
            TenMH.Size = new Size(200, 30);
            TenMH.TabIndex = 7;
            // 
            // MaMH
            // 
            MaMH.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MaMH.FormattingEnabled = true;
            MaMH.Location = new Point(220, 81);
            MaMH.Name = "MaMH";
            MaMH.Size = new Size(97, 30);
            MaMH.TabIndex = 5;
            MaMH.SelectedIndexChanged += MaMH_SelectedIndexChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(518, 89);
            label6.Name = "label6";
            label6.Size = new Size(84, 22);
            label6.TabIndex = 4;
            label6.Text = "Đơn Giá:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(508, 43);
            label5.Name = "label5";
            label5.Size = new Size(93, 22);
            label5.TabIndex = 3;
            label5.Text = "Số Lượng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(94, 128);
            label4.Name = "label4";
            label4.Size = new Size(120, 22);
            label4.TabIndex = 2;
            label4.Text = "Tên mặt hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(98, 84);
            label3.Name = "label3";
            label3.Size = new Size(116, 22);
            label3.TabIndex = 1;
            label3.Text = "Mã mặt hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 39);
            label2.Name = "label2";
            label2.Size = new Size(110, 22);
            label2.TabIndex = 0;
            label2.Text = "Mã hóa đơn:";
            // 
            // dgvCTHoaDonBan
            // 
            dgvCTHoaDonBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTHoaDonBan.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvCTHoaDonBan.Location = new Point(12, 218);
            dgvCTHoaDonBan.Name = "dgvCTHoaDonBan";
            dgvCTHoaDonBan.ReadOnly = true;
            dgvCTHoaDonBan.RowHeadersWidth = 51;
            dgvCTHoaDonBan.RowTemplate.Height = 29;
            dgvCTHoaDonBan.Size = new Size(855, 171);
            dgvCTHoaDonBan.TabIndex = 2;
            dgvCTHoaDonBan.CellClick += dgvCTHoaDonBan_CellClick;
            dgvCTHoaDonBan.CellValueChanged += dgvCTHoaDonBan_CellValueChanged;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaDonBan";
            Column1.HeaderText = "Mã hóa đơn";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "MaMH";
            Column2.HeaderText = "Mã mặt hàng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TenMH";
            Column3.HeaderText = "Tên mặt hàng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "SoLuong";
            Column4.HeaderText = "Số lượng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "DonGiaBan";
            Column5.HeaderText = "Đơn giá";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "ThanhTien";
            Column6.HeaderText = "Thành Tiền";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(646, 400);
            label7.Name = "label7";
            label7.Size = new Size(90, 22);
            label7.TabIndex = 3;
            label7.Text = "Tổng tiền:";
            // 
            // TongTien
            // 
            TongTien.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TongTien.Location = new Point(742, 397);
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            TongTien.Size = new Size(125, 30);
            TongTien.TabIndex = 4;
            // 
            // Add
            // 
            Add.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Add.Location = new Point(12, 449);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 5;
            Add.Text = "Thêm";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Change
            // 
            Change.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Change.Location = new Point(129, 449);
            Change.Name = "Change";
            Change.Size = new Size(94, 29);
            Change.TabIndex = 6;
            Change.Text = "Sửa";
            Change.UseVisualStyleBackColor = true;
            Change.Click += Change_Click;
            // 
            // Del
            // 
            Del.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Del.Location = new Point(249, 450);
            Del.Name = "Del";
            Del.Size = new Size(94, 29);
            Del.TabIndex = 7;
            Del.Text = "Xóa";
            Del.UseVisualStyleBackColor = true;
            Del.Click += Del_Click;
            // 
            // Save
            // 
            Save.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Save.Location = new Point(366, 450);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 8;
            Save.Text = "Lưu";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Skip
            // 
            Skip.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Skip.Location = new Point(661, 449);
            Skip.Name = "Skip";
            Skip.Size = new Size(94, 29);
            Skip.TabIndex = 9;
            Skip.Text = "Bỏ qua";
            Skip.UseVisualStyleBackColor = true;
            Skip.Click += Skip_Click;
            // 
            // Exit
            // 
            Exit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Exit.Location = new Point(773, 450);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 10;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // ChiTietHoaDonBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(879, 490);
            Controls.Add(Exit);
            Controls.Add(Skip);
            Controls.Add(Save);
            Controls.Add(Del);
            Controls.Add(Change);
            Controls.Add(Add);
            Controls.Add(TongTien);
            Controls.Add(label7);
            Controls.Add(dgvCTHoaDonBan);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ChiTietHoaDonBan";
            Text = "ChiTietHoaDonBan";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTHoaDonBan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private TextBox DonGia;
        private TextBox SoLuong;
        private TextBox TenMH;
        private ComboBox MaMH;
        private DataGridView dgvCTHoaDonBan;
        private Label label7;
        private TextBox TongTien;
        private Button Add;
        private Button Change;
        private Button Del;
        private Button Save;
        private Button Skip;
        private Button Exit;
        private TextBox MaHD;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}