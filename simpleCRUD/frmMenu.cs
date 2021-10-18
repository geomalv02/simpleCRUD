using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCRUD
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTest frm = new frmTest();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCountry frm = new frmCountry();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
