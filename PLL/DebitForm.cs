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
using PLL.Debit;

namespace PLL
{
    public partial class DebitForm : Form
    {
        IManager<DebitModel> debitManager = new DebitManager();
        IManager<UserModel> userManager = new UserManager();

        public DebitForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            dgwZimmetList.DataSource = userManager.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDebit addDef = new AddDebit();
            addDef.Show();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {

        }
    }
}



