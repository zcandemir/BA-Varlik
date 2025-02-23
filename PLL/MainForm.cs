using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            ProductListForm plf = new ProductListForm();
            plf.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserListForm plf = new UserListForm();
            plf.Show();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            WareHouseForm auf = new WareHouseForm();
            auf.Show();
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            DebitForm deb = new DebitForm();
            deb.Show();
            
        }
    }
}
