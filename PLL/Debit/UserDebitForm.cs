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

            var debits = debitManager.GetAllWithIncludes().Where(x => x.AssigneduserId == _userId && x.IsActive == true).Select(x => new
            {
                x.Id,
                x.CreatedDate,
                x.IsActive,
                x.AssignedUser.TeamName,
                ProductName = x.Product.Type,
                AssignedUserName = x.AssignedUser.Name,
                AssignedUserSurname = x.AssignedUser.SurName,
                AssigningUserName = x.AssigningUser.Name,
                AssigningUserSurname = x.AssigningUser.SurName
            }).ToList();
            dgwDebitList.DataSource = debits;
        }

        private void btnDusur_Click(object sender, EventArgs e)
        {
            if (dgwDebitList.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgwDebitList.SelectedRows[0].Cells["id"].Value);
                var debit = debitManager.GetById(id);
                if (debit != null)
                {
                    debit.IsActive = false;
                    debitManager.Update(debit);
                }
                else
                {
                    MessageBox.Show("Seçilen zimmet bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dgwDebitList.SelectedRows.Count > 1)
            {
                MessageBox.Show("Lütfen Sadece Bir Satır Seçin!");
            }
            else
            {
                MessageBox.Show("Bir seçim yapmadınız!");
            }

            DebitForm debitForm = new DebitForm();
            debitForm.Show();
            this.Close();
        }
    }
}
