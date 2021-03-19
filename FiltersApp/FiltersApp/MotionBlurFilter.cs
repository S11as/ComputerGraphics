using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApp
{
    class MotionBlurFilter : MatrixFilter
    {
        // ядро фильтра определяется как
        // матрица размером n*n с единицами по диагонали
        //         [1 0 0]
        // 1/n *   [0 1 0]
        //         [. . 1]
        public MotionBlurFilter()
        {
            int n = 5;
            float ratio = 1.0f / n;
            this.kernel = new float[n, n];

            for (int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    this.kernel[i, j] = i == j ? 1.0f : 0.0f;
                    this.kernel[i, j] *= ratio;
                }
            }
        }
    }
}
