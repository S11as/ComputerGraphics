﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Tomogramm
{
    class View
    {
        public View() { }

        public void SetupView(int width, int height)
        {
            GL.ShadeModel(ShadingModel.Smooth);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, Bin.X, 0, Bin.Y, -1, 1);
            GL.Viewport(0, 0, width, height);
        }

        private int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        Color TransferFunction(short value)
        {
            int min = 0;
            int max = 2000;
            int newVal = Clamp((value - min) * 255 / (max - min), 0, 255);
            return Color.FromArgb(255, newVal, newVal, newVal);
        }

        public void DrawQuads(int layerNumber)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Begin(BeginMode.Quads);
            short value;
            for (int x_coord = 0; x_coord < Bin.X - 1; x_coord++)
                for (int y_coord = 0; y_coord < Bin.Y - 1; y_coord++)
                {
                   
                    value = Bin.array[x_coord + y_coord * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x_coord, y_coord);
                    
                    value = Bin.array[x_coord + (y_coord + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x_coord, y_coord + 1);
                   
                    value = Bin.array[(x_coord + 1) + (y_coord + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x_coord + 1, y_coord + 1);
                    
                    value = Bin.array[(x_coord + 1) + y_coord * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x_coord + 1, y_coord);
                }
            GL.End();
        }
    }
}
