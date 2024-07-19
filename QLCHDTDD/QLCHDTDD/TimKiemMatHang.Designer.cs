namespace QLCHDTDD
{
    partial class TimKiemMatHang
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
            MaMH = new TextBox();
            label2 = new Label();
            dgvTimkiemmathang = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimkiemmathang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(470, 40);
            label1.Name = "label1";
            label1.Size = new Size(209, 22);
            label1.TabIndex = 0;
            label1.Text = "TÌM KIẾM MẶT HÀNG";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Exit);
            groupBox1.Controls.Add(Search);
            groupBox1.Controls.Add(MaMH);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(191, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(801, 144);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // Exit
            // 
            Exit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Exit.Location = new Point(620, 109);
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
            Search.Location = new Point(471, 109);
            Search.Name = "Search";
            Search.Size = new Size(126, 29);
            Search.TabIndex = 2;
            Search.Text = "Tìm Kiếm";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // MaMH
            // 
            MaMH.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MaMH.Location = new Point(384, 44);
            MaMH.Name = "MaMH";
            MaMH.Size = new Size(125, 30);
            MaMH.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(218, 47);
            label2.Name = "label2";
            label2.Size = new Size(160, 22);
            label2.TabIndex = 0;
            label2.Text = "Nhập mã mặt hàng:";
            // 
            // dgvTimkiemmathang
            // 
            dgvTimkiemmathang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTimkiemmathang.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvTimkiemmathang.Location = new Point(191, 320);
            dgvTimkiemmathang.Name = "dgvTimkiemmathang";
            dgvTimkiemmathang.ReadOnly = true;
            dgvTimkiemmathang.RowHeadersWidth = 51;
            dgvTimkiemmathang.RowTemplate.Height = 29;
            dgvTimkiemmathang.Size = new Size(801, 233);
            dgvTimkiemmathang.TabIndex = 2;
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
            Column4.DataPropertyName = "DonGiaBan";
            Column4.HeaderText = "Đơn giá bán";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "MauSac";
            Column5.HeaderText = "Màu sắc";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "SoLuongTonKho";
            Column6.HeaderText = "Số lượng tồn kho";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // TimKiemMatHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1158, 626);
            Controls.Add(dgvTimkiemmathang);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "TimKiemMatHang";
            Text = "TimKiemMatHang";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimkiemmathang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox MaMH;
        private Label label2;
        private Button Exit;
        private Button Search;
        private DataGridView dgvTimkiemmathang;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}