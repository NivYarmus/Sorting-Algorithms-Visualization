using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Visualization
{
    class Merge
    {
        int[] Array;
        Graphics g;
        int Width;
        int Height;
        public Merge(int[] Array, Graphics g, int Width, int Height)
        {
            this.Array = Array;
            this.g = g;
            this.Width = Width;
            this.Height = Height;
        }
        public void RunAlgorithm()
        {
            Merge_Sort(0, Array.Length - 1);
        }
        private void Merge_Sort(int low, int high)
        {
            if (low < high)
            {
                int middle = low + (high - low) / 2;

                Merge_Sort(low, middle);
                Merge_Sort(middle + 1, high);

                merge(low, middle, high);
            }
        }
        private void merge(int low, int middle, int high)
        {
            int[] left = new int[middle - low + 1];
            int[] right = new int[high - middle];

            for (int i = 0; i < left.Length; i++)
                left[i] = Array[i + low];
            for (int i = 0; i < right.Length; i++)
                right[i] = Array[i + middle + 1];

            int left_p = 0;
            int right_p = 0;
            int array_p = low;

            while (left_p < left.Length && right_p < right.Length)
            {
                if (left[left_p] <= right[right_p])
                    Array[array_p++] = left[left_p++];
                else
                    Array[array_p++] = right[right_p++];
            }
            while (left_p < left.Length)
                Array[array_p++] = left[left_p++];
            while (right_p < right.Length)
                Array[array_p++] = right[right_p++];

            SolidBrush Black = new SolidBrush(Color.Black);
            SolidBrush White = new SolidBrush(Color.White);
            SolidBrush Red = new SolidBrush(Color.Red);

            int Array_Pointer = low;
            for (int i = 0; i < left.Length; i++)
            {
                g.FillRectangle(Black, Array_Pointer, Height - left[i], 1, left[i]);
                System.Threading.Thread.Sleep(125);
                g.FillRectangle(White, Array_Pointer, Height - Array[Array_Pointer], 1, Array[Array_Pointer++]);
            }
            for (int i = 0; i < right.Length; i++)
            {
                g.FillRectangle(Black, Array_Pointer, Height - right[i], 1, right[i]);
                System.Threading.Thread.Sleep(125);
                g.FillRectangle(White, Array_Pointer, Height - Array[Array_Pointer], 1, Array[Array_Pointer++]);
            }
        }
    }
}
