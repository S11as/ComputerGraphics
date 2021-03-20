using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltersApp
{
    public partial class Form1 : Form
    {
        protected Bitmap image;
        protected StructuralElementCreator structuralElementCreator;
        protected int[,] structuralElement = null;
        public Form1()
        {
            InitializeComponent();
        }

        public void SetStructuralElement(int[,] arr)
        {
            this.structuralElement = arr;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.structuralElementCreator = new StructuralElementCreator(this);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files (*.*) | *.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                this.image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).ProcessImage(this.image, backgroundWorker1);
            if(backgroundWorker1.CancellationPending != true)
            {
                image = newImage;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }
        private void инверсияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InvertFilter filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlurFilter filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void фильтрГауссаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GaussianFilter filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void фильтрСобеляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SobelFilter filter = new SobelFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void повышениеРезкостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SharpnessFilter filter = new SharpnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void эффектСтеклаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlassFilter filter = new GlassFilter(this.image.Width, this.image.Height);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void волныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WavesFilter filter = new WavesFilter(this.image.Width, this.image.Height);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void размытиеВДвиженииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MotionBlurFilter filter = new MotionBlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void расширениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dilation filter;
            if (this.structuralElement != null)
            {
                filter = new Dilation(structuralElement);
            }
            else
            {
                filter = new Dilation();
            }
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сужениеErosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Erosion filter;
            if (this.structuralElement != null)
            {
                filter = new Erosion(structuralElement);
            }
            else
            {
                filter = new Erosion();
            }
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void размыканиеOpeningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opening filter;
            if (this.structuralElement != null)
            {
                filter = new Opening(structuralElement);
            }
            else
            {
                filter = new Opening();
            }
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void замыканиеClosingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Closing filter;
            if (this.structuralElement != null)
            {
                filter = new Closing(structuralElement);
            }
            else
            {
                filter = new Closing();
            }
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void задатьСтруктурныйЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            structuralElementCreator.Refresh();
            structuralElementCreator.Show();
        }

        private void gradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grad filter;
            if (this.structuralElement != null)
            {
                filter = new Grad(structuralElement);
            }
            else
            {
                filter = new Grad();
            }
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void серыйМирToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayWorldFilter filter = new GrayWorldFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void медианныйФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedianFilter filter = new MedianFilter(2);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void операторПрюиттаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PruittFilter filter = new PruittFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}
