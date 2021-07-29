using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Visualization
{
    class Cocktail_Shaker
    {
        int[] Array;
        Graphics g;
        int Width;
        int Height;
        public Cocktail_Shaker(int[] Array, Graphics g, int Width, int Height)
        {
            this.Array = Array;
            this.g = g;
            this.Width = Width;
            this.Height = Height;
        }
        public void RunAlgorithm()
        {
            int start = 0;
            int end = Array.Length - 1;
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = start; j < end; j++)
                    if (Array[j] > Array[j + 1])
                        Swap(j, j + 1);
                for (int k = end - 1; k > start; k--)
                    if (Array[k] < Array[k - 1])
                        Swap(k, k - 1);

                start++;
                end--;
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
