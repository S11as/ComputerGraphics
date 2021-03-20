using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApp
{
    class PruittFilter : Filters
    {
        PruittFilterX filterX;
        PruittFilterY filterY;
        public PruittFilter()
        {
            filterX = new PruittFilterX();
            filterY = new PruittFilterY();
        }

        internal override Color CalculatePixel(Bitmap sourceImage, int x, int y)
        {
            // colorX - приблеженная значение производной по x, colorY - по y
            Color colorX = filterX.CalculatePixel(sourceImage, x, y);
            Color colorY = filterY.CalculatePixel(sourceImage, x, y);

            //приближенное значение градиента получатся как g = sqrt(gx*gx+gy*gy)
            int r = this.Clamp((int)Math.Sqrt((colorX.R * colorX.R) + (colorY.R * colorY.R)), 0, 255);
            int g = this.Clamp((int)Math.Sqrt((colorX.G * colorX.G) + (colorY.G * colorY.G)), 0, 255);
            int b = this.Clamp((int)Math.Sqrt((colorX.B * colorX.B) + (colorY.B * colorY.B)), 0, 255);
            return Color.FromArgb(r, g, b);
        }
    }
}
