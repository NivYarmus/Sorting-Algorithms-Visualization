using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms_Visualization
{
    public partial class Form1 : Form
    {
        Graphics g;
        int[] Array;
        int Panel_Height;
        int Panel_Width;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Algorithm visualization";
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();

            Panel_Height = panel1.Height;
            Panel_Width = panel1.Width;

            Array = new int[Panel_Width];

            g.FillRectangle(new SolidBrush(Color.Black), 0, 0, Panel_Width, Panel_Height);

            Random rnd = new Random();

            for (int i = 0; i < Array.Length; i++)
                Array[i] = i;

            //fisher yate
            for (int i = 0; i < Array.Length; i++)
            {
                int rand = rnd.Next(Array.Length);
                int tmp = Array[rand];
                Array[rand] = Array[i];
                Array[i] = tmp;
            }

            for (int i = 0; i < Array.Length; i++)
                g.FillRectangle(new SolidBrush(Color.White), i, Panel_Height - Array[i], 1, Array[i]);
        }

        private void cocktailShakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cocktail_Shaker c = new Cocktail_Shaker(Array, g, Panel_Width, Panel_Height);
            c.RunAlgorithm();
        }

        private void bubbleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bubble b = new Bubble(Array, g, Panel_Width, Panel_Height);
            b.RunAlgorithm();
        }

        private void shellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shell s = new Shell(Array, g, Panel_Width, Panel_Height);
            s.RunAlgorithm();
        }

        private void combToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comb c = new Comb(Array, g, Panel_Width, Panel_Height);
            c.RunAlgorithm();
        }

        private void radixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Radix r = new Radix(Array, g, Panel_Width, Panel_Height);
            r.RunAlgorithm();
        }

        private void selectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selection s = new Selection(Array, g, Panel_Width, Panel_Height);
            s.RunAlgorithm();
        }

        private void insertionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insertion i = new Insertion(Array, g, Panel_Width, Panel_Height);
            i.RunAlgorithm();
        }

        private void gnomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gnome gn = new Gnome(Array, g, Panel_Width, Panel_Height);
            gn.RunAlgorithm();
        }

        private void pancakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pancake p = new Pancake(Array, g, Panel_Width, Panel_Height);
            p.RunAlgorithm();
        }

        private void oddEvenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OddEven o = new OddEven(Array, g, Panel_Width, Panel_Height);
            o.RunAlgorithm();
        }

        private void quickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quick q = new Quick(Array, g, Panel_Width, Panel_Height);
            q.RunAlgorithm();
        }

        private void mergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Merge m = new Merge(Array, g, Panel_Width, Panel_Height);
            m.RunAlgorithm();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
