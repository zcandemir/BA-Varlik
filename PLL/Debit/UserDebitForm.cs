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
        IManager<DebitModel> debitManager = new DebitManager();
        private int _userId;
        public UserDebitForm(int userId)
        {
            InitializeComponent();
            _userId = userId;

            var debits = debitManager.GetAllWithIncludes().Where(x => x.AssigneduserId == _userId).Select(x => new
            {
                x.Id,
                x.CreatedDate,
                ProductName = x.Product.Type,
                AssignedUserName = x.AssignedUser.Name,
                AssignedUserSurname = x.AssignedUser.SurName,
                AssigningUserName = x.AssigningUser.Name,
                AssigningUserSurname = x.AssigningUser.SurName
            }).ToList();
            dgwDebitList.DataSource = debits;
        }
    }
}
