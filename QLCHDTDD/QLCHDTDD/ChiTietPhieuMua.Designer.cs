namespace QLCHDTDD
{
    partial class ChiTietPhieuMua
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
            SoLuong = new TextBox();
            DonGiaMua = new TextBox();
            TenMH = new TextBox();
            MaMH = new ComboBox();
            SoPhieuMua = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvChiTietPhieuMua = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Add = new Button();
            Change = new Button();
            Del = new Button();
            Save = new Button();
            Skip = new Button();
            Exit = new Button();
            TongTien = new TextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuMua).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(305, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 22);
            label1.TabIndex = 0;
            label1.Text = "CHI TIẾT PHIẾU MUA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SoLuong);
            groupBox1.Controls.Add(DonGiaMua);
            groupBox1.Controls.Add(TenMH);
            groupBox1.Controls.Add(MaMH);
            groupBox1.Controls.Add(SoPhieuMua);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(794, 167);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // SoLuong
            // 
            SoLuong.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SoLuong.Location = new Point(569, 69);
            SoLuong.Name = "SoLuong";
            SoLuong.Size = new Size(132, 30);
            SoLuong.TabIndex = 9;
            // 
            // DonGiaMua
            // 
            DonGiaMua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DonGiaMua.Location = new Point(569, 21);
            DonGiaMua.Name = "DonGiaMua";
            DonGiaMua.Size = new Size(132, 30);
            DonGiaMua.TabIndex = 8;
            // 
            // TenMH
            // 
            TenMH.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TenMH.Location = new Point(214, 117);
            TenMH.Name = "TenMH";
            TenMH.Size = new Size(143, 30);
            TenMH.TabIndex = 7;
            // 
            // MaMH
            // 
            MaMH.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MaMH.FormattingEnabled = true;
            MaMH.Location = new Point(214, 69);
            MaMH.Name = "MaMH";
            MaMH.Size = new Size(125, 30);
            MaMH.TabIndex = 6;
            MaMH.SelectedIndexChanged += MaMH_SelectedIndexChanged;
            // 
            // SoPhieuMua
            // 
            SoPhieuMua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SoPhieuMua.Location = new Point(214, 21);
            SoPhieuMua.Name = "SoPhieuMua";
            SoPhieuMua.Size = new Size(125, 30);
            SoPhieuMua.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(475, 71);
            label6.Name = "label6";
            label6.Size = new Size(88, 22);
            label6.TabIndex = 4;
            label6.Text = "Số lượng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(447, 23);
            label5.Name = "label5";
            label5.Size = new Size(116, 22);
            label5.TabIndex = 3;
            label5.Text = "Đơn giá mua:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(88, 119);
            label4.Name = "label4";
            label4.Size = new Size(120, 22);
            label4.TabIndex = 2;
            label4.Text = "Tên mặt hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(92, 71);
            label3.Name = "label3";
            label3.Size = new Size(116, 22);
            label3.TabIndex = 1;
            label3.Text = "Mã mặt hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(86, 23);
            label2.Name = "label2";
            label2.Size = new Size(122, 22);
            label2.TabIndex = 0;
            label2.Text = "Số phiếu mua:";
            // 
            // dgvChiTietPhieuMua
            // 
            dgvChiTietPhieuMua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietPhieuMua.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvChiTietPhieuMua.Location = new Point(12, 217);
            dgvChiTietPhieuMua.Name = "dgvChiTietPhieuMua";
            dgvChiTietPhieuMua.ReadOnly = true;
            dgvChiTietPhieuMua.RowHeadersWidth = 51;
            dgvChiTietPhieuMua.RowTemplate.Height = 29;
            dgvChiTietPhieuMua.Size = new Size(795, 246);
            dgvChiTietPhieuMua.TabIndex = 2;
            dgvChiTietPhieuMua.CellClick += dgvChiTietPhieuMua_CellClick;
            dgvChiTietPhieuMua.CellValueChanged += dgvChiTietPhieuMua_CellValueChanged;
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
            Column2.DataPropertyName = "MaMH";
            Column2.HeaderText = "Mã mặt hàng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TenMH";
            Column3.HeaderText = "Tên mặt hàng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "DonGiaMua";
            Column4.HeaderText = "Đơn giá mua";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "SoLuong";
            Column5.HeaderText = "Số lượng";
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
            // Add
            // 
            Add.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Add.Location = new Point(12, 514);
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
            Change.Location = new Point(126, 514);
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
            Del.Location = new Point(242, 514);
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
            Save.Location = new Point(358, 514);
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
            Skip.Location = new Point(597, 514);
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
            Exit.Location = new Point(712, 514);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 8;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // TongTien
            // 
            TongTien.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TongTien.Location = new Point(681, 469);
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            TongTien.Size = new Size(125, 30);
            TongTien.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(585, 472);
            label7.Name = "label7";
            label7.Size = new Size(90, 22);
            label7.TabIndex = 10;
            label7.Text = "Tổng tiền:";
            // 
            // ChiTietPhieuMua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(818, 555);
            Controls.Add(label7);
            Controls.Add(TongTien);
            Controls.Add(Exit);
            Controls.Add(Skip);
            Controls.Add(Save);
            Controls.Add(Del);
            Controls.Add(Change);
            Controls.Add(Add);
            Controls.Add(dgvChiTietPhieuMua);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ChiTietPhieuMua";
            Text = "ChiTietPhieuMua";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuMua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox SoLuong;
        private TextBox DonGiaMua;
        private TextBox TenMH;
        private ComboBox MaMH;
        private TextBox SoPhieuMua;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgvChiTietPhieuMua;
        private Button Add;
        private Button Change;
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
        private TextBox TongTien;
        private Label label7;
    }
}