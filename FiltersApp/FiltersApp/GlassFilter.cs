using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApp
{
  
    class GlassFilter : Filters
    {
        int maxWidth;
        int maxHeight;
        Random rand;
        public GlassFilter(int w, int h)
        {
            this.maxWidth = w-1;
            this.maxHeight = h-1;
            this.rand = new Random();
        }

        internal override Color CalculatePixel(Bitmap sourceImage, int x, int y)
        {
            int newX = this.Clamp((int)(x + (rand.NextDouble() - 0.5) * 10), 0, this.maxWidth);
            int newY = this.Clamp((int)(y + (rand.NextDouble() - 0.5) * 10), 0, this.maxHeight);
            return sourceImage.GetPixel(newX, newY);
        }
    }
}
