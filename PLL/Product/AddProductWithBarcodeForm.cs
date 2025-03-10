﻿using System;
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

            
            if (string.IsNullOrWhiteSpace(txtBarkod.Text) ||
                string.IsNullOrWhiteSpace(txtTip.Text) ||
                string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtMaliyet.Text) ||
                string.IsNullOrWhiteSpace(txtGüncelFiyat.Text) ||
                string.IsNullOrWhiteSpace(txtAciklama.Text) ||
                cmbDepo.SelectedValue == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!double.TryParse(txtMaliyet.Text, out double cost))
            {
                MessageBox.Show("Maliyet değeri geçerli bir sayı olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtGüncelFiyat.Text, out double currentPrice))
            {
                MessageBox.Show("Güncel Fiyat değeri geçerli bir sayı olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cmbDepo.SelectedValue?.ToString(), out int warehouseId))
            {
                MessageBox.Show("Geçerli bir depo seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProductModel product = new ProductModel();
            product.IsBarcoded = true;
            product.BarcodeNo = txtBarkod.Text;
            product.Type = txtTip.Text;
            product.Model = txtModel.Text;
            product.Cost = cost;
            product.CurrentPrice = currentPrice;
            product.Explanation = txtAciklama.Text;
            product.WarehouseId = warehouseId;
            product.Guarantee = cbGaranti.Checked;
            
            productManager.Add(product);

            ProductListForm productListForm = new ProductListForm();
            productListForm.Show();
            this.Close();
        }
    }
}
