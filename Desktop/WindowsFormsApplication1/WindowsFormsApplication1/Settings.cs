using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            txtConnStr.Text = Properties.Settings.Default.ConnStr.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ConnStr = txtConnStr.Text;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
