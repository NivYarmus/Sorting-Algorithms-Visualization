using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Visualization
{
    class OddEven
    {
        int[] Array;
        Graphics g;
        int Width;
        int Height;
        public OddEven(int[] Array, Graphics g, int Width, int Height)
        {
            this.Array = Array;
            this.g = g;
            this.Width = Width;
            this.Height = Height;
        }
        public void RunAlgorithm()
        {
            bool Sorted = false;

            while (!Sorted)
            {
                Sorted = true;

                for (int i = 1; i < Array.Length - 1; i += 2)
                {
                    if (Array[i] > Array[i + 1])
                    {
                        Swap(i, i + 1);
                        Sorted = false;
                    }
                }

                for (int i = 0; i < Array.Length - 1; i += 2)
                {
                    if (Array[i] > Array[i + 1])
                    {
                        Swap(i, i + 1);
                        Sorted = false;
                    }
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
            System.Threading.Thread.Sleep(5);

            g.FillRectangle(White, i, Height - Array[i], 1, Array[i]);
            g.FillRectangle(White, j, Height - Array[j], 1, Array[j]);
        }
    }
}
