namespace PLL
{
    partial class AddWareHouseForm
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
            txtName = new TextBox();
            bynEkle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 49);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Adı";
            // 
            // txtName
            // 
            txtName.Location = new Point(78, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // bynEkle
            // 
            bynEkle.Location = new Point(89, 97);
            bynEkle.Name = "bynEkle";
            bynEkle.Size = new Size(75, 23);
            bynEkle.TabIndex = 2;
            bynEkle.Text = "Ekle";
            bynEkle.UseVisualStyleBackColor = true;
            bynEkle.Click += bynEkle_Click;
            // 
            // AddWareHouseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 161);
            Controls.Add(bynEkle);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "AddWareHouseForm";
            Text = "AddWareHouseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button bynEkle;
    }
}