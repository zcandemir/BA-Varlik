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
using PLL.User;

namespace PLL
{
    public partial class UserListForm : Form
    {
        IManager<UserModel> usermanager = new UserManager();
        public UserListForm()
        {
            InitializeComponent();
            UserList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
            this.Close();
            
        }

        public void UserList()
        {
            dgwUserList.DataSource = usermanager.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwUserList.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgwUserList.SelectedRows[0].Cells["id"].Value);
                string name = dgwUserList.SelectedRows[0].Cells["name"].Value.ToString();
                string surname = dgwUserList.SelectedRows[0].Cells["surname"].Value.ToString();

                DialogResult result = MessageBox.Show($"{name} {surname} isimli kullanıcı silmek istiyor musunuz?", "Silmek İstiyor musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        usermanager.Remove(id);
                        UserList();
                        MessageBox.Show("Başarıyla Silindi!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kullanıcı Silinirken Bir Hata İle Karşılaşıldı! " + ex.Message);
                    }
                }
            }
            else if (dgwUserList.SelectedRows.Count > 1)
                MessageBox.Show("Lütfen Sadece Bir Satır Seçin!");

            UserList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgwUserList.SelectedRows.Count == 1) 
            {
                int id = Convert.ToInt32(dgwUserList.SelectedRows[0].Cells["id"].Value);
                UpdateUserForm updateuserform = new UpdateUserForm(id);
                updateuserform.Show();
                this.Close();
            }
            else if (dgwUserList.SelectedRows.Count > 1)
                MessageBox.Show("Lütfen Sadece Bir Satır Seçin!");
            else
            {
                MessageBox.Show("Bir satır seçimi yapmadınız.");
            }
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            UserList(); 
        }
    }
}
