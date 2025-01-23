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

        private Point startPoint;
        private bool isDragging = false;

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
            Imaging.CreateAnglePreview((float) nudSpecificSet.Value / 10, AutoEnabled, cbFreeRoam.Checked, out anglePrev);
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
            UpdateAngle((int)nudSpecificSet.Value);
        }

        public void AddAngle()
        {
            if (!AutoEnabled) return;

            int newAngle = (int)(getAngleFromGame() + nudBlaster.Value);

            newAngle = ((newAngle % 360) + 360) % 360;

            UpdateAngle(newAngle);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void btnFromGame_Click(object sender, EventArgs e)
        {
            nudSpecificSet.Value = getAngleFromGame();
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

        private void pnlRotBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = e.Location;
            }
        }

        private void pnlRotBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = (e.X - startPoint.X);
                int newAngle = (int) nudSpecificSet.Value - deltaX;
                
                newAngle = ((newAngle % 360) + 360) % 360;

                UpdateAngle(newAngle);

                startPoint = e.Location;
            }
        }

        private void pnlRotBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private int getAngleFromGame()
        {
            int readVal = BitConverter.ToInt32(Core.ReadBytes(Core.BaseAddress + addr, 4), 0);
            return (int)Math.Round(((float)readVal / ushort.MaxValue) * 360);
        }

        private void UpdateAngle(int value)
        {
            nudSpecificSet.Value = value;
            byte[] bytes = BitConverter.GetBytes(DegToUInt(value));
            Core.WriteBytes(Core.BaseAddress + addr, bytes);
            Imaging.CreateAnglePreview(value, AutoEnabled, cbFreeRoam.Checked, out anglePrev);
            pbAngleDisplay.Image = anglePrev;
        }
    }
}
