using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Visualization
{
    class Quick
    {
        int[] Array;
        Graphics g;
        int Width;
        int Height;
        public Quick(int[] Array, Graphics g, int Width, int Height)
        {
            this.Array = Array;
            this.g = g;
            this.Width = Width;
            this.Height = Height;
        }
        public void RunAlgorithm()
        {
            quick(0, Array.Length - 1);
        }
        private void quick(int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(low, high);

                quick(low, pi - 1);
                quick(pi + 1, high);
            }
        }
        private int Partition(int low, int high)
        {
            int Pivot = Array[high];
            int Index = low - 1;

            for (int i = low; i < high; i++)
                if (Array[i] <= Pivot)
                {
                    Index++;
                    Swap(i, Index);
                }
            Swap(Index + 1, high);
            return Index + 1;
        }
        private void Swap(int i, int j)
        {
            SolidBrush White = new SolidBrush(Color.White);
            SolidBrush Black = new SolidBrush(Color.Black);

            g.FillRectangle(Black, i, Height - Array[i], 1, Array[i]);
            g.FillRectangle(Black, j, Height - Array[j], 1, Array[j]);

            int tmp = Array[i];
            Array[i] = Array[j];
            Array[j] = tmp;
            System.Threading.Thread.Sleep(15);

            g.FillRectangle(White, i, Height - Array[i], 1, Array[i]);
            g.FillRectangle(White, j, Height - Array[j], 1, Array[j]);
        }
    }
}
