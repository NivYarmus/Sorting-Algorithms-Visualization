using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Visualization
{
    class Insertion
    {
        int[] Array;
        Graphics g;
        int Width;
        int Height;
        public Insertion(int[] Array, Graphics g, int Width, int Height)
        {
            this.Array = Array;
            this.g = g;
            this.Width = Width;
            this.Height = Height;
        }
        public void RunAlgorithm()
        {
            int mark = 1;
            while (mark < Array.Length)
            {
                int tmp_mark = mark;
                while (tmp_mark - 1 >= 0 && Array[tmp_mark - 1] > Array[tmp_mark])
                {
                    Swap(tmp_mark, tmp_mark - 1);
                    tmp_mark--;
                }
                mark++;
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
            System.Threading.Thread.Sleep(5);

            g.FillRectangle(White, i, Height - Array[i], 1, Array[i]);
            g.FillRectangle(White, j, Height - Array[j], 1, Array[j]);
        }
    }
}
