using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApp
{
    class Closing : MathMorphology
    {
        protected Dilation diliation;
        protected Erosion erosion;
        public Closing()
        {
            this.structuralElement = new int[,] { { 0, 1, 0 }, { 1, 1, 1 }, { 0, 1, 0 } };
            this.diliation = new Dilation(structuralElement, 2, 1);
            this.erosion = new Erosion(structuralElement, 2, 2);
        }

        public Closing(int[,] structuralElement)
        {
            this.structuralElement = structuralElement;
            this.diliation = new Dilation(structuralElement, 2, 2);
            this.erosion = new Erosion(structuralElement, 2, 1);
        }
        public override Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            return erosion.ProcessImage(diliation.ProcessImage(sourceImage, worker), worker);
        }

        internal override bool applyStructuralElementAt(int k, int l, int brightness)
        {
            return false;
        }

        internal override void renewBrightness(){}
    }
}
