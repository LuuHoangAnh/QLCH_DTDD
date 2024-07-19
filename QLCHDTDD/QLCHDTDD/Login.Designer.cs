namespace QLCHDTDD
{
    partial class Login
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
            label2 = new Label();
            LoginAcount = new Button();
            ExitAcount = new Button();
            TenDN = new TextBox();
            MK = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(178, 103);
            label1.Name = "label1";
            label1.Size = new Size(130, 22);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(220, 171);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // LoginAcount
            // 
            LoginAcount.Location = new Point(231, 227);
            LoginAcount.Name = "LoginAcount";
            LoginAcount.Size = new Size(94, 29);
            LoginAcount.TabIndex = 2;
            LoginAcount.Text = "Đăng nhập";
            LoginAcount.UseVisualStyleBackColor = true;
            LoginAcount.Click += LoginAcount_Click;
            // 
            // ExitAcount
            // 
            ExitAcount.Location = new Point(397, 227);
            ExitAcount.Name = "ExitAcount";
            ExitAcount.Size = new Size(94, 29);
            ExitAcount.TabIndex = 3;
            ExitAcount.Text = "Thoát";
            ExitAcount.UseVisualStyleBackColor = true;
            // 
            // TenDN
            // 
            TenDN.Location = new Point(314, 103);
            TenDN.Name = "TenDN";
            TenDN.Size = new Size(208, 27);
            TenDN.TabIndex = 4;
            // 
            // MK
            // 
            MK.Location = new Point(314, 166);
            MK.Name = "MK";
            MK.PasswordChar = '*';
            MK.Size = new Size(208, 27);
            MK.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(MK);
            Controls.Add(TenDN);
            Controls.Add(ExitAcount);
            Controls.Add(LoginAcount);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Login";
            Text = "Đăng nhập hệ thống";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button LoginAcount;
        private Button ExitAcount;
        private TextBox TenDN;
        private TextBox MK;
    }
}