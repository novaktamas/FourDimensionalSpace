namespace FourDimensionalSpace
{
    partial class MainWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ZtrackBar3 = new System.Windows.Forms.TrackBar();
            this.YtrackBar2 = new System.Windows.Forms.TrackBar();
            this.XtrackBar1 = new System.Windows.Forms.TrackBar();
            this.Screen = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.XStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.YStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ZSTatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZtrackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YtrackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XtrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Screen)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.infoBox);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.ZtrackBar3);
            this.panel1.Controls.Add(this.YtrackBar2);
            this.panel1.Controls.Add(this.XtrackBar1);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 500);
            this.panel1.TabIndex = 0;
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(3, 365);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.Size = new System.Drawing.Size(232, 130);
            this.infoBox.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 173);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 186);
            this.listBox1.TabIndex = 1;
            // 
            // ZtrackBar3
            // 
            this.ZtrackBar3.Location = new System.Drawing.Point(3, 122);
            this.ZtrackBar3.Maximum = 250;
            this.ZtrackBar3.Minimum = -250;
            this.ZtrackBar3.Name = "ZtrackBar3";
            this.ZtrackBar3.Size = new System.Drawing.Size(232, 45);
            this.ZtrackBar3.TabIndex = 0;
            this.ZtrackBar3.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ZtrackBar3.ValueChanged += new System.EventHandler(this.Trackbar_changed);
            // 
            // YtrackBar2
            // 
            this.YtrackBar2.Location = new System.Drawing.Point(3, 71);
            this.YtrackBar2.Maximum = 250;
            this.YtrackBar2.Minimum = -250;
            this.YtrackBar2.Name = "YtrackBar2";
            this.YtrackBar2.Size = new System.Drawing.Size(232, 45);
            this.YtrackBar2.TabIndex = 0;
            this.YtrackBar2.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.YtrackBar2.ValueChanged += new System.EventHandler(this.Trackbar_changed);
            // 
            // XtrackBar1
            // 
            this.XtrackBar1.Location = new System.Drawing.Point(3, 20);
            this.XtrackBar1.Maximum = 250;
            this.XtrackBar1.Minimum = -250;
            this.XtrackBar1.Name = "XtrackBar1";
            this.XtrackBar1.Size = new System.Drawing.Size(232, 45);
            this.XtrackBar1.TabIndex = 0;
            this.XtrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.XtrackBar1.ValueChanged += new System.EventHandler(this.Trackbar_changed);
            // 
            // Screen
            // 
            this.Screen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Screen.Location = new System.Drawing.Point(272, 31);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(500, 500);
            this.Screen.TabIndex = 1;
            this.Screen.TabStop = false;
            this.Screen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Screen_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XStatus,
            this.YStatus,
            this.ZSTatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // XStatus
            // 
            this.XStatus.Name = "XStatus";
            this.XStatus.Size = new System.Drawing.Size(17, 17);
            this.XStatus.Text = "X:";
            // 
            // YStatus
            // 
            this.YStatus.Name = "YStatus";
            this.YStatus.Size = new System.Drawing.Size(17, 17);
            this.YStatus.Text = "Y:";
            // 
            // ZSTatus
            // 
            this.ZSTatus.Name = "ZSTatus";
            this.ZSTatus.Size = new System.Drawing.Size(17, 17);
            this.ZSTatus.Text = "Z:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FourDimensionalSpace";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZtrackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YtrackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XtrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Screen)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TrackBar ZtrackBar3;
        private System.Windows.Forms.TrackBar YtrackBar2;
        private System.Windows.Forms.PictureBox Screen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel XStatus;
        private System.Windows.Forms.ToolStripStatusLabel YStatus;
        private System.Windows.Forms.ToolStripStatusLabel ZSTatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.TrackBar XtrackBar1;
    }
}

