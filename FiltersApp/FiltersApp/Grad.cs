using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApp
{
    class Grad : MathMorphology
    {
        protected Dilation diliation;
        protected Erosion erosion;

        public Grad()
        {
            this.structuralElement = new int[,] { { 0, 1, 0 }, { 1, 1, 1 }, { 0, 1, 0 } };
            this.diliation = new Dilation(structuralElement, 3, 1);
            this.erosion = new Erosion(structuralElement, 3, 2);
            this.workerCompositionRatio = 3;
            this.workerCompositionPosition = 3;
        }

        public Grad(int[,] structuralElement)
        {
            this.structuralElement = structuralElement;
            this.diliation = new Dilation(structuralElement, 3, 1);
            this.erosion = new Erosion(structuralElement, 3, 2);
        }

        // grad(i) = diliation(i)-erosion(i)
        public override Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            Bitmap dil = diliation.ProcessImage(sourceImage, worker);
            Bitmap eros = erosion.ProcessImage(sourceImage, worker);
            for(int i=0;i<sourceImage.Width; i++)
            {
                this.ReportProgress(i, sourceImage.Width, worker);
                if (worker.CancellationPending)
                    return null;
                for (int j=0; j<sourceImage.Height; j++)
                {
                    Color dilPixel = dil.GetPixel(i, j);
                    Color erosPixel = eros.GetPixel(i, j);
                    int r = this.Clamp(dilPixel.R-erosPixel.R, 0, 255);
                    int g = this.Clamp(dilPixel.G-erosPixel.G, 0, 255);
                    int b = this.Clamp(dilPixel.B - erosPixel.B, 0, 255);
                    resultImage.SetPixel(i, j, Color.FromArgb(r, g, b));
                    
                }
            }
            return resultImage;
        }
        internal override bool applyStructuralElementAt(int k, int l, int brightness){ return false; }

        internal override void renewBrightness(){}
    }
}
