using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApp
{
    class IncreaseBrightness : Filters
    {
        internal override Color CalculatePixel(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);

            Color resultColor = Color.FromArgb(
            Clamp((int)(sourceColor.R * 1.5), 0, 255),
            Clamp((int)(sourceColor.G * 1.5), 0, 255),
            Clamp((int)(sourceColor.B * 1.5), 0, 255));
            return resultColor;
        }
    }
}
