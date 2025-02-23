namespace PLL
{
    partial class AddProductWithBarcodeForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmbDepo = new ComboBox();
            label8 = new Label();
            txtBarkod = new TextBox();
            txtTip = new TextBox();
            txtModel = new TextBox();
            txtMaliyet = new TextBox();
            txtGüncelFiyat = new TextBox();
            txtAciklama = new TextBox();
            btnEkle = new Button();
            cbGaranti = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 30);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Barkod";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 108);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 0;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 71);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 0;
            label3.Text = "Tipi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 231);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 0;
            label4.Text = "Güncel Fiyat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 184);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 0;
            label5.Text = "Maliyet";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 151);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 0;
            label6.Text = "Garanti";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 348);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 0;
            label7.Text = "Depo";
            // 
            // cmbDepo
            // 
            cmbDepo.FormattingEnabled = true;
            cmbDepo.Location = new Point(129, 340);
            cmbDepo.Name = "cmbDepo";
            cmbDepo.Size = new Size(121, 23);
            cmbDepo.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 287);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 0;
            label8.Text = "Açıklama";
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(129, 22);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(100, 23);
            txtBarkod.TabIndex = 2;
            // 
            // txtTip
            // 
            txtTip.Location = new Point(129, 63);
            txtTip.Name = "txtTip";
            txtTip.Size = new Size(100, 23);
            txtTip.TabIndex = 2;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(129, 108);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 2;
            // 
            // txtMaliyet
            // 
            txtMaliyet.Location = new Point(129, 176);
            txtMaliyet.Name = "txtMaliyet";
            txtMaliyet.Size = new Size(100, 23);
            txtMaliyet.TabIndex = 2;
            // 
            // txtGüncelFiyat
            // 
            txtGüncelFiyat.Location = new Point(129, 223);
            txtGüncelFiyat.Name = "txtGüncelFiyat";
            txtGüncelFiyat.Size = new Size(100, 23);
            txtGüncelFiyat.TabIndex = 2;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(129, 273);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(184, 42);
            txtAciklama.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(143, 387);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // cbGaranti
            // 
            cbGaranti.AutoSize = true;
            cbGaranti.Location = new Point(129, 151);
            cbGaranti.Name = "cbGaranti";
            cbGaranti.Size = new Size(42, 19);
            cbGaranti.TabIndex = 4;
            cbGaranti.Text = "Var";
            cbGaranti.UseVisualStyleBackColor = true;
            // 
            // AddProductWithBarcodeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 450);
            Controls.Add(cbGaranti);
            Controls.Add(btnEkle);
            Controls.Add(txtModel);
            Controls.Add(txtAciklama);
            Controls.Add(txtGüncelFiyat);
            Controls.Add(txtMaliyet);
            Controls.Add(txtTip);
            Controls.Add(txtBarkod);
            Controls.Add(cmbDepo);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddProductWithBarcodeForm";
            Text = "AddProductWithBarcodeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbDepo;
        private Label label8;
        private TextBox txtBarkod;
        private TextBox txtTip;
        private TextBox txtModel;
        private TextBox txtMaliyet;
        private TextBox txtGüncelFiyat;
        private TextBox txtAciklama;
        private Button btnEkle;
        private CheckBox cbGaranti;
    }
}