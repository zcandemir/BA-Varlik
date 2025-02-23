namespace PLL
{
    partial class UserListForm
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
            dgwUserList = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwUserList).BeginInit();
            SuspendLayout();
            // 
            // dgwUserList
            // 
            dgwUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwUserList.Location = new Point(33, 12);
            dgwUserList.Name = "dgwUserList";
            dgwUserList.Size = new Size(682, 287);
            dgwUserList.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(275, 343);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 42);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(449, 343);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 38);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(132, 343);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(100, 38);
            btnEkle.TabIndex = 13;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // UserListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnEkle);
            Controls.Add(dgwUserList);
            Name = "UserListForm";
            Text = "UserListForm";
            Load += UserListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgwUserList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwUserList;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnEkle;
    }
}