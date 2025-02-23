namespace PLL.User
{
    partial class UpdateUserForm
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
            btnEkle = new Button();
            txtSurName = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtTeamName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(115, 269);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(100, 38);
            btnEkle.TabIndex = 20;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtSurName
            // 
            txtSurName.Location = new Point(115, 68);
            txtSurName.Name = "txtSurName";
            txtSurName.Size = new Size(100, 23);
            txtSurName.TabIndex = 19;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(115, 164);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(115, 114);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 17;
            // 
            // txtName
            // 
            txtName.Location = new Point(115, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 16;
            // 
            // txtTeamName
            // 
            txtTeamName.Location = new Point(115, 216);
            txtTeamName.Name = "txtTeamName";
            txtTeamName.Size = new Size(100, 23);
            txtTeamName.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 219);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 13;
            label5.Text = "TeamName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 167);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 14;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 117);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 12;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 71);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 11;
            label2.Text = "SurName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 26);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 10;
            label1.Text = "Name";
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 359);
            Controls.Add(btnEkle);
            Controls.Add(txtSurName);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtTeamName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateUserForm";
            Text = "UpdateUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private TextBox txtSurName;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtTeamName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}