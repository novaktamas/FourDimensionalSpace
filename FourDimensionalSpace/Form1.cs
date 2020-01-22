using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourDimensionalSpace
{
    public partial class MainWindow : Form
    {
        ThreeD td = new ThreeD();
        Camera cam = new Camera(0,0,0,0,0,0,2);

        public MainWindow()
        {
            InitializeComponent();
            this.Screen.MouseWheel += Screen_MouseWheel;
        }



        public void Trackbar_changed(object sender, EventArgs e)
        {
            XStatus.Text = "X: " + XtrackBar1.Value;
            YStatus.Text = "Y: " + YtrackBar2.Value;
            ZSTatus.Text = "Z: " + ZtrackBar3.Value;
            cam.XPOV = XtrackBar1.Value;
            cam.YPOV = YtrackBar2.Value;
            cam.ZPOV = ZtrackBar3.Value;

            Showgrp(); 
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {


            Reading();
            Showgrp();
            
        }
        public void Reading()
        {
            foreach(Voxel vx in td.space)
            {
                infoBox.Text += "X: " + vx.PX + " Y: " + vx.PY + " Z: " + vx.PZ + Environment.NewLine ;
                   }
        }

        public void Showgrp()
        {
            Voxel vx1, vx2,vx3,vx4;
            vx1 = new Voxel(0,0,0);
            vx2 = new Voxel(100,0,0);
            vx3 = new Voxel(100,0,100);
            vx4 = new Voxel(0,0,100);
            //négyzet
            Bitmap bmp = new Bitmap(Screen.Width, Screen.Height);
            Graphics grp = Graphics.FromImage(bmp);
            grp.DrawLine(Pens.Black, td.Computing(vx1, cam), td.Computing(vx2, cam));
            grp.DrawLine(Pens.Black, td.Computing(vx2, cam), td.Computing(vx3, cam));
            grp.DrawLine(Pens.Black, td.Computing(vx3, cam), td.Computing(vx4, cam));
            grp.DrawLine(Pens.Black, td.Computing(vx1, cam), td.Computing(vx4, cam));
            Screen.Image = bmp;
            infoBox.Text = td.Computing(vx3, cam).ToString();
        }
        private void Screen_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {

                XtrackBar1.Value = e.X-250;
                YtrackBar2.Value = e.Y-250;
            }
            catch
            {
            }
        }
        private void Screen_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Delta > 0)
                {
                    ZtrackBar3.Value += 5;
                                    }
                else
                {
                    ZtrackBar3.Value -= 5;
                }
            }
            catch { }
        }
    }
}
