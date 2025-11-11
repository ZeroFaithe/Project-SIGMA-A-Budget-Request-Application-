namespace Project_SIGMA__A_Budget_Request_Application_
{
    partial class LoginForm
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            emailTxt = new TextBox();
            passwordTxt = new TextBox();
            label3 = new Label();
            registerBtn = new Button();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            loginBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AUF_CCS_Logo;
            pictureBox1.Location = new Point(66, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 281);
            label1.Name = "label1";
            label1.Size = new Size(109, 34);
            label1.TabIndex = 1;
            label1.Text = "EMAIL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 426);
            label2.Name = "label2";
            label2.Size = new Size(193, 34);
            label2.TabIndex = 2;
            label2.Text = "PASSWORD";
            // 
            // emailTxt
            // 
            emailTxt.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxt.Location = new Point(66, 328);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(444, 47);
            emailTxt.TabIndex = 3;
            // 
            // passwordTxt
            // 
            passwordTxt.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.Location = new Point(66, 473);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(444, 47);
            passwordTxt.TabIndex = 4;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(68, 639);
            label3.Name = "label3";
            label3.Size = new Size(269, 31);
            label3.TabIndex = 7;
            label3.Text = "Do not have an account?";
            // 
            // registerBtn
            // 
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = Color.DimGray;
            registerBtn.Location = new Point(331, 623);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(113, 62);
            registerBtn.TabIndex = 6;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Heavy", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 195);
            label4.Name = "label4";
            label4.Size = new Size(137, 47);
            label4.TabIndex = 7;
            label4.Text = "LOGIN";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(590, 228);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(600, 506);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.Location = new Point(66, 560);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(119, 51);
            loginBtn.TabIndex = 9;
            loginBtn.Text = "LOG IN";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 725);
            Controls.Add(loginBtn);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(registerBtn);
            Controls.Add(label3);
            Controls.Add(passwordTxt);
            Controls.Add(emailTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox emailTxt;
        private TextBox passwordTxt;
        private Label label3;
        private Button registerBtn;
        private Label label4;
        private PictureBox pictureBox2;
        private Button loginBtn;
    }
}
