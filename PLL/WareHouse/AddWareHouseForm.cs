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
    public partial class AddWareHouseForm : Form
    {
        IManager<WareHouseModel> wareHouseManager = new WareHouseManager();
        public AddWareHouseForm()
        {
            InitializeComponent();
        }

        private void bynEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Lütfen depo adını giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            WareHouseModel wareHouseModel = new WareHouseModel();
            wareHouseModel.Name = txtName.Text;
            wareHouseManager.Add(wareHouseModel);

            MessageBox.Show("Başarı ile eklendi");

            WareHouseForm form = new WareHouseForm();
            form.Show();
            this.Close();

        }
    }
}
