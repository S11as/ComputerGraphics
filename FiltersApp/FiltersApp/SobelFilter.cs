using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApp
{
    class SobelFilter : Filters
    {
        SobelFilterX filterX;
        SobelFilterY filterY;
        public SobelFilter()
        {
            filterX = new SobelFilterX();
            filterY = new SobelFilterY();
        }
        //    Оператор вычисляет градиент яркости изображения в каждой точке. 
        //    Так находится направление наибольшего увеличения яркости и величина её изменения в этом направлении.
        //    Результат показывает, насколько «резко» или «плавно» меняется яркость изображения в каждой точке, а значит, 
        //    вероятность нахождения точки на грани
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
