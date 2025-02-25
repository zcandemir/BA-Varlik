namespace PLL.Debit
{
    partial class AddDebit
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
            txtExp = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbProduct = new ComboBox();
            cmbAssigned = new ComboBox();
            cmbAssignee = new ComboBox();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // txtExp
            // 
            txtExp.Location = new Point(142, 159);
            txtExp.Name = "txtExp";
            txtExp.Size = new Size(121, 23);
            txtExp.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 162);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 17;
            label4.Text = "Açıklama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 113);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 16;
            label3.Text = "Atayan Kullanıcı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 70);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 15;
            label2.Text = "Atanan Kullanıcı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 14;
            label1.Text = "Ürün";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(142, 20);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(121, 23);
            cmbProduct.TabIndex = 13;
            // 
            // cmbAssigned
            // 
            cmbAssigned.FormattingEnabled = true;
            cmbAssigned.Location = new Point(142, 70);
            cmbAssigned.Name = "cmbAssigned";
            cmbAssigned.Size = new Size(121, 23);
            cmbAssigned.TabIndex = 12;
            
            // 
            // cmbAssignee
            // 
            cmbAssignee.FormattingEnabled = true;
            cmbAssignee.Location = new Point(142, 113);
            cmbAssignee.Name = "cmbAssignee";
            cmbAssignee.Size = new Size(121, 23);
            cmbAssignee.TabIndex = 11;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(117, 208);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(84, 52);
            btnKaydet.TabIndex = 19;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // AddDebit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 272);
            Controls.Add(btnKaydet);
            Controls.Add(txtExp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbProduct);
            Controls.Add(cmbAssigned);
            Controls.Add(cmbAssignee);
            Name = "AddDebit";
            Text = "AddDebit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtExp;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbProduct;
        private ComboBox cmbAssigned;
        private ComboBox cmbAssignee;
        private Button btnKaydet;
    }
}