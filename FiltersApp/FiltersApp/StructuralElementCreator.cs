using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FiltersApp
{
    public partial class StructuralElementCreator : Form
    {
        protected TextBox[,] boxes;
        protected int dimension=2;
        protected Form1 parent;
        public StructuralElementCreator(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void StructuralElementCreator_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void ClearBoxes()
        {
            if(this.boxes != null)
            {
                for (int i = 0; i < this.dimension; i++)
                {
                    for (int j = 0; j < this.dimension; j++)
                    {
                        this.Controls.Remove(this.boxes[i, j]);
                    }
                }
            }

        }

        private void InitBoxes()
        {
            this.boxes = new TextBox[this.dimension, this.dimension];
            int topMargin = 100;
            int leftMargin = 150;
            if(this.dimension > 5)
            {
                leftMargin = 20;
            }
            else if (this.dimension > 3)
            {
                leftMargin = 150;
            }
            int xOffset = 20;
            int yOffset = 20;

            for (int i = 0; i < this.dimension; i++)
            {
                for (int j = 0; j < this.dimension; j++)
                {

                    TextBox box = new TextBox();
                    box.Size = new Size(50, 50);
                    box.Location = new Point(leftMargin + j * (50 + xOffset), topMargin + i * (20 + yOffset));
                    box.MaxLength = 1;
                    box.Text = "0";
                    this.Controls.Add(box);
                    this.boxes[i,j]=box;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ClearBoxes();
            this.dimension = Convert.ToInt32(comboBox1.Text);
            this.InitBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[dimension, dimension];
            for(int i=0; i<this.dimension; i++)
            {
                for(int j=0; j<this.dimension; j++)
                {
                    int dat = Convert.ToInt32(this.boxes[i, j].Text);
                    if(dat != 0)
                    {
                        arr[i, j] = 1;
                    }
                    else {
                        arr[i, j] = 0;
                    }
                }
            }
            this.parent.SetStructuralElement(arr);
            this.Hide();
        }
    }
}
