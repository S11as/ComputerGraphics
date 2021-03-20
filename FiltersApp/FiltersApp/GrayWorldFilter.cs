using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApp
{
    class GrayWorldFilter : Filters
    {
        float averageR = 0;
        float averageG = 0;
        float averageB = 0;
        float average = 0;
        public override Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                this.ReportProgress(i, resultImage.Width, worker, 2, 1);
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color pixel = sourceImage.GetPixel(i, j);
                    averageR += pixel.R;
                    averageG += pixel.G;
                    averageB += pixel.B;
                }
            }
            int pixels = sourceImage.Width * sourceImage.Height;
            averageR /= pixels;
            averageG /= pixels;
            averageB /= pixels;
            average = (averageR + averageG + averageB) / 3;


            for (int i = 0; i < sourceImage.Width; i++)
            {
                this.ReportProgress(i, resultImage.Width, worker, 2, 2);
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, this.CalculatePixel(sourceImage, i, j));
                }
            }
            return resultImage;
        }
        internal override Color CalculatePixel(Bitmap sourceImage, int x, int y)
        {
            Color pixel = sourceImage.GetPixel(x, y);
            int r = Clamp((int)(pixel.R * average / averageR), 0, 255);
            int g = Clamp((int)(pixel.G * average / averageG), 0, 255);
            int b = Clamp((int)(pixel.B * average / averageB), 0, 255);
            return Color.FromArgb(r, g, b);
        }

        protected void ReportProgress(int done, int width, BackgroundWorker worker, int ratio, int position)
        {
            int onePosition = ((int)(1.0f / ratio * 100));
            int completedPercentage = (position - 1) * onePosition;
            int currentProgress = (int)(((float)done / width) * ((float)onePosition / 100) * 100);
            worker.ReportProgress((completedPercentage + currentProgress));
        }
    }
}
