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
    public partial class ProductListForm : Form
    {
        IManager<ProductModel> productManager = new ProductManager();

        public ProductListForm()
        {
            InitializeComponent();
            GetAllProduct();
        }

        private void GetAllProduct()
        {
            dgwProductList.DataSource = productManager.GetAllWithIncludes().Select(x => new { x.Id, x.BarcodeNo, x.Type, x.Model, x.Guarantee, x.Cost, x.Explanation, x.WareHouse.Name,x.Amount,x.Unit }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Eklemek istediğiniz ürün barkodlu mu?", "Barkod?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AddProductWithBarcodeForm addbarcodedProduct = new AddProductWithBarcodeForm();
                addbarcodedProduct.Show();
            }
            else if (result == DialogResult.No)
            {
                AddProductWithoutBarcodeForm addbarkodeProduct = new AddProductWithoutBarcodeForm();
                addbarkodeProduct.Show();
            }
        }

        private void btnBarkodlu_Click(object sender, EventArgs e)
        {
            dgwProductList.DataSource = productManager.GetAllWithIncludes().Where(y => y.IsBarcoded).Select(x => new { x.Id, x.BarcodeNo, x.Type, x.Model, x.Guarantee, x.Cost, x.Explanation, x.WareHouse.Name }).ToList();
        }

        private void btnBarkodsuz_Click(object sender, EventArgs e)
        {
            dgwProductList.DataSource = productManager.GetAllWithIncludes().Where(y => !y.IsBarcoded).Select(x => new { x.Id,x.Amount,x.Unit, x.Type, x.Model, x.Guarantee, x.Cost, x.Explanation, x.WareHouse.Name }).ToList();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgwProductList.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgwProductList.SelectedRows[0].Cells["id"].Value);
                UpdateProductForm updateproductform = new UpdateProductForm(id);
                updateproductform.Show();
                this.Close();
            }
            else if (dgwProductList.SelectedRows.Count > 1)
                MessageBox.Show("Lütfen Sadece Bir Satır Seçin!");


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProductList.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgwProductList.SelectedRows[0].Cells["id"].Value);
                string Model = dgwProductList.SelectedRows[0].Cells["Model"].Value.ToString();



                DialogResult result = MessageBox.Show($"{Model}  modelli ürünü  silmek istiyor musunuz?", "Silmek İstiyor musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        productManager.Remove(id);
                        GetAllProduct();
                        MessageBox.Show("Başarıyla Silindi!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ürün Silinirken Bir Hata İle Karşılaşıldı! " + ex.Message);
                    }
                }
            }
            else if (dgwProductList.SelectedRows.Count > 1)
                MessageBox.Show("Lütfen Sadece Bir Satır Seçin!");
        }
    }
}
