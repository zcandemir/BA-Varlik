namespace PLL
{
    partial class DebitForm
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
            btnRapor = new Button();
            dgwZimmetList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwZimmetList).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(631, 12);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(128, 75);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Zimmete Ürün Ver";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += button1_Click;
            // 
            // btnRapor
            // 
            btnRapor.Location = new Point(631, 93);
            btnRapor.Name = "btnRapor";
            btnRapor.Size = new Size(128, 75);
            btnRapor.TabIndex = 0;
            btnRapor.Text = "Rapor";
            btnRapor.UseVisualStyleBackColor = true;
            btnRapor.Click += btnRapor_Click;
            // 
            // dgwZimmetList
            // 
            dgwZimmetList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwZimmetList.Location = new Point(12, 12);
            dgwZimmetList.Name = "dgwZimmetList";
            dgwZimmetList.Size = new Size(592, 553);
            dgwZimmetList.TabIndex = 1;
            // 
            // DebitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 582);
            Controls.Add(btnRapor);
            Controls.Add(dgwZimmetList);
            Controls.Add(btnEkle);
            Name = "DebitForm";
            Text = "DebitForm";
            ((System.ComponentModel.ISupportInitialize)dgwZimmetList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEkle;
        private Button btnRapor;
        private DataGridView dgwZimmetList;
    }
}