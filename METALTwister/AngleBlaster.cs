using METALTwister.Properties;
using M64MM.Utils;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace METALTwister
{
    public partial class AngleBlaster : Form
    {
        static Bitmap anglePrev = null;
        const long addr = 0x33B19C;
        const long frAddr = 0x269BD8;
        byte[] frOn = BitConverter.GetBytes((ushort)0x5FAB);
        byte[] frOff = BitConverter.GetBytes((ushort)0x98D5);
        bool _auto = false;
        public bool AutoEnabled
        {
            get => _auto; set
            {
                if (value)
                {
                    btnAuto.BackgroundImage = Resources.mT_Pause;
                }
                else
                {
                    btnAuto.BackgroundImage = Resources.mT_Repeat;
                }
                _auto = value;
            }
        }
        public AngleBlaster()
        {
            InitializeComponent();
            Imaging.CreateAnglePreview(tbAngle.Value / 10, AutoEnabled, cbFreeRoam.Checked, out anglePrev);
            pbAngleDisplay.Image = anglePrev;
        }

        private uint DegToUInt(double val)
        {
            return (uint)(val / 360 * ushort.MaxValue);
        }

        private void ToggleAuto(object sender, EventArgs e)
        {
            AutoEnabled = !AutoEnabled;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            tbAngle.Value = (int)Math.Round(nudSpecificSet.Value * 10);
        }

        public void AddAngle()
        {
            if (!AutoEnabled) return;

            if (tbAngle.Value + (nudBlaster.Value*10) > tbAngle.Maximum)
            {
                tbAngle.Value += (int)((nudBlaster.Value * 10) - tbAngle.Value);
            }
            else if (tbAngle.Value + (nudBlaster.Value * 10) < 0)
            {
                tbAngle.Value = (int)(tbAngle.Maximum + (nudBlaster.Value * 10));
            }
            else
            {
                tbAngle.Value += (int)(nudBlaster.Value * 10);
            }
        }

        private void tbAngle_ValueChanged(object sender, EventArgs e)
        {
            nudSpecificSet.Value = tbAngle.Value / 10;
            byte[] bytes = BitConverter.GetBytes(DegToUInt(tbAngle.Value / 10));
            Core.WriteBytes(Core.BaseAddress + addr, bytes);
            Imaging.CreateAnglePreview(tbAngle.Value / 10, AutoEnabled, cbFreeRoam.Checked, out anglePrev);
            pbAngleDisplay.Image = anglePrev;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void btnFromGame_Click(object sender, EventArgs e)
        {
            int readVal = BitConverter.ToInt32(Core.ReadBytes(Core.BaseAddress + addr, 4), 0);
            tbAngle.Value = (int)Math.Round(((float)readVal /ushort.MaxValue) * 3600);
        }

        public void ForceFreeRoam()
        {
            if (cbFreeRoam.Checked)
            {
                Core.WriteBytes(Core.BaseAddress + frAddr, frOn);
            }
            else
            {
                Core.WriteBytes(Core.BaseAddress + frAddr, frOff);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout aFrm = new frmAbout();
            aFrm.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/projectcomet64/metal-twister/wiki");
        }
    }
}
