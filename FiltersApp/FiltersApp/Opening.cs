using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApp
{
    class Opening : MathMorphology
    {
        protected Dilation diliation;
        protected Erosion erosion;
        public Opening()
        {
            this.structuralElement = new int[,] { { 0, 1, 0 }, { 1, 1, 1 }, { 0, 1, 0 } };
            this.diliation = new Dilation(structuralElement, 2, 2);
            this.erosion = new Erosion(structuralElement, 2, 1);
        }

        public Opening(int [,] structuralElement)
        {
            this.structuralElement = structuralElement;
            this.diliation = new Dilation(structuralElement, 2, 2);
            this.erosion = new Erosion(structuralElement, 2, 1);
        }

        public override Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            return diliation.ProcessImage(erosion.ProcessImage(sourceImage, worker), worker);
        }
        internal override bool applyStructuralElementAt(int k, int l, int brightness)
        {
            return false;
        }

        internal override void renewBrightness(){}
    }
}
