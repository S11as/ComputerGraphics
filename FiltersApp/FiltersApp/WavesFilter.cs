using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApp
{
    class WavesFilter : Filters
    {
        int maxWidth;
        int maxHeight;
        public WavesFilter(int w, int h)
        {
            this.maxWidth = w - 1;
            this.maxHeight = h - 1;
        }
        internal override Color CalculatePixel(Bitmap sourceImage, int x, int y)
        {
            int newX = this.Clamp((int)(x + 20 * Math.Sin(2 * Math.PI * y / 40)), 0, this.maxWidth);
            int newY = y;
            return sourceImage.GetPixel(newX, newY);
        }
    }
}
