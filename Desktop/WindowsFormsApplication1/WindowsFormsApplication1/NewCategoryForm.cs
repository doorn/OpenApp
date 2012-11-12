using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class NewCategoryForm : Form
    {
        private int ID;
        private bool editMode;
        public NewCategoryForm(int id)
        {
            this.ID = id;
            InitializeComponent();
            editMode = true;
            EditModeStart(id);
        }
        public NewCategoryForm()
        {
            editMode = false;
            InitializeComponent();
        }
        private void EditModeStart(int ID) {
            DBDataContext ctx = new DBDataContext(Properties.Settings.Default.ConnStr);
            CategoryModel cat = new CategoryModel();
            cat = (from c in ctx.Categories
                                 where c.Id.Equals(ID)
                                 select new CategoryModel
                                 {
                                     Title = c.Title,
                                     ApiUrl = c.ApiUrl
                                 }
                            ).Single();
            
            txtTitle.Text = cat.Title.ToString();
            txtApiUrl.Text = cat.ApiUrl.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((txtTitle.TextLength > 0) && (txtApiUrl.TextLength > 0))
            {
                DBDataContext ctx = new DBDataContext(Properties.Settings.Default.ConnStr);
                if (editMode)
                {
                    Category c = (from cat in ctx.Categories
                                  where cat.Id.Equals(this.ID)
                                  select cat).Single();
                    c.Title = txtTitle.Text;
                    c.ApiUrl = txtApiUrl.Text;
                    ctx.SubmitChanges();
                }
                else
                {
                    Category c = new Category
                    {
                        Title = txtTitle.Text,
                        ApiUrl = txtApiUrl.Text
                    };
                    ctx.Categories.InsertOnSubmit(c);
                    ctx.SubmitChanges();
                }
                this.Close();   
            }
            else {
                MessageBox.Show("You need to have both a title and a url.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
