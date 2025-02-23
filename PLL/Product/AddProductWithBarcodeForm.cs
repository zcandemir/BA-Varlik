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
using Microsoft.EntityFrameworkCore.Storage.Json;

namespace PLL
{
    public partial class AddProductWithBarcodeForm : Form
    {
        IManager<ProductModel> productManager = new ProductManager();
        IManager<WareHouseModel> warehouseManager = new WareHouseManager();
        public AddProductWithBarcodeForm()
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

            ProductModel product = new ProductModel();
            product.IsBarcoded = true;
            product.BarcodeNo = txtBarkod.Text;
            product.Type = txtTip.Text;
            product.Model = txtModel.Text;
            product.Cost = double.Parse(txtMaliyet.Text);
            product.CurrentPrice = double.Parse(txtGüncelFiyat.Text);
            product.Explanation = txtAciklama.Text;
            product.WarehouseId = Convert.ToInt32(cmbDepo.SelectedValue);
            product.Guarantee = cbGaranti.Checked;
            
            productManager.Add(product);

            ProductListForm productListForm = new ProductListForm();
            productListForm.Show();
            this.Close();
        }
    }
}
