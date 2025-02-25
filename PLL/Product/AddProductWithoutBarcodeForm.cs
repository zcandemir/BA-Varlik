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
using DAL.Entities;

namespace PLL
{
    public partial class AddProductWithoutBarcodeForm : Form
    {
        IManager<ProductModel> productManager = new ProductManager();
        IManager<WareHouseModel> warehouseManager = new WareHouseManager();
        public AddProductWithoutBarcodeForm()
        {
            InitializeComponent();
            LoadWareHouse();
        }
        private void LoadWareHouse()
        {
            var warehouse = warehouseManager.GetAll().Select(x => new { x.Name, x.Id }).ToList();
            cmbDepo.DataSource = warehouse;
            cmbDepo.DisplayMember = "Name";
            cmbDepo.ValueMember = "Id";

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrWhiteSpace(txtTip.Text) ||
                string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtMaliyet.Text) ||
                string.IsNullOrWhiteSpace(txtGüncelFiyat.Text) ||
                string.IsNullOrWhiteSpace(txtAciklama.Text) ||
                cmbDepo.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtMiktar.Text) ||
                string.IsNullOrWhiteSpace(txtBirim.Text))
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!double.TryParse(txtMaliyet.Text, out double cost))
            {
                MessageBox.Show("Geçerli bir maliyet giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtGüncelFiyat.Text, out double currentPrice))
            {
                MessageBox.Show("Geçerli bir güncel fiyat giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMiktar.Text, out int amount))
            {
                MessageBox.Show("Geçerli bir miktar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cmbDepo.SelectedValue?.ToString(), out int warehouseId))
            {
                MessageBox.Show("Geçerli bir depo seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProductModel product = new ProductModel();
            product.IsBarcoded = false;
            product.Type = txtTip.Text;
            product.Model = txtModel.Text;
            product.Cost = cost;
            product.CurrentPrice = currentPrice;
            product.Explanation = txtAciklama.Text;
            product.WarehouseId = warehouseId;
            product.Guarantee = cbGaranti.Checked;
            product.Amount = amount;
            product.Unit = txtBirim.Text;   

            productManager.Add(product);

            ProductListForm productListForm = new ProductListForm();
            productListForm.Show();
            this.Close();

        }
       
    }
}
