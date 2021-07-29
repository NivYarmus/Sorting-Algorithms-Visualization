using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Visualization
{
    class Selection
    {
        int[] Array;
        Graphics g;
        int Width;
        int Height;
        public Selection(int[] Array, Graphics g, int Width, int Height)
        {
            this.Array = Array;
            this.g = g;
            this.Width = Width;
            this.Height = Height;
        }
        public void RunAlgorithm()
        {
            int Low = 0;
            int High = Array.Length - 1;

            while (Low < High)
            {
                Swap(Low, Min(Low, High));
                Low++;
                System.Threading.Thread.Sleep(50);
            }
        }
        private int Min(int low, int high)
        {
            Random rnd = new Random();
            int min = Array[low];
            int location = low;

            for (int i = low + 1; i <= high; i++)
            {
                if (min > Array[i])
                {
                    min = Array[i];
                    location = i;
                }
            }
            return location;
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

            g.FillRectangle(White, i, Height - Array[i], 1, Array[i]);
            g.FillRectangle(White, j, Height - Array[j], 1, Array[j]);
        }
    }
}
