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
            ProductModel product = new ProductModel();

            product.Id=_product.Id;
            product.IsBarcoded = _product.IsBarcoded;
            product.Type = txtTip.Text;
            product.Model = txtModel.Text;
            product.Cost = double.Parse(txtMaliyet.Text);
            product.CurrentPrice = double.Parse(txtGüncelFiyat.Text);
            product.Explanation = txtAciklama.Text;
            product.WarehouseId = Convert.ToInt32(cmbDepo.SelectedValue);
            product.Guarantee = cbGaranti.Checked;

            if (_product.IsBarcoded)
            {
                product.BarcodeNo = txtBarkod.Text;
            }
            else
            {
                product.Amount = Convert.ToInt32(txtMiktar.Text);
                product.Unit = txtBirim.Text;
            }

            productManager.Update(product);

            this.Close();
            ProductListForm productListForm = new ProductListForm();
            productListForm.Show();
        }
    }
}
