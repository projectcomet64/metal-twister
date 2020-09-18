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
            this.tbAngle = new System.Windows.Forms.TrackBar();
            this.btnSet = new System.Windows.Forms.Button();
            this.nudBlaster = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbMain = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.tbAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlaster)).BeginInit();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpecificSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAngleDisplay)).BeginInit();
            this.gbAuto.SuspendLayout();
            this.gbFreeRoam.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAngle
            // 
            this.tbAngle.Location = new System.Drawing.Point(112, 74);
            this.tbAngle.Maximum = 3600;
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(361, 45);
            this.tbAngle.TabIndex = 11;
            this.tbAngle.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAngle.ValueChanged += new System.EventHandler(this.tbAngle_ValueChanged);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(251, 48);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(79, 20);
            this.btnSet.TabIndex = 13;
            this.btnSet.Text = "Set Angle";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // nudBlaster
            // 
            this.nudBlaster.DecimalPlaces = 1;
            this.nudBlaster.Location = new System.Drawing.Point(74, 24);
            this.nudBlaster.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudBlaster.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nudBlaster.Name = "nudBlaster";
            this.nudBlaster.Size = new System.Drawing.Size(86, 20);
            this.nudBlaster.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Spin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "degrees/frame";
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.btnFromGame);
            this.gbMain.Controls.Add(this.nudSpecificSet);
            this.gbMain.Controls.Add(this.tbAngle);
            this.gbMain.Controls.Add(this.btnSet);
            this.gbMain.Controls.Add(this.pbAngleDisplay);
            this.gbMain.Location = new System.Drawing.Point(12, 27);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(479, 128);
            this.gbMain.TabIndex = 16;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Angle Control";
            // 
            // btnFromGame
            // 
            this.btnFromGame.Location = new System.Drawing.Point(336, 48);
            this.btnFromGame.Name = "btnFromGame";
            this.btnFromGame.Size = new System.Drawing.Size(105, 20);
            this.btnFromGame.TabIndex = 17;
            this.btnFromGame.Text = "Read from game";
            this.btnFromGame.UseVisualStyleBackColor = true;
            this.btnFromGame.Click += new System.EventHandler(this.btnFromGame_Click);
            // 
            // nudSpecificSet
            // 
            this.nudSpecificSet.Location = new System.Drawing.Point(159, 48);
            this.nudSpecificSet.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudSpecificSet.Name = "nudSpecificSet";
            this.nudSpecificSet.Size = new System.Drawing.Size(86, 20);
            this.nudSpecificSet.TabIndex = 16;
            // 
            // pbAngleDisplay
            // 
            this.pbAngleDisplay.Location = new System.Drawing.Point(6, 19);
            this.pbAngleDisplay.Name = "pbAngleDisplay";
            this.pbAngleDisplay.Size = new System.Drawing.Size(100, 100);
            this.pbAngleDisplay.TabIndex = 12;
            this.pbAngleDisplay.TabStop = false;
            // 
            // gbAuto
            // 
            this.gbAuto.Controls.Add(this.label1);
            this.gbAuto.Controls.Add(this.nudBlaster);
            this.gbAuto.Controls.Add(this.btnAuto);
            this.gbAuto.Controls.Add(this.label2);
            this.gbAuto.Location = new System.Drawing.Point(12, 161);
            this.gbAuto.Name = "gbAuto";
            this.gbAuto.Size = new System.Drawing.Size(305, 64);
            this.gbAuto.TabIndex = 17;
            this.gbAuto.TabStop = false;
            this.gbAuto.Text = "Auto Control";
            // 
            // btnAuto
            // 
            this.btnAuto.BackgroundImage = global::METALTwister.Properties.Resources.mT_Repeat;
            this.btnAuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAuto.Location = new System.Drawing.Point(251, 10);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(48, 48);
            this.btnAuto.TabIndex = 10;
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.ToggleAuto);
            // 
            // gbFreeRoam
            // 
            this.gbFreeRoam.Controls.Add(this.cbFreeRoam);
            this.gbFreeRoam.Location = new System.Drawing.Point(323, 161);
            this.gbFreeRoam.Name = "gbFreeRoam";
            this.gbFreeRoam.Size = new System.Drawing.Size(168, 64);
            this.gbFreeRoam.TabIndex = 18;
            this.gbFreeRoam.TabStop = false;
            this.gbFreeRoam.Text = "Free Roam Mode";
            // 
            // cbFreeRoam
            // 
            this.cbFreeRoam.AutoSize = true;
            this.cbFreeRoam.Location = new System.Drawing.Point(55, 27);
            this.cbFreeRoam.Name = "cbFreeRoam";
            this.cbFreeRoam.Size = new System.Drawing.Size(59, 17);
            this.cbFreeRoam.TabIndex = 0;
            this.cbFreeRoam.Text = "Enable";
            this.cbFreeRoam.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // AngleBlaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 234);
            this.Controls.Add(this.gbFreeRoam);
            this.Controls.Add(this.gbAuto);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AngleBlaster";
            this.Text = "METAL Twister";
            ((System.ComponentModel.ISupportInitialize)(this.tbAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlaster)).EndInit();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
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
        private System.Windows.Forms.TrackBar tbAngle;
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
    }
}