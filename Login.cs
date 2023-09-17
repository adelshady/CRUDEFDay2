using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDEFDay2.Models;
using CRUDEFDay2.UserControll;

namespace CRUDEFDay2
{
    public partial class Login : Form
    {
        private ITIDbContext db = new ITIDbContext();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {


        }



        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_passlogin.Text;
            if (username=="" || password=="" )
            {
                MessageBox.Show("Fill User Name or Password");
            }
            else 
            {
                 var User = db.Authors.Where(x => x.UserName == username && x.Password == password).SingleOrDefault();
                 Profile profile = new Profile();
                 profile.UserName = username;
                 profile.Password = password;
                Post pt = new Post();
                pt.Username = username;
                pt.Password = password;
                profile.Show();
                 this.Hide();
            }
          

        }
    }
}
