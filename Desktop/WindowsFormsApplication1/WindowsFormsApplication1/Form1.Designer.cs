namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.lstCategoryContent = new System.Windows.Forms.ListBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.newCat = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.deleteContent = new System.Windows.Forms.Button();
            this.editContent = new System.Windows.Forms.Button();
            this.newContent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCategory
            // 
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.Location = new System.Drawing.Point(12, 12);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(152, 342);
            this.lstCategory.TabIndex = 0;
            this.lstCategory.SelectedIndexChanged += new System.EventHandler(this.lstCategory_SelectedIndexChanged);
            // 
            // lstCategoryContent
            // 
            this.lstCategoryContent.FormattingEnabled = true;
            this.lstCategoryContent.Location = new System.Drawing.Point(170, 12);
            this.lstCategoryContent.Name = "lstCategoryContent";
            this.lstCategoryContent.Size = new System.Drawing.Size(167, 342);
            this.lstCategoryContent.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 360);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 389);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // newCat
            // 
            this.newCat.Location = new System.Drawing.Point(12, 418);
            this.newCat.Name = "newCat";
            this.newCat.Size = new System.Drawing.Size(75, 23);
            this.newCat.TabIndex = 6;
            this.newCat.Text = "New";
            this.newCat.UseVisualStyleBackColor = true;
            this.newCat.Click += new System.EventHandler(this.newCat_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 447);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 476);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // deleteContent
            // 
            this.deleteContent.Location = new System.Drawing.Point(262, 418);
            this.deleteContent.Name = "deleteContent";
            this.deleteContent.Size = new System.Drawing.Size(75, 23);
            this.deleteContent.TabIndex = 11;
            this.deleteContent.Text = "Delete";
            this.deleteContent.UseVisualStyleBackColor = true;
            this.deleteContent.Click += new System.EventHandler(this.deleteContent_Click);
            // 
            // editContent
            // 
            this.editContent.Location = new System.Drawing.Point(262, 389);
            this.editContent.Name = "editContent";
            this.editContent.Size = new System.Drawing.Size(75, 23);
            this.editContent.TabIndex = 10;
            this.editContent.Text = "Edit";
            this.editContent.UseVisualStyleBackColor = true;
            this.editContent.Click += new System.EventHandler(this.editContent_Click);
            // 
            // newContent
            // 
            this.newContent.Location = new System.Drawing.Point(262, 360);
            this.newContent.Name = "newContent";
            this.newContent.Size = new System.Drawing.Size(75, 23);
            this.newContent.TabIndex = 9;
            this.newContent.Text = "New";
            this.newContent.UseVisualStyleBackColor = true;
            this.newContent.Click += new System.EventHandler(this.newContent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 522);
            this.Controls.Add(this.deleteContent);
            this.Controls.Add(this.editContent);
            this.Controls.Add(this.newContent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.newCat);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lstCategoryContent);
            this.Controls.Add(this.lstCategory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.ListBox lstCategoryContent;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button newCat;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button deleteContent;
        private System.Windows.Forms.Button editContent;
        private System.Windows.Forms.Button newContent;
    }
}

