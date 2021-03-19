using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FiltersApp
{
    abstract class Filters
    {
        internal abstract Color CalculatePixel(Bitmap sourceImage, int x, int y);
        public virtual Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for(int i=0; i<sourceImage.Width; i++)
            {
                this.ReportProgress(i, resultImage.Width, worker);
                if(worker.CancellationPending)
                    return null;
                for(int j=0; j<sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, this.CalculatePixel(sourceImage, i, j));
                }
            }
            return resultImage;
        }

        public int Clamp(int value, int min, int max)
        {
            if(value < min)
            {
                return min;
            }else if (value > max)
            {
                return max;
            }
            return value;
        }

        protected virtual void ReportProgress(int done, int width, BackgroundWorker worker)
        {
            worker.ReportProgress((int)((float)done / width * 100));
        }
    }
}
