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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(118, 213);
            button1.Name = "button1";
            button1.Size = new Size(178, 90);
            button1.TabIndex = 0;
            button1.Text = "ADMIN";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(401, 213);
            button2.Name = "button2";
            button2.Size = new Size(178, 90);
            button2.TabIndex = 1;
            button2.Text = "STUDENT \r\nREPRESENTATIVE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(684, 213);
            button3.Name = "button3";
            button3.Size = new Size(178, 90);
            button3.TabIndex = 2;
            button3.Text = "STUDENT \r\nCOUNCIL";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(355, 43);
            label1.Name = "label1";
            label1.Size = new Size(265, 54);
            label1.TabIndex = 3;
            label1.Text = "REGISTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 472);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 4;
            label2.Text = "Already have an account?";
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(553, 468);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "Register";
            button4.UseVisualStyleBackColor = true;
            // 
            // RoleSelector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 537);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "RoleSelector";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Button button4;
    }
}