using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Visualization
{
    class Radix
    {
        int[] Array;
        Graphics g;
        int Width;
        int Height;
        public Radix(int[] Array, Graphics g, int Width, int Height)
        {
            this.Array = Array;
            this.g = g;
            this.Width = Width;
            this.Height = Height;
        }
        public void RunAlgorithm()
        {
            int max = Max();
            int Divider = 1;

            SolidBrush White = new SolidBrush(Color.White);
            SolidBrush Black = new SolidBrush(Color.Black);

            while (max / Divider > 0)
            {
                int[] Index = new int[10];
                for (int i = 0; i < Index.Length; i++)
                    Index[i] = 0;

                for (int i = 0; i < Array.Length; i++)
                    Index[(Array[i] / Divider) % 10]++;

                for (int i = 1; i < Index.Length; i++)
                    Index[i] += Index[i - 1];

                int[] NewArray = new int[Array.Length];
                for (int i = 0; i < NewArray.Length; i++)
                    NewArray[i] = 0;

                for (int i = Array.Length - 1; i >= 0; i--)
                {
                    NewArray[Index[(Array[i] / Divider) % 10] - 1] = Array[i];
                    Index[(Array[i] / Divider) % 10]--;
                }

                for (int i = Array.Length - 1; i >= 0; i--)
                {
                    g.FillRectangle(Black, i, Height - Array[i], 1, Array[i]);
                    System.Threading.Thread.Sleep(20);
                    g.FillRectangle(White, i, Height - NewArray[i], 1, NewArray[i]);
                    Array[i] = NewArray[i];
                }

                Divider *= 10;
            }
        }
        private int Max()
        {
            int max = Array[0];

            for (int i = 1; i < Array.Length; i++)
                if (max < Array[i])
                    max = Array[i];
            return max;
        }
    }
}
