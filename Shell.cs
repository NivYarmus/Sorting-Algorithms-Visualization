using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Visualization
{
    class Shell
    {
        int[] Array;
        Graphics g;
        int Width;
        int Height;
        public Shell(int[] Array, Graphics g, int Width, int Height)
        {
            this.Array = Array;
            this.g = g;
            this.Width = Width;
            this.Height = Height;
        }
        public void RunAlgorithm()
        {
            for (int Gap = Array.Length / 2; Gap > 0; Gap /= 2)
                for (int i = Gap; i < Array.Length; i++)
                {
                    int tmp_i = i; ;
                    while (tmp_i - Gap >= 0 && Array[tmp_i] < Array[tmp_i - Gap])
                    {
                        Swap(tmp_i, tmp_i - Gap);
                        tmp_i -= Gap;
                    }
                }
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
