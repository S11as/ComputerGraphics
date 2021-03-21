using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApp
{
    class LinearTension : Filters
    {
        int minBrightness = 255;
        int maxBrightness = 0;
        float brightnessRatio;
        
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
                    int brightness = getPixelBrightness(pixel);
                    if(brightness > maxBrightness){
                        maxBrightness = brightness;
                    }else if (brightness < minBrightness)
                    {
                        minBrightness = brightness;
                    }
                }
            }

            brightnessRatio = 255 / (maxBrightness - minBrightness);

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
            int brightness = getPixelBrightness(pixel);
            int correctionBrightness = (int)(Clamp(brightness - minBrightness, 0, 255) * brightnessRatio);
            int r = Clamp(pixel.R + correctionBrightness, 0, 255);
            int g = Clamp(pixel.G + correctionBrightness, 0, 255);
            int b = Clamp(pixel.B + correctionBrightness, 0, 255);
            return Color.FromArgb(r, g, b);
        }

        protected void ReportProgress(int done, int width, BackgroundWorker worker, int ratio, int position)
        {
            int onePosition = ((int)(1.0f / ratio * 100));
            int completedPercentage = (position - 1) * onePosition;
            int currentProgress = (int)(((float)done / width) * ((float)onePosition / 100) * 100);
            worker.ReportProgress((completedPercentage + currentProgress));
        }

        internal int getPixelBrightness(Color color)
        {
            return (int)(0.299 * color.R + 0.587 * color.G + 0.114 * color.B);
        }
    }
}
