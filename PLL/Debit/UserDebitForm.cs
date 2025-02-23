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

namespace PLL.Debit
{
    public partial class UserDebitForm : Form
    {
        IManager<UserDebitModel> userDebitManager = new UserDebitManager();
        private int _userId;
        public UserDebitForm(int userId)
        {
            InitializeComponent();
            _userId = userId;

            var userDebitList = userDebitManager.Search(x => x.UserId == _userId).ToList();



        }


    }
}
