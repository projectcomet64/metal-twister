using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace METALTwister
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lbVer.Text = $"v{ProductVersion}";
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            Process.Start("https://comet.glitchypsi.xyz");
        }

        private void btnWiki_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/projectcomet64/metal-twister/wiki");
        }
    }
}
