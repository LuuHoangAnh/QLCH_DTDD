namespace QLCHDTDD
{
    partial class ThongKe
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
            TongTien = new TextBox();
            label2 = new Label();
            dgvDoanhThu = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(485, 39);
            label1.Name = "label1";
            label1.Size = new Size(228, 22);
            label1.TabIndex = 0;
            label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TongTien);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dgvDoanhThu);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(104, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(954, 461);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thống kê doanh thu";
            // 
            // TongTien
            // 
            TongTien.Location = new Point(676, 417);
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            TongTien.Size = new Size(181, 30);
            TongTien.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(586, 420);
            label2.Name = "label2";
            label2.Size = new Size(84, 22);
            label2.TabIndex = 1;
            label2.Text = "Tổng thu:";
            // 
            // dgvDoanhThu
            // 
            dgvDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoanhThu.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column7, Column5 });
            dgvDoanhThu.Location = new Point(85, 29);
            dgvDoanhThu.Name = "dgvDoanhThu";
            dgvDoanhThu.ReadOnly = true;
            dgvDoanhThu.RowHeadersWidth = 51;
            dgvDoanhThu.RowTemplate.Height = 29;
            dgvDoanhThu.Size = new Size(805, 360);
            dgvDoanhThu.TabIndex = 0;
            dgvDoanhThu.CellValueChanged += dgvDoanhThu_CellValueChanged;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaMH";
            Column1.HeaderText = "Mã mặt hàng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenMH";
            Column2.HeaderText = "Tên mặt hàng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "HangSX";
            Column3.HeaderText = "Hãng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "SoLuong";
            Column4.HeaderText = "Số lượng bán";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "NgayBan";
            Column7.HeaderText = "Ngày bán";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "TongThu";
            Column5.HeaderText = "Tổng thu";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1158, 626);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "ThongKe";
            Text = "ThongKe";
            Load += ThongKe_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvDoanhThu;
        private TextBox TongTien;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column5;
    }
}