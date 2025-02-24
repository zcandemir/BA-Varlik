namespace PLL.Debit
{
    partial class UserDebitForm
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
            dgwDebitList = new DataGridView();
            btnDusur = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwDebitList).BeginInit();
            SuspendLayout();
            // 
            // dgwDebitList
            // 
            dgwDebitList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDebitList.Location = new Point(12, 12);
            dgwDebitList.Name = "dgwDebitList";
            dgwDebitList.Size = new Size(622, 426);
            dgwDebitList.TabIndex = 0;
            // 
            // btnDusur
            // 
            btnDusur.Location = new Point(655, 12);
            btnDusur.Name = "btnDusur";
            btnDusur.Size = new Size(133, 75);
            btnDusur.TabIndex = 1;
            btnDusur.Text = "Zimmetten Düşür";
            btnDusur.UseVisualStyleBackColor = true;
            btnDusur.Click += btnDusur_Click;
            // 
            // UserDebitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDusur);
            Controls.Add(dgwDebitList);
            Name = "UserDebitForm";
            Text = "UserDebitForm";
            ((System.ComponentModel.ISupportInitialize)dgwDebitList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwDebitList;
        private Button btnDusur;
    }
}