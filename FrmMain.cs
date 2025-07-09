using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoMartApplication
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
          
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (Form1.loginname != null)
            {
                toolStripStatusLabel2.Text = Form1.loginname;
            }
            if (Form1.logintype != null && Form1.logintype == "Seller")
            {
                masterToolStripMenuItem.Enabled = false;
                masterToolStripMenuItem.ForeColor = Color.Red;
                productToolStripMenuItem.Enabled = false;
                productToolStripMenuItem.ForeColor = Color.Red;
                addUserToolStripMenuItem.Enabled = false;
                addUserToolStripMenuItem.ForeColor = Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
