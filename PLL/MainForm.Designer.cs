namespace PLL
{
    partial class MainForm
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
            btnProductList = new Button();
            btnUser = new Button();
            btnDebit = new Button();
            btnWarehouse = new Button();
            SuspendLayout();
            // 
            // btnProductList
            // 
            btnProductList.Font = new Font("Segoe UI", 25F);
            btnProductList.Location = new Point(22, 26);
            btnProductList.Name = "btnProductList";
            btnProductList.Size = new Size(195, 404);
            btnProductList.TabIndex = 1;
            btnProductList.Text = "PRODUCT";
            btnProductList.UseVisualStyleBackColor = true;
            btnProductList.Click += btnProductList_Click;
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Segoe UI", 25F);
            btnUser.Location = new Point(223, 26);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(195, 404);
            btnUser.TabIndex = 2;
            btnUser.Text = "USER";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnDebit
            // 
            btnDebit.Font = new Font("Segoe UI", 25F);
            btnDebit.Location = new Point(424, 26);
            btnDebit.Name = "btnDebit";
            btnDebit.Size = new Size(195, 404);
            btnDebit.TabIndex = 3;
            btnDebit.Text = "DEBIT";
            btnDebit.UseVisualStyleBackColor = true;
            btnDebit.Click += btnDebit_Click;
            // 
            // btnWarehouse
            // 
            btnWarehouse.Font = new Font("Segoe UI", 25F);
            btnWarehouse.Location = new Point(625, 26);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Size = new Size(195, 404);
            btnWarehouse.TabIndex = 4;
            btnWarehouse.Text = "WARE   HOUSE";
            btnWarehouse.UseVisualStyleBackColor = true;
            btnWarehouse.Click += btnWarehouse_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 440);
            Controls.Add(btnWarehouse);
            Controls.Add(btnDebit);
            Controls.Add(btnUser);
            Controls.Add(btnProductList);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion
        private Button btnProductList;
        private Button btnUser;
        private Button btnDebit;
        private Button btnWarehouse;
    }
}