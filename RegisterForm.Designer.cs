namespace Project_SIGMA__A_Budget_Request_Application_
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            usernameTxt = new TextBox();
            emailTxt = new TextBox();
            passwordTxt = new TextBox();
            confirmPassTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            loginBtn = new Button();
            label6 = new Label();
            registerBtn = new Button();
            passHidden = new Button();
            passShown = new Button();
            confirmShow = new Button();
            confirmHidden = new Button();
            SuspendLayout();
            // 
            // usernameTxt
            // 
            usernameTxt.Font = new Font("Segoe UI", 13.8F);
            usernameTxt.Location = new Point(155, 150);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(396, 38);
            usernameTxt.TabIndex = 0;
            // 
            // emailTxt
            // 
            emailTxt.Font = new Font("Segoe UI", 13.8F);
            emailTxt.Location = new Point(155, 244);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(396, 38);
            emailTxt.TabIndex = 1;
            // 
            // passwordTxt
            // 
            passwordTxt.Font = new Font("Segoe UI", 13.8F);
            passwordTxt.Location = new Point(155, 334);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(396, 38);
            passwordTxt.TabIndex = 2;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // confirmPassTxt
            // 
            confirmPassTxt.Font = new Font("Segoe UI", 13.8F);
            confirmPassTxt.Location = new Point(155, 424);
            confirmPassTxt.Name = "confirmPassTxt";
            confirmPassTxt.PasswordChar = '*';
            confirmPassTxt.Size = new Size(396, 38);
            confirmPassTxt.TabIndex = 3;
            confirmPassTxt.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Demi", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 42);
            label1.Name = "label1";
            label1.Size = new Size(183, 43);
            label1.TabIndex = 4;
            label1.Text = "REGISTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label2.Location = new Point(155, 118);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 5;
            label2.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label3.Location = new Point(155, 211);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 6;
            label3.Text = "EMAIL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label4.Location = new Point(155, 301);
            label4.Name = "label4";
            label4.Size = new Size(116, 21);
            label4.TabIndex = 7;
            label4.Text = "PASSWORD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label5.Location = new Point(155, 392);
            label5.Name = "label5";
            label5.Size = new Size(207, 21);
            label5.TabIndex = 8;
            label5.Text = "CONFIRM PASSWORD";
            // 
            // loginBtn
            // 
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.DimGray;
            loginBtn.Location = new Point(403, 545);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 46);
            loginBtn.TabIndex = 10;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(190, 556);
            label6.Name = "label6";
            label6.Size = new Size(220, 25);
            label6.TabIndex = 9;
            label6.Text = "Already have an account?";
            // 
            // registerBtn
            // 
            registerBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerBtn.Location = new Point(252, 485);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(178, 51);
            registerBtn.TabIndex = 11;
            registerBtn.Text = "CREATE ACCOUNT";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // passHidden
            // 
            passHidden.BackColor = Color.White;
            passHidden.FlatAppearance.BorderSize = 0;
            passHidden.FlatStyle = FlatStyle.Flat;
            passHidden.Image = (Image)resources.GetObject("passHidden.Image");
            passHidden.Location = new Point(510, 338);
            passHidden.Name = "passHidden";
            passHidden.Size = new Size(40, 28);
            passHidden.TabIndex = 12;
            passHidden.UseVisualStyleBackColor = false;
            passHidden.Click += passHidden_Click;
            // 
            // passShown
            // 
            passShown.BackColor = Color.White;
            passShown.FlatAppearance.BorderSize = 0;
            passShown.FlatStyle = FlatStyle.Flat;
            passShown.Image = (Image)resources.GetObject("passShown.Image");
            passShown.Location = new Point(509, 337);
            passShown.Name = "passShown";
            passShown.Size = new Size(40, 28);
            passShown.TabIndex = 13;
            passShown.UseVisualStyleBackColor = false;
            passShown.Visible = false;
            passShown.Click += passShown_Click;
            // 
            // confirmShow
            // 
            confirmShow.BackColor = Color.White;
            confirmShow.FlatAppearance.BorderSize = 0;
            confirmShow.FlatStyle = FlatStyle.Flat;
            confirmShow.Image = (Image)resources.GetObject("confirmShow.Image");
            confirmShow.Location = new Point(508, 428);
            confirmShow.Name = "confirmShow";
            confirmShow.Size = new Size(40, 28);
            confirmShow.TabIndex = 15;
            confirmShow.UseVisualStyleBackColor = false;
            confirmShow.Visible = false;
            confirmShow.Click += confirmShow_Click;
            // 
            // confirmHidden
            // 
            confirmHidden.BackColor = Color.White;
            confirmHidden.FlatAppearance.BorderSize = 0;
            confirmHidden.FlatStyle = FlatStyle.Flat;
            confirmHidden.Image = (Image)resources.GetObject("confirmHidden.Image");
            confirmHidden.Location = new Point(509, 428);
            confirmHidden.Name = "confirmHidden";
            confirmHidden.Size = new Size(40, 28);
            confirmHidden.TabIndex = 14;
            confirmHidden.UseVisualStyleBackColor = false;
            confirmHidden.Click += confirmHidden_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 602);
            Controls.Add(confirmShow);
            Controls.Add(confirmHidden);
            Controls.Add(passShown);
            Controls.Add(passHidden);
            Controls.Add(registerBtn);
            Controls.Add(loginBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(confirmPassTxt);
            Controls.Add(passwordTxt);
            Controls.Add(emailTxt);
            Controls.Add(usernameTxt);
            Name = "RegisterForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTxt;
        private TextBox emailTxt;
        private TextBox passwordTxt;
        private TextBox confirmPassTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button loginBtn;
        private Label label6;
        private Button registerBtn;
        private Button passHidden;
        private Button passShown;
        private Button confirmShow;
        private Button confirmHidden;
    }
}