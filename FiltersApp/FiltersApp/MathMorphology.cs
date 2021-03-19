using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApp
{
    abstract class MathMorphology : Filters
    {
        protected int[,] structuralElement = null;
        protected int radius;
        protected int currentSavedBrightness = 0;
        protected int workerCompositionRatio = 1;
        protected int workerCompositionPosition = 1;

        public MathMorphology() { }

        public MathMorphology(int[,] structuralElement)
        {
            this.structuralElement = structuralElement;
            this.radius = this.structuralElement.GetLength(0) / 2;
        }
        public MathMorphology(int[,] structuralElement, int compositionRatio, int compositionPosition)
        {
            this.structuralElement = structuralElement;
            this.radius = this.structuralElement.GetLength(0) / 2;
            this.workerCompositionRatio = compositionRatio;
            this.workerCompositionPosition = compositionPosition;
        }

        internal override Color CalculatePixel(Bitmap sourceImage, int x, int y)
        {
            Color result = Color.Black;
            this.renewBrightness();
            for (int l = -radius; l <= radius; l++)
            {
                for (int k = -radius; k <= radius; k++)
                {
                    int idX = this.Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = this.Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    int brightness = this.getPixelBrightness(neighborColor);
                    if (this.applyStructuralElementAt(k, l, brightness)) {
                        result = neighborColor;
                    };
                }
            }
            return result;
        }

        // возвращает воспринемаемую яркость RGB пикселя
        internal int getPixelBrightness(Color color) {
            return (int)(0.299 * color.R + 0.587 * color.G + 0.114 * color.B);
        }

        internal abstract bool applyStructuralElementAt(int k, int l, int brightness);
        internal abstract void renewBrightness();

        protected override void ReportProgress(int done, int width, BackgroundWorker worker)
        {
            int onePosition = ((int)(1.0f/this.workerCompositionRatio*100));
            int completedPercentage = (this.workerCompositionPosition - 1) * onePosition;
            int currentProgress = (int)(((float)done / width) * ((float)onePosition / 100)*100);
            worker.ReportProgress((completedPercentage+currentProgress));
        }
    }
}
