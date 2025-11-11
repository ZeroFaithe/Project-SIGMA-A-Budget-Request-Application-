namespace Project_SIGMA__A_Budget_Request_Application_
{
    partial class RoleSelector
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
            adminBtn = new Button();
            repBtn = new Button();
            councilBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // adminBtn
            // 
            adminBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            adminBtn.Location = new Point(32, 231);
            adminBtn.Name = "adminBtn";
            adminBtn.Size = new Size(210, 90);
            adminBtn.TabIndex = 0;
            adminBtn.Text = "ADMIN";
            adminBtn.UseVisualStyleBackColor = true;
            adminBtn.Click += adminBtn_Click;
            // 
            // repBtn
            // 
            repBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            repBtn.Location = new Point(300, 231);
            repBtn.Name = "repBtn";
            repBtn.Size = new Size(210, 90);
            repBtn.TabIndex = 1;
            repBtn.Text = "STUDENT \r\nREPRESENTATIVE";
            repBtn.UseVisualStyleBackColor = true;
            repBtn.Click += repBtn_Click;
            // 
            // councilBtn
            // 
            councilBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            councilBtn.Location = new Point(555, 231);
            councilBtn.Name = "councilBtn";
            councilBtn.Size = new Size(210, 90);
            councilBtn.TabIndex = 2;
            councilBtn.Text = "STUDENT \r\nCOUNCIL";
            councilBtn.UseVisualStyleBackColor = true;
            councilBtn.Click += councilBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Demi", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 41);
            label1.Name = "label1";
            label1.Size = new Size(233, 54);
            label1.TabIndex = 3;
            label1.Text = "REGISTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(235, 469);
            label2.Name = "label2";
            label2.Size = new Size(220, 25);
            label2.TabIndex = 4;
            label2.Text = "Already have an account?";
            // 
            // loginBtn
            // 
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.DimGray;
            loginBtn.Location = new Point(448, 458);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 46);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // RoleSelector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 537);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(councilBtn);
            Controls.Add(repBtn);
            Controls.Add(adminBtn);
            Name = "RoleSelector";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button adminBtn;
        private Button repBtn;
        private Button councilBtn;
        private Label label1;
        private Label label2;
        private Button loginBtn;
    }
}