using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApp
{
    class SobelFilterX : MatrixFilter
    {
        public SobelFilterX()
        {
            this.kernel = new float[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
        }
    }
}
