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

namespace CRUDEFDay2.UserControll
{
    public partial class Catalog : UserControl
    {
        ITIDbContext db = new ITIDbContext();
        public Catalog()
        {
            InitializeComponent();
        }
        //public List<Category> Categories { get; set; }
        int catid = 0;
        private void Catalog_Load(object sender, EventArgs e)
        {
            Btn_Edit.Hide();

            GetData();
        }
        void GetData()
        {
            dgv_category.DataSource = db.Categories.ToList();

        }
        private void btn_add(object sender, EventArgs e)
        {
            try
            {
                if (txt_catdesc.Text != "" && txt_catname.Text != "")
                {
                    Category cat = new Category()
                    {
                        Name = txt_catname.Text,
                        Desc = txt_catdesc.Text,
                    };

                    db.Categories.Add(cat);
                    db.SaveChanges();
                    GetData();
                    txt_catname.Text = txt_catdesc.Text = "";
                    MessageBox.Show("Add successfully");
                }
                else
                {
                    MessageBox.Show("Fill the item ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn_edit(object sender, EventArgs e)
        {

            try
            {
                var itemcat = db.Categories.Where(x => x.ID == catid).SingleOrDefault();
                itemcat.Name = txt_catname.Text;
                itemcat.Desc = txt_catdesc.Text;

                db.Categories.Update(itemcat);
                db.SaveChanges();

                MessageBox.Show("Updated");
                GetData();
                Btn_Edit.Hide();
                Btn_Add.Show();
                txt_catname.Text = txt_catdesc.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void dgv_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_category.Rows[e.RowIndex];

            catid = (int)row.Cells[0].Value;
            txt_catname.Text = row.Cells[1].Value.ToString();
            txt_catdesc.Text = row.Cells[2].Value.ToString();
            Btn_Edit.Show();
            Btn_Add.Hide();

        }
    }
}
