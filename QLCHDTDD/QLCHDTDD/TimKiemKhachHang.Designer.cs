namespace QLCHDTDD
{
    partial class TimKiemKhachHang
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
            Change = new Button();
            Search = new Button();
            MaKH = new TextBox();
            label2 = new Label();
            dgvTimKiemKhachHang = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimKiemKhachHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(448, 41);
            label1.Name = "label1";
            label1.Size = new Size(235, 22);
            label1.TabIndex = 0;
            label1.Text = "TÌM KIẾM KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Exit);
            groupBox1.Controls.Add(Change);
            groupBox1.Controls.Add(Search);
            groupBox1.Controls.Add(MaKH);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(203, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 144);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // Exit
            // 
            Exit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Exit.Location = new Point(621, 102);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 4;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Change
            // 
            Change.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Change.Location = new Point(147, 102);
            Change.Name = "Change";
            Change.Size = new Size(143, 29);
            Change.TabIndex = 3;
            Change.Text = "Sửa thông tin";
            Change.UseVisualStyleBackColor = true;
            Change.Click += Change_Click;
            // 
            // Search
            // 
            Search.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Search.Location = new Point(503, 102);
            Search.Name = "Search";
            Search.Size = new Size(94, 29);
            Search.TabIndex = 2;
            Search.Text = "Tìm kiếm";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // MaKH
            // 
            MaKH.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MaKH.Location = new Point(374, 31);
            MaKH.Name = "MaKH";
            MaKH.Size = new Size(125, 30);
            MaKH.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(191, 34);
            label2.Name = "label2";
            label2.Size = new Size(177, 22);
            label2.TabIndex = 0;
            label2.Text = "Nhập mã khách hàng:";
            // 
            // dgvTimKiemKhachHang
            // 
            dgvTimKiemKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTimKiemKhachHang.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvTimKiemKhachHang.Location = new Point(203, 333);
            dgvTimKiemKhachHang.Name = "dgvTimKiemKhachHang";
            dgvTimKiemKhachHang.ReadOnly = true;
            dgvTimKiemKhachHang.RowHeadersWidth = 51;
            dgvTimKiemKhachHang.RowTemplate.Height = 29;
            dgvTimKiemKhachHang.Size = new Size(776, 242);
            dgvTimKiemKhachHang.TabIndex = 2;
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
            Column2.HeaderText = "Tên khách hàng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "MaDonBan";
            Column3.HeaderText = "Mã hóa đơn";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "DiaChi";
            Column4.HeaderText = "Địa chỉ";
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
            Column6.DataPropertyName = "ThanhToan";
            Column6.HeaderText = "Thanh toán";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // TimKiemKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1158, 626);
            Controls.Add(dgvTimKiemKhachHang);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "TimKiemKhachHang";
            Text = "TimKiemKhachHang";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimKiemKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button Exit;
        private Button Change;
        private Button Search;
        private TextBox MaKH;
        private Label label2;
        private DataGridView dgvTimKiemKhachHang;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}