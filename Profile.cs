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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CRUDEFDay2
{
    public partial class Profile : Form
    {
        private ITIDbContext db = new ITIDbContext();
        public string UserName { get; set; }
        public string Password { get; set; }
        public Profile()
        {
            InitializeComponent();
        }


        private void Profile_Load(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }



        private void btn_catlog(object sender, EventArgs e)
        {

            //var cat = db.Categories.ToList();
            Catalog ca = new Catalog();
           // ca.Categories = cat;

            addUserControl(ca);
        }

        private void btn_post(object sender, EventArgs e)
        {
            // var Posts = db.Posts.ToList();
            Post pos = new Post();
            pos.Username = UserName;
            pos.Password = Password;
            addUserControl(pos);
        }

        private void btn_profile(object sender, EventArgs e)
        {

            MyProfile uc = new MyProfile();
            uc.UserName = UserName;
            uc.Password = Password;
            addUserControl(uc);
        }

        private void btn_Allpost(object sender, EventArgs e)
        {
            AllPosts posts = new AllPosts();
            posts.Username = UserName;
            posts.Password = Password;
            addUserControl(posts);
        }
    }
}
