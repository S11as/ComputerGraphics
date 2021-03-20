using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApp
{
    class MedianFilter : Filters
    {

        protected int radius;
        public MedianFilter(int r)
        {
            this.radius = r;
        }
        internal override Color CalculatePixel(Bitmap sourceImage, int x, int y)
        {
            List<int> rs = new List<int>();
            List<int> gs = new List<int>();
            List<int> bs = new List<int>();

            for (int i=-radius; i<=radius; i++)
            {
                for(int j=-radius; j<=radius; j++)
                {
                    int idX = x + j;
                    int idY = y + i;
                    if(correctPos(idX, idY, sourceImage))
                    {
                        Color neighborColor = sourceImage.GetPixel(idX, idY);
                        rs.Add(neighborColor.R);
                        gs.Add(neighborColor.G);
                        bs.Add(neighborColor.B);
                    }
                }
            }
            rs.Sort();
            gs.Sort();
            bs.Sort();
            Color median = Color.FromArgb(rs[rs.Count / 2], gs[gs.Count / 2], bs[bs.Count/2]);
            return median;
        }

        private bool correctPos(int x, int y, Bitmap sourceImage)
        {
            return ((x >= 0) && (x < sourceImage.Width) && (y >= 0) && (y<sourceImage.Height));
        }
    }
}
