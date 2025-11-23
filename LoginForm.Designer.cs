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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            emailTxt = new TextBox();
            passwordTxt = new TextBox();
            label3 = new Label();
            registerBtn = new Button();
            label4 = new Label();
            loginBtn = new Button();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CCS_LOGO_White;
            pictureBox1.Location = new Point(82, 35);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(82, 351);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 43);
            label1.TabIndex = 1;
            label1.Text = "EMAIL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(82, 532);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(212, 43);
            label2.TabIndex = 2;
            label2.Text = "PASSWORD";
            // 
            // emailTxt
            // 
            emailTxt.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxt.Location = new Point(82, 410);
            emailTxt.Margin = new Padding(4);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(554, 52);
            emailTxt.TabIndex = 3;
            emailTxt.KeyDown += loginBtn_KeyDown;
            // 
            // passwordTxt
            // 
            passwordTxt.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.Location = new Point(82, 591);
            passwordTxt.Margin = new Padding(4);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(554, 55);
            passwordTxt.TabIndex = 4;
            passwordTxt.UseSystemPasswordChar = true;
            passwordTxt.KeyDown += loginBtn_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(85, 799);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(331, 38);
            label3.TabIndex = 7;
            label3.Text = "Do not have an account?";
            // 
            // registerBtn
            // 
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = Color.WhiteSmoke;
            registerBtn.Location = new Point(414, 779);
            registerBtn.Margin = new Padding(4);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(141, 78);
            registerBtn.TabIndex = 6;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Heavy", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(82, 244);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(167, 61);
            label4.TabIndex = 7;
            label4.Text = "LOGIN";
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.Location = new Point(82, 700);
            loginBtn.Margin = new Padding(4);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(149, 64);
            loginBtn.TabIndex = 9;
            loginBtn.Text = "LOG IN";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 26F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(313, 52);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(482, 62);
            label5.TabIndex = 10;
            label5.Text = "STUDENT COUNCIL";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(666, 107);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(914, 941);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 26F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(313, 113);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(454, 62);
            label6.TabIndex = 12;
            label6.Text = "BUDGET TRACKER";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(181, 58, 58);
            ClientSize = new Size(1480, 906);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(loginBtn);
            Controls.Add(label4);
            Controls.Add(registerBtn);
            Controls.Add(label3);
            Controls.Add(passwordTxt);
            Controls.Add(emailTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "Form1";
            Load += LoginForm_Load;
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
        private Button loginBtn;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label6;
    }
}
