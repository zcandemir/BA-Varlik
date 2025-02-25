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

namespace PLL
{
    public partial class UpdateProductForm : Form
    {
        IManager<ProductModel> productManager = new ProductManager();
        IManager<WareHouseModel> warehouseManager = new WareHouseManager();

        private int _productId;
        private ProductModel _product;
        public UpdateProductForm(int productId)
        {
            InitializeComponent();
            _productId = productId;
            LoadWareHouse();

            GetProduct(_productId);

        }

        private void LoadWareHouse()
        {
            var warehouse = warehouseManager.GetAll().Select(x => new { x.Name, x.Id }).ToList();
            cmbDepo.DataSource = warehouse;
            cmbDepo.DisplayMember = "Name";
            cmbDepo.ValueMember = "Id";

        }

        private void GetProduct(int productId)
        {

            
            var product = productManager.GetById(_productId);
            _product = product;

            txtBarkod.Text = product.BarcodeNo;
            txtTip.Text = product.Type;
            txtModel.Text = product.Model;
            txtMaliyet.Text = product.Cost.ToString();
            txtGüncelFiyat.Text = product.CurrentPrice.ToString();
            txtAciklama.Text = product.Explanation;
            cmbDepo.SelectedValue = product.WarehouseId;
            cbGaranti.Checked = product.Guarantee;
            txtMiktar.Text = product.Amount.ToString();
            txtBirim.Text = product.Unit;

            if (product.IsBarcoded)
            {
                txtMiktar.Visible = false;
                txtBirim.Visible = false;
                label10.Visible = false;
                label9.Visible = false;
            }
            else
            {
                txtBarkod.Visible = false;
                label1.Visible = false;
            }
            

            
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            

           
            if (string.IsNullOrWhiteSpace(txtTip.Text) ||
                string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtMaliyet.Text) ||
                string.IsNullOrWhiteSpace(txtGüncelFiyat.Text) ||
                string.IsNullOrWhiteSpace(txtAciklama.Text) ||
                cmbDepo.SelectedValue == null)
            {
                MessageBox.Show("Lütfen zorunlu alanları eksiksiz doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (!int.TryParse(cmbDepo.SelectedValue?.ToString(), out int warehouseId))
            {
                MessageBox.Show("Geçerli bir depo seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            ProductModel product = new ProductModel();

            product.Id = _product.Id;
            product.IsBarcoded = _product.IsBarcoded;
            product.Type = txtTip.Text;
            product.Model = txtModel.Text;
            product.Cost = cost;
            product.CurrentPrice = currentPrice;
            product.Explanation = txtAciklama.Text;
            product.WarehouseId = warehouseId;
            product.Guarantee = cbGaranti.Checked;

            if (_product.IsBarcoded)
            {
                
                if (string.IsNullOrWhiteSpace(txtBarkod.Text))
                {
                    MessageBox.Show("Lütfen barkod numarasını giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                product.BarcodeNo = txtBarkod.Text;
            }
            else
            {
                
                if (string.IsNullOrWhiteSpace(txtMiktar.Text) || string.IsNullOrWhiteSpace(txtBirim.Text))
                {
                    MessageBox.Show("Lütfen miktar ve birim bilgilerini eksiksiz giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtMiktar.Text, out int amount))
                {
                    MessageBox.Show("Geçerli bir miktar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                product.Amount = amount;
                product.Unit = txtBirim.Text;
            }

            
            productManager.Update(product);

            
            ProductListForm productListForm = new ProductListForm();
            productListForm.Show();
            this.Close();
        }
    }
}
