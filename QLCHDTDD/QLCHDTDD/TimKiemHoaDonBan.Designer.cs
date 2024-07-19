namespace QLCHDTDD
{
    partial class TimKiemHoaDonBan
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
            Exit = new Button();
            Search = new Button();
            MaHD = new TextBox();
            label2 = new Label();
            dgvTimKiemHoaDonBan = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimKiemHoaDonBan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(480, 49);
            label1.Name = "label1";
            label1.Size = new Size(239, 22);
            label1.TabIndex = 0;
            label1.Text = "TÌM KIẾM HÓA ĐƠN BÁN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Exit);
            groupBox1.Controls.Add(Search);
            groupBox1.Controls.Add(MaHD);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(197, 168);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(788, 134);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // Exit
            // 
            Exit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Exit.Location = new Point(617, 90);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 3;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Search
            // 
            Search.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Search.Location = new Point(481, 90);
            Search.Name = "Search";
            Search.Size = new Size(106, 29);
            Search.TabIndex = 2;
            Search.Text = "Tìm Kiếm";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // MaHD
            // 
            MaHD.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MaHD.Location = new Point(345, 35);
            MaHD.Name = "MaHD";
            MaHD.Size = new Size(125, 30);
            MaHD.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(185, 38);
            label2.Name = "label2";
            label2.Size = new Size(154, 22);
            label2.TabIndex = 0;
            label2.Text = "Nhập mã hóa đơn:";
            // 
            // dgvTimKiemHoaDonBan
            // 
            dgvTimKiemHoaDonBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTimKiemHoaDonBan.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvTimKiemHoaDonBan.Location = new Point(197, 325);
            dgvTimKiemHoaDonBan.Name = "dgvTimKiemHoaDonBan";
            dgvTimKiemHoaDonBan.ReadOnly = true;
            dgvTimKiemHoaDonBan.RowHeadersWidth = 51;
            dgvTimKiemHoaDonBan.RowTemplate.Height = 29;
            dgvTimKiemHoaDonBan.Size = new Size(788, 215);
            dgvTimKiemHoaDonBan.TabIndex = 2;
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
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "NgayBan";
            Column3.HeaderText = "Ngày bán";
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
            Column5.DataPropertyName = "MaNV";
            Column5.HeaderText = "Mã nhân viên";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "ThanhTien";
            Column6.HeaderText = "Thành tiền";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // TimKiemHoaDonBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1158, 626);
            Controls.Add(dgvTimKiemHoaDonBan);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "TimKiemHoaDonBan";
            Text = "TimKiemHoaDonBan";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimKiemHoaDonBan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvTimKiemHoaDonBan;
        private TextBox MaHD;
        private Label label2;
        private Button Exit;
        private Button Search;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}