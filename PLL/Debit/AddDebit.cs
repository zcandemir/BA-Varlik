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

            DebitModel debit = new DebitModel();
            debit.Explanation = txtExp.Text;
            debit.ProductId = Convert.ToInt32(cmbProduct.SelectedValue);
            debit.AssigneduserId = Convert.ToInt32(cmbAssigned.SelectedValue);
            debit.AssigninguserId = Convert.ToInt32(cmbAssignee.SelectedValue);

            debitManager.Add(debit);

            MessageBox.Show("Zimmet Ataması Başarıyla Tamamlandı!");
            this.Close();   
        }
    }
}
