using CRUDEFDay2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDEFDay2.UserControll
{
    public partial class AllPosts : UserControl
    {
        ITIDbContext db = new ITIDbContext();
        public AllPosts()
        {
            InitializeComponent();
        }
        byte[] imageData;
        public string Username { get; set; }
        public string Password { get; set; }
        private void AllPosts_Load(object sender, EventArgs e)
        {
            dgv_post.DataSource = db.Posts.Include(x => x.Author).Include(x => x.Category).ToList();
            Btn_Edit.Hide();
            GetData();
        }

        void GetData()
        {
            var category = db.Categories.ToList();
            cb_category.DataSource = category;
            cb_category.ValueMember = "ID";
            cb_category.DisplayMember = "Name";
            dgv_post.DataSource = db.Posts.Include(x => x.Author).Include(x => x.Category).ToList();

        }
        int postId = 0;
        private void btn_addpost(object sender, EventArgs e)
        {
            var auther = db.Authors.Where(x => x.UserName == Username && x.Password == Password).SingleOrDefault();
            var postauther = db.Posts.Include(x => x.Author).ToList();
            try
            {
                DateTime dt = date_time.Value;

                post pt = new post()
                {
                    Title = txt_title.Text,
                    Bref = txt_bref.Text,
                    Date = dt,
                    Time = dt.TimeOfDay,
                    Desc = txt_desc.Text,
                    CategoryId = Convert.ToInt32(cb_category.SelectedValue),
                    AutherId = auther.ID,
                    image = imageData,
                };
                if (pt.image != null)
                {
                    using (MemoryStream memoryStream = new MemoryStream(pt.image))
                    {
                        pictureBox.Image = Image.FromStream(memoryStream);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Image = new Bitmap(pictureBox.Image, pictureBox.Width, pictureBox.Height);
                    }
                }
                db.Posts.Add(pt);
                db.SaveChanges();
                MessageBox.Show("Added ");
                dgv_post.DataSource = db.Posts.Include(x => x.Author).ToList();
                txt_bref.Text = txt_desc.Text = txt_title.Text = "";

            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }

        }

        private void btn_edit(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Now;
                date_time.Hide();
                var itemPost = db.Posts.Where(x => x.ID == postId).SingleOrDefault();
                itemPost.Title = txt_title.Text;
                itemPost.Desc = txt_desc.Text;
                itemPost.Bref = txt_bref.Text;
                itemPost.Date = dt;
                itemPost.Time = dt.TimeOfDay;
                itemPost.CategoryId = Convert.ToInt32(cb_category.SelectedValue);
                itemPost.image = imageData; 
                db.Posts.Update(itemPost);
                db.SaveChanges();
                MessageBox.Show("Updated");
                Btn_Add.Show();
                GetData();
                txt_bref.Text = txt_desc.Text = txt_title.Text = "";
                cb_category.DataSource = null;
                pictureBox.Image = null;
                Btn_Edit.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_post_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btn_addimage(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgv_post_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgv_post_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var auther = db.Authors.Where(x => x.UserName == Username && x.Password == Password).SingleOrDefault();
                DataGridViewRow row = dgv_post.Rows[e.RowIndex];
                if (auther.ID == Convert.ToInt32(row.Cells[7].Value))
                {
                    Btn_Edit.Show();
                    postId = (int)row.Cells[0].Value;
                    txt_title.Text = row.Cells[1].Value.ToString();

                    txt_bref.Text = row.Cells[2].Value.ToString();
                    txt_desc.Text = row.Cells[3].Value.ToString();

                    var image = row.Cells[6].Value as Byte[];
                    if (image != null)
                    {
                        using (MemoryStream memoryStream = new MemoryStream(image))
                        {

                            pictureBox.Image = Image.FromStream(memoryStream);
                            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox.Image = new Bitmap(pictureBox.Image, pictureBox.Width, pictureBox.Height);
                        }
                    }
                    cb_category.SelectedValue = Convert.ToInt32(row.Cells[9].Value);
                    Btn_Add.Hide();

                }
                else
                {
                    MessageBox.Show("Show only not edit");
                    Btn_Edit.Hide();
                    txt_bref.Text = txt_desc.Text = txt_title.Text = "";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
