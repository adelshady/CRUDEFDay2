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
    public partial class Post : UserControl
    {
        ITIDbContext db = new ITIDbContext();

        public Post()
        {
            InitializeComponent();

        }
        public string Username { get; set; }
        public string Password { get; set; }
        byte[] imageData;

        private void Post_Load(object sender, EventArgs e)
        {
            dgv_post.DataSource = db.Posts.Include(x => x.Author).Include(x => x.Category).Where(x => x.Author.UserName == Username && x.Author.Password == Password).ToList();
            Btn_Edit.Hide();

            GetData();
        }
        void GetData()
        {
            var category = db.Categories.ToList();
            cb_category.DataSource = category;
            cb_category.ValueMember = "ID";
            cb_category.DisplayMember = "Name";
            dgv_post.DataSource = db.Posts.Include(x => x.Author).Include(x => x.Category).Where(x => x.Author.UserName == Username && x.Author.Password == Password).ToList();

        }
        int postId = 0;
        private void btn_addpost(object sender, EventArgs e)
        {
            var auther = db.Authors.Where(x => x.UserName == Username && x.Password == Password).SingleOrDefault();
            var postauther = db.Posts.Include(x => x.Author).ToList();

            try
            {
                DateTime dt = date_time.Value;
                if(txt_title.Text!="" && txt_desc.Text != "" && txt_bref.Text != "")
                {

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
                        pic_box.Image = Image.FromStream(memoryStream);
                        pic_box.SizeMode = PictureBoxSizeMode.Zoom;
                        pic_box.Image = new Bitmap(pic_box.Image, pic_box.Width, pic_box.Height);
                    }
                }

                
                db.Posts.Add(pt);
                db.SaveChanges();
                MessageBox.Show("Added ");
                dgv_post.DataSource = db.Posts.Include(x => x.Author)
                    .Where(x => x.Author.UserName == Username && x.Author.Password == Password).ToList();
                txt_bref.Text = txt_desc.Text = txt_title.Text = "";

                }
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
                Btn_Edit.Hide();
                GetData();
                txt_bref.Text = txt_desc.Text = txt_title.Text = "";
                cb_category.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgv_post_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                            pic_box.Image = Image.FromStream(memoryStream);
                            pic_box.SizeMode = PictureBoxSizeMode.Zoom;
                            pic_box.Image = new Bitmap(pic_box.Image, pic_box.Width, pic_box.Height);
                        }
                    }
                    cb_category.SelectedValue = Convert.ToInt32(row.Cells[9].Value);
                    Btn_Add.Hide();
                }
                else
                {
                    MessageBox.Show("Show only not edit");
                    Btn_Edit.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
                            pic_box.Image = Image.FromFile(openFileDialog.FileName);
                            pic_box.SizeMode = PictureBoxSizeMode.Zoom;
                            pic_box.Image = new Bitmap(pic_box.Image, pic_box.Width, pic_box.Height);
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
    }
}
