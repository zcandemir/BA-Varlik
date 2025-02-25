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

namespace PLL.WareHouse
{
    public partial class UpdateWareHouseForm : Form
    {
        IManager<WareHouseModel> wareHouseManager = new WareHouseManager();
        private int _warehouseid;
        private WareHouseModel _warehouse;
        public UpdateWareHouseForm(int warehouseid)
        {
            _warehouseid = warehouseid;
            InitializeComponent();
            GetWareHouse(_warehouseid);
        }

        private void GetWareHouse(int warehouseid)
        {
            var warehouse = wareHouseManager.GetById(_warehouseid);
            _warehouse = warehouse;
            txtName.Text = warehouse.Name;

        }

        private void UpdateWareHouseForm_Load(object sender, EventArgs e)
        { }
        

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Lütfen depo adını giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            WareHouseModel wareHouseModel = new WareHouseModel();
            wareHouseModel.Id = _warehouse.Id;
            wareHouseModel.Name = txtName.Text;

            wareHouseManager.Update(wareHouseModel);
            WareHouseForm wareHouseForm = new WareHouseForm();
            wareHouseForm.Show();
            this.Close();


        }
    }
}
