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
    public partial class AddUserForm : Form
    {
        IManager<UserModel> usermanager = new UserManager();


        public AddUserForm()
        {
            InitializeComponent();
            
        }

       

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
               string.IsNullOrWhiteSpace(txtEmail.Text) ||
               string.IsNullOrWhiteSpace(txtPassword.Text) ||
               string.IsNullOrWhiteSpace(txtSurName.Text))
               
            {
                MessageBox.Show("TeamName boş olabilir onun dışında hepsi dolu olması zorunludur.!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            UserModel usermodel = new UserModel();
            usermodel.Name = txtName.Text;
            usermodel.Email = txtEmail.Text;
            usermodel.Password = txtPassword.Text;
            usermodel.SurName = txtSurName.Text;
            usermodel.TeamName= txtTeamName.Text;

            var response = usermanager.Add(usermodel);

            if (response)
            {
                MessageBox.Show("Kullanıcı Başarılı Bir Şekilde Eklendi!");
                
            }
            else
            {
                MessageBox.Show("Kullanıcı Oluşturulurken Bir Hata İle Karşılaşıldı!");
            }


            UserListForm userListForm = new UserListForm();
            userListForm.Show();
            this.Close();

        }

        
    }
}
