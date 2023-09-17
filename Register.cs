using CRUDEFDay2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDEFDay2
{
    public partial class Register : Form
    {
        private ITIDbContext db = new ITIDbContext();
        public Register()
        {
            InitializeComponent();
        }
        ValidateUser ValidateUser = new ValidateUser();
        byte[] imageData;
        private void Register_Load(object sender, EventArgs e)
        {


        }
        private void btn_signup_Click(object sender, EventArgs e)
        {
            Author author = new Author()
            {
                UserName = txt_name.Text,
                Age = Convert.ToInt32(num_age.Value),
                Email = txt_email.Text,
                Password = txt_pass.Text,
                ConfirmPassword = txt_conpass.Text,
                image = imageData,

            };

            if (ValidateUser.ValidateEmail(author.Email) && ValidateUser.ValidatePassword(author.Password) && ValidateUser.IsUserNameValid(author.UserName, db) && ValidateUser.ValidateAge(author.Age))
            {
                db.Authors.Add(author);
                db.SaveChanges();
                MessageBox.Show("Registration successful!");

                txt_name.Text = txt_email.Text = txt_pass.Text = txt_conpass.Text = "";
                num_age.Value = 0;
            }

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_addimage(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

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
