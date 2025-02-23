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
using DAL.Entities;

namespace PLL.User
{
    public partial class UpdateUserForm : Form
    {
        IManager<UserModel> userManager = new UserManager();
        private int _userId;
        private UserModel _user;
        public UpdateUserForm(int userId)
        {
            _userId = userId;   
            InitializeComponent();
            GetUser(_userId);
        }

        private void GetUser(int userId)
        {
            var user = userManager.GetById(_userId);
            _user = user;

            txtName.Text = user.Name;
            txtEmail.Text = user.Email; 
            txtPassword.Text = user.Password;
            txtSurName.Text = user.SurName;


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            user.Id = _user.Id;
            user.Name = txtName.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.SurName = txtSurName.Text;
            user.TeamName= txtTeamName.Text;

            userManager.Update(user);
            UserListForm userListForm = new UserListForm();
            userListForm.Show();
            this.Close();

        }
    }
}
