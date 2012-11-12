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
    public partial class ContentForm : Form
    {
        private int contentID;
        private int catID;
        private bool editMode;
        public ContentForm(int catId)
        {
            this.catID = catId;
            InitializeComponent();
            editMode = false;
        }
        public ContentForm(int id, int catId)
        {
            this.contentID = id;
            this.catID = catId;
            InitializeComponent();
            editMode = true;
            EditModeStart(id);
        }
        private void EditModeStart(int ID)
        {
            DBDataContext ctx = new DBDataContext(Properties.Settings.Default.ConnStr);
            ContentModel cat = new ContentModel();
            cat = (from c in ctx.CategoryContents
                   where c.Id.Equals(ID)
                   select new ContentModel
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
                    CategoryContent c = (from cat in ctx.CategoryContents
                                  where cat.Id.Equals(this.contentID)
                                  select cat).Single();
                    c.Title = txtTitle.Text;
                    c.ApiUrl = txtApiUrl.Text;
                    ctx.SubmitChanges();
                }
                else
                {
                    CategoryContent c = new CategoryContent
                    {
                        Title = txtTitle.Text,
                        ApiUrl = txtApiUrl.Text,
                        CatId = this.catID
                    };
                    ctx.CategoryContents.InsertOnSubmit(c);
                    ctx.SubmitChanges();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("You need to have both a title and a url.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
