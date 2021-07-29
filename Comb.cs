using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Visualization
{
    class Comb
    {
        int[] Array;
        Graphics g;
        int Width;
        int Height;
        public Comb(int[] Array, Graphics g, int Width, int Height)
        {
            this.Array = Array;
            this.g = g;
            this.Width = Width;
            this.Height = Height;
        }
        public void RunAlgorithm()
        {
            for (double gap = Array.Length; gap >= 1.0; gap /= 1.3)
                for (int low = 0; low + gap < Array.Length; low++)
                    if (Array[(int)low] > Array[(int)(low + gap)])
                        Swap((int)low, (int)(low + gap));
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
            System.Threading.Thread.Sleep(20);

            g.FillRectangle(White, i, Height - Array[i], 1, Array[i]);
            g.FillRectangle(White, j, Height - Array[j], 1, Array[j]);
        }
    }
}
