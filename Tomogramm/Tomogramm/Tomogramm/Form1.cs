using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tomogramm
{
    public partial class Form1 : Form
    {
        bool loaded = false;
        int currentLayer = 0;
        View view;
        Bin bin;

        int FrameCount;
        DateTime NextFPSUpdate = DateTime.Now.AddSeconds(1);

        bool textureNeedReload = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.bin = new Bin();
            this.view = new View();
            Application.Idle += Application_Idle;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                bin.readBIN(str);
                trackBar1.Maximum = Bin.Z - 1;
                view.SetupView(glControl1.Width, glControl1.Height);
                loaded = true;
                glControl1.Invalidate();
            }
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                if (radioButton1.Checked)
                {
                    view.DrawQuads(currentLayer);
                } else if (radioButton2.Checked)
                {
                    view.DrawStrip(currentLayer);
                } else if (radioButton3.Checked)
                {
                    if (textureNeedReload)
                    {
                        view.generateTextureImage(currentLayer);
                        view.Load2Dexture();
                        textureNeedReload = false;
                    }
                    view.DrawTexture();
                }
                glControl1.SwapBuffers();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentLayer = trackBar1.Value;
            textureNeedReload = true;
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            while (glControl1.IsIdle)
            {
                displayFPS();
                glControl1.Invalidate();
            }
        }

        private void displayFPS()
        {
                if (DateTime.Now >= NextFPSUpdate)
                {
                    this.Text = String.Format("CT Visualizer (fps={0})", FrameCount);
                    NextFPSUpdate = DateTime.Now.AddSeconds(1);
                    FrameCount = 0;
                }
                FrameCount++;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            view.SetMin(trackBar2.Value);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            view.SetWidth(trackBar3.Value*20);
        }
    }
}
