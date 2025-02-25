using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Abstract;
using BL.Concrete;
using BL.Models;

namespace PLL.Debit
{
    public partial class AddDebit : Form
    {
        IManager<ProductModel> productManager = new ProductManager();
        IManager<UserModel> userManager = new UserManager();
        IManager<DebitModel> debitManager = new DebitManager();
        public AddDebit()
        {
            InitializeComponent();
            LoadProduct();
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = userManager.GetAll().Select(x => new { x.Name, x.Id }).ToList();
            cmbAssignee.DataSource = users;
            cmbAssignee.DisplayMember = "Name";
            cmbAssignee.ValueMember = "Id";

            var aUsers = users.ToList();
            cmbAssigned.DataSource = aUsers;
            cmbAssigned.DisplayMember = "Name";
            cmbAssigned.ValueMember = "Id";
        }

        private void LoadProduct()
        {
            var products = productManager.GetAll().Select(x => new { x.Type, x.Id }).ToList();
            cmbProduct.DataSource = products;
            cmbProduct.DisplayMember = "Type";
            cmbProduct.ValueMember = "Id";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExp.Text))
            {
                MessageBox.Show("Açıklama boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbProduct.SelectedValue == null || !int.TryParse(cmbProduct.SelectedValue.ToString(), out int productId))
            {
                MessageBox.Show("Lütfen geçerli bir ürün seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbAssigned.SelectedValue == null || !int.TryParse(cmbAssigned.SelectedValue.ToString(), out int assignedUserId))
            {
                MessageBox.Show("Lütfen geçerli bir zimmetlenen kullanıcı seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbAssignee.SelectedValue == null || !int.TryParse(cmbAssignee.SelectedValue.ToString(), out int assigningUserId))
            {
                MessageBox.Show("Lütfen geçerli bir zimmet atan kullanıcı seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (assignedUserId == assigningUserId)
            {
                MessageBox.Show("Atayan ve atanan kullanıcı aynı olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DebitModel debit = new DebitModel
            {
                Explanation = txtExp.Text,
                ProductId = productId,
                AssigneduserId = assignedUserId,
                AssigninguserId = assigningUserId,
                IsActive = true
            };


            debitManager.Add(debit);

            MessageBox.Show("Zimmet Ataması Başarıyla Tamamlandı!");
            this.Close();
        }

        
    }
}
