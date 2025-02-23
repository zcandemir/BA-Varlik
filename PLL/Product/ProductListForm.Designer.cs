namespace PLL
{
    partial class ProductListForm
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
            dgwProductList = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnBarkodlu = new Button();
            btnBarkodsuz = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwProductList).BeginInit();
            SuspendLayout();
            // 
            // dgwProductList
            // 
            dgwProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProductList.Location = new Point(12, 12);
            dgwProductList.Name = "dgwProductList";
            dgwProductList.Size = new Size(669, 413);
            dgwProductList.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(702, 27);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(702, 56);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(702, 85);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBarkodlu
            // 
            btnBarkodlu.Location = new Point(702, 132);
            btnBarkodlu.Name = "btnBarkodlu";
            btnBarkodlu.Size = new Size(75, 78);
            btnBarkodlu.TabIndex = 4;
            btnBarkodlu.Text = "Barkodlu Ürünleri Getir";
            btnBarkodlu.UseVisualStyleBackColor = true;
            btnBarkodlu.Click += btnBarkodlu_Click;
            // 
            // btnBarkodsuz
            // 
            btnBarkodsuz.Location = new Point(702, 239);
            btnBarkodsuz.Name = "btnBarkodsuz";
            btnBarkodsuz.Size = new Size(75, 78);
            btnBarkodsuz.TabIndex = 5;
            btnBarkodsuz.Text = "Barkodsuz Ürünleri Getir";
            btnBarkodsuz.UseVisualStyleBackColor = true;
            btnBarkodsuz.Click += btnBarkodsuz_Click;
            // 
            // ProductListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBarkodsuz);
            Controls.Add(btnBarkodlu);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgwProductList);
            Name = "ProductListForm";
            Text = "ProductListForm";
            ((System.ComponentModel.ISupportInitialize)dgwProductList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwProductList;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnBarkodlu;
        private Button btnBarkodsuz;
    }
}