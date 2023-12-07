namespace Student_Management
{
    partial class Login
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
            label2 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            label3 = new Label();
            btn_login = new Button();
            panel1 = new Panel();
            btnCancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(118, 157);
            label1.Name = "label1";
            label1.Size = new Size(114, 24);
            label1.TabIndex = 0;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(118, 253);
            label2.Name = "label2";
            label2.Size = new Size(113, 24);
            label2.TabIndex = 1;
            label2.Text = "password";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txt_username.Location = new Point(277, 154);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(207, 38);
            txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txt_password.Location = new Point(277, 253);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(207, 38);
            txt_password.TabIndex = 3;
            txt_password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter Medium", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(178, 27);
            label3.Name = "label3";
            label3.Size = new Size(283, 49);
            label3.TabIndex = 4;
            label3.Text = "LOGIN FORM";
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.Location = new Point(323, 342);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(138, 51);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btn_login);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(623, 580);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Black;
            btnCancel.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(160, 342);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(138, 51);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 580);
            Controls.Add(label3);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Enter += button1_Click;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label label3;
        private Button btn_login;
        private Panel panel1;
        private Button btnCancel;
    }
}
