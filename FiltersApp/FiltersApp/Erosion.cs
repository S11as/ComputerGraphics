using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersApp
{
    class Erosion : MathMorphology
    {
        public Erosion()
        {
            // TODO делать это извне
            this.structuralElement = new int[,] { { 0, 1, 0 }, { 1, 1, 1 }, { 0, 1, 0 } };
            this.radius = this.structuralElement.GetLength(0) / 2;
        }

        public Erosion(int[,] structuralElement) : base(structuralElement){}
        public Erosion(int[,] structuralElement, int compositionRatio, int compositionPosition) : base(structuralElement, compositionRatio, compositionPosition) { }
        internal override bool applyStructuralElementAt(int k, int l, int brightness)
        {
            if (this.structuralElement[k + this.radius, l + this.radius] == 1 && brightness < this.currentSavedBrightness)
            {
                this.currentSavedBrightness = brightness;
                return true;
            }
            return false;
        }

        internal override void renewBrightness()
        {
            this.currentSavedBrightness = 255;
        }

    }
}
