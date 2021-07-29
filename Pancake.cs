using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Visualization
{
    class Pancake
    {
        int[] Array;
        Graphics g;
        int Width;
        int Height;
        public Pancake(int[] Array, Graphics g, int Width, int Height)
        {
            this.Array = Array;
            this.g = g;
            this.Width = Width;
            this.Height = Height;
        }
        public void RunAlgorithm()
        {
            int Curr_Size = Array.Length;
            while (Curr_Size > 1)
            {
                int mi = Max(Curr_Size);

                if (mi != Curr_Size - 1)
                {
                    Flip(mi);
                    Flip(Curr_Size - 1);
                }

                Curr_Size--;
            }
        }
        private int Max(int Curr_Size)
        {
            int Max = 0;
            for (int i = 1; i < Curr_Size; i++)
                if (Array[Max] < Array[i])
                    Max = i;
            return Max;
        }
        private void Flip(int End)
        {
            for (int i = 0; i < End; i++)
            {
                Swap(i, End);
                End--;
            }
        }
        private void Swap(int i, int j)
        {
            SolidBrush Black = new SolidBrush(Color.Black);
            SolidBrush White = new SolidBrush(Color.White);

            g.FillRectangle(Black, i, Height - Array[i], 1, Array[i]);
            g.FillRectangle(Black, j, Height - Array[j], 1, Array[j]);

            int tmp = Array[i];
            Array[i] = Array[j];
            Array[j] = tmp;
            System.Threading.Thread.Sleep(10);

            g.FillRectangle(White, i, Height - Array[i], 1, Array[i]);
            g.FillRectangle(White, j, Height - Array[j], 1, Array[j]);
        }
    }
}
