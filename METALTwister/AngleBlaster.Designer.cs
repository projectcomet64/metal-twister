namespace METALTwister
{
    partial class AngleBlaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AngleBlaster));
            this.btnSet = new System.Windows.Forms.Button();
            this.nudBlaster = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.pnlRotBox = new System.Windows.Forms.Panel();
            this.btnFromGame = new System.Windows.Forms.Button();
            this.nudSpecificSet = new System.Windows.Forms.NumericUpDown();
            this.pbAngleDisplay = new System.Windows.Forms.PictureBox();
            this.gbAuto = new System.Windows.Forms.GroupBox();
            this.btnAuto = new System.Windows.Forms.Button();
            this.gbFreeRoam = new System.Windows.Forms.GroupBox();
            this.cbFreeRoam = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlaster)).BeginInit();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpecificSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAngleDisplay)).BeginInit();
            this.gbAuto.SuspendLayout();
            this.gbFreeRoam.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSet
            // 
            resources.ApplyResources(this.btnSet, "btnSet");
            this.btnSet.Name = "btnSet";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // nudBlaster
            // 
            resources.ApplyResources(this.nudBlaster, "nudBlaster");
            this.nudBlaster.DecimalPlaces = 1;
            this.nudBlaster.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.nudBlaster.Minimum = new decimal(new int[] {
            359,
            0,
            0,
            -2147483648});
            this.nudBlaster.Name = "nudBlaster";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // gbMain
            // 
            resources.ApplyResources(this.gbMain, "gbMain");
            this.gbMain.Controls.Add(this.pnlRotBox);
            this.gbMain.Controls.Add(this.btnFromGame);
            this.gbMain.Controls.Add(this.nudSpecificSet);
            this.gbMain.Controls.Add(this.btnSet);
            this.gbMain.Controls.Add(this.pbAngleDisplay);
            this.gbMain.Name = "gbMain";
            this.gbMain.TabStop = false;
            // 
            // pnlRotBox
            // 
            resources.ApplyResources(this.pnlRotBox, "pnlRotBox");
            this.pnlRotBox.BackgroundImage = global::METALTwister.Properties.Resources.rotation_panel_1;
            this.pnlRotBox.Name = "pnlRotBox";
            this.pnlRotBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlRotBox_MouseDown);
            this.pnlRotBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlRotBox_MouseMove);
            this.pnlRotBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlRotBox_MouseUp);
            // 
            // btnFromGame
            // 
            resources.ApplyResources(this.btnFromGame, "btnFromGame");
            this.btnFromGame.Name = "btnFromGame";
            this.btnFromGame.UseVisualStyleBackColor = true;
            this.btnFromGame.Click += new System.EventHandler(this.btnFromGame_Click);
            // 
            // nudSpecificSet
            // 
            resources.ApplyResources(this.nudSpecificSet, "nudSpecificSet");
            this.nudSpecificSet.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.nudSpecificSet.Name = "nudSpecificSet";
            // 
            // pbAngleDisplay
            // 
            resources.ApplyResources(this.pbAngleDisplay, "pbAngleDisplay");
            this.pbAngleDisplay.Name = "pbAngleDisplay";
            this.pbAngleDisplay.TabStop = false;
            // 
            // gbAuto
            // 
            resources.ApplyResources(this.gbAuto, "gbAuto");
            this.gbAuto.Controls.Add(this.label1);
            this.gbAuto.Controls.Add(this.nudBlaster);
            this.gbAuto.Controls.Add(this.btnAuto);
            this.gbAuto.Controls.Add(this.label2);
            this.gbAuto.Name = "gbAuto";
            this.gbAuto.TabStop = false;
            // 
            // btnAuto
            // 
            resources.ApplyResources(this.btnAuto, "btnAuto");
            this.btnAuto.BackgroundImage = global::METALTwister.Properties.Resources.mT_Repeat;
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.ToggleAuto);
            // 
            // gbFreeRoam
            // 
            resources.ApplyResources(this.gbFreeRoam, "gbFreeRoam");
            this.gbFreeRoam.Controls.Add(this.cbFreeRoam);
            this.gbFreeRoam.Name = "gbFreeRoam";
            this.gbFreeRoam.TabStop = false;
            // 
            // cbFreeRoam
            // 
            resources.ApplyResources(this.cbFreeRoam, "cbFreeRoam");
            this.cbFreeRoam.Name = "cbFreeRoam";
            this.cbFreeRoam.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // AngleBlaster
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFreeRoam);
            this.Controls.Add(this.gbAuto);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AngleBlaster";
            ((System.ComponentModel.ISupportInitialize)(this.nudBlaster)).EndInit();
            this.gbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSpecificSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAngleDisplay)).EndInit();
            this.gbAuto.ResumeLayout(false);
            this.gbAuto.PerformLayout();
            this.gbFreeRoam.ResumeLayout(false);
            this.gbFreeRoam.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.PictureBox pbAngleDisplay;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.NumericUpDown nudBlaster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.GroupBox gbAuto;
        private System.Windows.Forms.GroupBox gbFreeRoam;
        private System.Windows.Forms.CheckBox cbFreeRoam;
        private System.Windows.Forms.NumericUpDown nudSpecificSet;
        private System.Windows.Forms.Button btnFromGame;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel pnlRotBox;
    }
}