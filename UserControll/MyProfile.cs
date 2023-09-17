using CRUDEFDay2.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CRUDEFDay2.UserControll
{
    public partial class MyProfile : UserControl
    {
        ITIDbContext db = new ITIDbContext();

        public MyProfile()
        {
            InitializeComponent();
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        byte[] imageData;
        private void MyProfile_Load(object sender, EventArgs e)
        {
            try
            {
                var User = db.Authors.Where(x => x.UserName == UserName && x.Password == Password).SingleOrDefault();

                Author author = new Author()
                {
                    UserName = User.UserName,
                    Age = User.Age,
                    Email = User.Email,
                    Password = User.Password,
                    image = User.image,
                };
               
                txt_name.Text = author.UserName;
                num_age.Value = Convert.ToInt32(author.Age);
                txt_email.Text = author.Email;
                txt_pass.Text = author.Password;
                txt_conpass.Text = author.Password;
                if (author.image != null)
                {
                    using (MemoryStream memoryStream = new MemoryStream(author.image))
                    {
                        pictureBox.Image = Image.FromStream(memoryStream);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Image = new Bitmap(pictureBox.Image, pictureBox.Width, pictureBox.Height);
                    }
                }
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_name.ReadOnly = txt_pass.ReadOnly = txt_email.ReadOnly = txt_conpass.ReadOnly = num_age.ReadOnly = false;

        }
        private void btn_savechanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_pass.Text == txt_conpass.Text)
                {
                    var User = db.Authors.Where(x => x.UserName == UserName && x.Password == Password).SingleOrDefault();
                    User.UserName = txt_name.Text;
                    User.Age = Convert.ToInt32(num_age.Value);
                    User.Email = txt_email.Text;
                    User.Password = txt_pass.Text;
                    User.ConfirmPassword = txt_conpass.Text;
                    
                         User.image = imageData;
                    

                    db.Authors.Update(User);
                    db.SaveChanges();
                    MessageBox.Show("Updated successful!");
                }
                else
                {
                    string message2 = "Password not match";
                    string title2 = "Title";
                    MessageBox.Show(message2, title2);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btn_addimage(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // openFileDialog.Filter = "Image Files (.jpg;.jpeg; .png)|.jpg; .jpeg;.png";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    imageData = File.ReadAllBytes(openFileDialog.FileName);

                    try
                    {
                        pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Image = new Bitmap(pictureBox.Image, pictureBox.Width, pictureBox.Height);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error displaying image: " + ex.Message);
                    }

                }
            }
        }
    }
}

