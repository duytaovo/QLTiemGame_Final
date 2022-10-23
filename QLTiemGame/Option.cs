using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTiemGame
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void btnGDC_Click(object sender, EventArgs e)
        {
            Home frmHome = new Home();
            frmHome.ShowDialog();
        }

        private void btnQLDM_Click(object sender, EventArgs e)
        {
            CategoryManage frmCategory = new CategoryManage();
       /*     this.Hide();*/
            frmCategory.ShowDialog();
        }
    }
}
