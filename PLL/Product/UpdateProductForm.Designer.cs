namespace PLL
{
    partial class UpdateProductForm
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
            cbGaranti = new CheckBox();
            btnGuncelle = new Button();
            txtModel = new TextBox();
            txtAciklama = new TextBox();
            txtGüncelFiyat = new TextBox();
            txtMaliyet = new TextBox();
            txtTip = new TextBox();
            txtBarkod = new TextBox();
            cmbDepo = new ComboBox();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBirim = new TextBox();
            txtMiktar = new TextBox();
            label10 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // cbGaranti
            // 
            cbGaranti.AutoSize = true;
            cbGaranti.Location = new Point(104, 149);
            cbGaranti.Name = "cbGaranti";
            cbGaranti.Size = new Size(42, 19);
            cbGaranti.TabIndex = 21;
            cbGaranti.Text = "Var";
            cbGaranti.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(119, 459);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 20;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(104, 106);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 18;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(104, 271);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(184, 42);
            txtAciklama.TabIndex = 17;
            // 
            // txtGüncelFiyat
            // 
            txtGüncelFiyat.Location = new Point(104, 221);
            txtGüncelFiyat.Name = "txtGüncelFiyat";
            txtGüncelFiyat.Size = new Size(100, 23);
            txtGüncelFiyat.TabIndex = 16;
            // 
            // txtMaliyet
            // 
            txtMaliyet.Location = new Point(104, 174);
            txtMaliyet.Name = "txtMaliyet";
            txtMaliyet.Size = new Size(100, 23);
            txtMaliyet.TabIndex = 15;
            // 
            // txtTip
            // 
            txtTip.Location = new Point(104, 61);
            txtTip.Name = "txtTip";
            txtTip.Size = new Size(100, 23);
            txtTip.TabIndex = 14;
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(104, 20);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(100, 23);
            txtBarkod.TabIndex = 19;
            // 
            // cmbDepo
            // 
            cmbDepo.FormattingEnabled = true;
            cmbDepo.Location = new Point(104, 338);
            cmbDepo.Name = "cmbDepo";
            cmbDepo.Size = new Size(121, 23);
            cmbDepo.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 69);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 11;
            label3.Text = "Tipi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 149);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 10;
            label6.Text = "Garanti";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 182);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 9;
            label5.Text = "Maliyet";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 285);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 8;
            label8.Text = "Açıklama";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 346);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 7;
            label7.Text = "Depo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 229);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 6;
            label4.Text = "Güncel Fiyat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 106);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 12;
            label2.Text = "Model";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 28);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 5;
            label1.Text = "Barkod";
            // 
            // txtBirim
            // 
            txtBirim.Location = new Point(104, 419);
            txtBirim.Name = "txtBirim";
            txtBirim.Size = new Size(100, 23);
            txtBirim.TabIndex = 28;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(104, 381);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(100, 23);
            txtMiktar.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(36, 427);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 25;
            label10.Text = "Birim";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 389);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 26;
            label9.Text = "Miktar";
            // 
            // UpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 499);
            Controls.Add(txtBirim);
            Controls.Add(txtMiktar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(cbGaranti);
            Controls.Add(btnGuncelle);
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
            Name = "UpdateProductForm";
            Text = "UpdateProductForm";
            Load += UpdateProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbGaranti;
        private Button btnGuncelle;
        private TextBox txtModel;
        private TextBox txtAciklama;
        private TextBox txtGüncelFiyat;
        private TextBox txtMaliyet;
        private TextBox txtTip;
        private TextBox txtBarkod;
        private ComboBox cmbDepo;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtBirim;
        private TextBox txtMiktar;
        private Label label10;
        private Label label9;
    }
}