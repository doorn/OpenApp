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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DBDataContext GetDataContext() {
            return new DBDataContext(Properties.Settings.Default.ConnStr);
        }
        private void populateCategoryListBox(List<CategoryModel> cats)
        {
            lstCategory.DataSource = cats;
            lstCategory.DisplayMember = "Title";
            lstCategory.ValueMember = "ID";

        }
        private void populateContentListBox(List<ContentModel> cats)
        {
            lstCategoryContent.DataSource = cats;
            lstCategoryContent.DisplayMember = "Title";
            lstCategoryContent.ValueMember = "ID";

        }
        private void UpdateCategories() {
            populateCategoryListBox(GetCategories());
        }
        private void UpdateContent() {
            populateContentListBox(GetCategoryContent());
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            UpdateCategories();
        }
        private List<CategoryModel> GetCategories()
        {
            DBDataContext ctx = GetDataContext();
            List<CategoryModel> cats = (from c in ctx.Categories
                                        select new CategoryModel
                                        {
                                            ID = c.Id,
                                            Title = c.Title,
                                            ApiUrl = c.ApiUrl
                                        }
                                       ).ToList();
            return cats;
        }
        private List<ContentModel> GetCategoryContent()
        {
            DBDataContext ctx = GetDataContext();
            List<ContentModel> contents = (from c in ctx.CategoryContents
                                       select new ContentModel
                                        {
                                            ID = c.Id,
                                            Title = c.Title,
                                            ApiUrl = c.ApiUrl
                                        }
                                       ).ToList();
            return contents;
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            ShowSettingsDialog();
        }
        private void newCat_Click(object sender, EventArgs e)
        {
            ShowNewCategoryDialog();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            ShowEditCategoryDialog();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Sure you want to delete selected category?","Delete?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                DBDataContext ctx = GetDataContext();
                List<int> contents = (from c in ctx.CategoryContents
                                      where c.CatId.Equals(int.Parse(lstCategory.SelectedValue.ToString()))
                                      select c.Id).ToList();

                if (contents.Count > 0)
                {
                    DialogResult res2 = MessageBox.Show("This category contains content that will be deleted, do you want to continue?", "Delete content?", MessageBoxButtons.YesNo);
                    if (res2 == DialogResult.Yes)
                    {
                        foreach (int i in contents)
                        {
                            CategoryContent conCat = (ctx.CategoryContents.Where(c => c.Id.Equals(i))).Single();
                            ctx.CategoryContents.DeleteOnSubmit(conCat);
                        }
                    }
                    Category category = (ctx.Categories.Where(c => c.Id.Equals(int.Parse(lstCategory.SelectedValue.ToString())))).Single();
                    ctx.Categories.DeleteOnSubmit(category);
                    ctx.SubmitChanges();
                    UpdateCategories();
                }
                else {
                    Category category = (ctx.Categories.Where(c => c.Id.Equals(int.Parse(lstCategory.SelectedValue.ToString())))).Single();
                    ctx.Categories.DeleteOnSubmit(category);
                    ctx.SubmitChanges();
                    UpdateCategories();
                }
            }
        }


#region Dialogs
        public void ShowSettingsDialog()
        {
            Settings form = new Settings();
            form.FormClosed += form_FormClosed;
            form.Show();
        }
        public void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            populateCategoryListBox(GetCategories());
        }


        private void ShowNewCategoryDialog()
        {
            NewCategoryForm form = new NewCategoryForm();
            form.FormClosed += form_FormClosed;                         
            form.Show();
        }
        private void ShowEditCategoryDialog()
        {
            NewCategoryForm form = new NewCategoryForm(int.Parse(lstCategory.SelectedValue.ToString()));
            form.FormClosed += form_FormClosed;
            form.Show();
        }
#endregion 

        private void newContent_Click(object sender, EventArgs e)
        {
            ContentForm contentForm = new ContentForm(int.Parse(lstCategory.SelectedValue.ToString()));
            contentForm.FormClosed += contentForm_FormClosed;
            contentForm.Show();
        }

        void contentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateContent();
        }

        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateContent();
        }

        private void deleteContent_Click(object sender, EventArgs e)
        {
             DialogResult res = MessageBox.Show("Sure you want to delete selected content?","Delete?", MessageBoxButtons.YesNo);
             if (res == DialogResult.Yes)
             {
                 DBDataContext ctx = GetDataContext();
                 CategoryContent content = (from c in ctx.CategoryContents
                                       where c.CatId.Equals(int.Parse(lstCategory.SelectedValue.ToString()))
                                       select c).Single();
                 ctx.CategoryContents.DeleteOnSubmit(content);
                 ctx.SubmitChanges();
                 UpdateContent();
             }
        }

        private void editContent_Click(object sender, EventArgs e)
        {
            ContentForm contentForm = new ContentForm(int.Parse(lstCategoryContent.SelectedValue.ToString()), int.Parse(lstCategory.SelectedValue.ToString()));
            contentForm.FormClosed += contentForm_FormClosed;
            contentForm.Show();
        }
    }
}
