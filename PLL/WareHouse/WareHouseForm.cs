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
using PLL.WareHouse;

namespace PLL
{
    public partial class WareHouseForm : Form
    {
        IManager<WareHouseModel> wareHouseManager = new WareHouseManager();
        public WareHouseForm()
        {
            InitializeComponent();
            LoadWareHouse();
        }

        private void LoadWareHouse()
        {
            dgwWareHouseList.DataSource = wareHouseManager.GetAll().Select(x => new { x.Name, x.Id }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddWareHouseForm frm = new AddWareHouseForm();
            frm.Show();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwWareHouseList.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgwWareHouseList.SelectedRows[0].Cells["id"].Value);
                string name = dgwWareHouseList.SelectedRows[0].Cells["name"].Value.ToString();


                DialogResult result = MessageBox.Show($"{name}  isimli depoyu silmek istiyor musunuz?", "Silmek İstiyor musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        wareHouseManager.Remove(id);
                        LoadWareHouse();
                        MessageBox.Show("Başarıyla Silindi!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Depo Silinirken Bir Hata İle Karşılaşıldı! " + ex.Message);
                    }
                }
            }
            else if (dgwWareHouseList.SelectedRows.Count > 1)
                MessageBox.Show("Lütfen Sadece Bir Satır Seçin!");


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             int id = Convert.ToInt32(dgwWareHouseList.SelectedRows[0].Cells["id"].Value);
            UpdateWareHouseForm updateWareHouseForm = new UpdateWareHouseForm(id);
            updateWareHouseForm.Show();
            this.Close();
        }
    }
}
