using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApp
{
    class SepiaFilter : Filters
    {
        internal override Color CalculatePixel(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            double intensity = 0.36 * sourceColor.R + 0.53 * sourceColor.G + 0.11 * sourceColor.B;
            double resultR = intensity + 2 * 30;
            double resultG = intensity + 0.5 * 30;
            double resultB = intensity - 1 * 30;

            Color resultColor = Color.FromArgb(
                Clamp((int)resultR, 0, 255),
                Clamp((int)resultG, 0, 255),
                Clamp((int)resultB, 0, 255));
            return resultColor;
        }
    }
}
