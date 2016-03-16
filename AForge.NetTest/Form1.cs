using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Imaging;
using AForge.Imaging.ComplexFilters;
using AForge.Imaging.ColorReduction;
using AForge.Imaging.Filters;
using AForge.Imaging.Textures;
using System.Drawing.Imaging;

namespace AForge.NetTest
{
    public partial class brValue : Form
    {
        public brValue()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = (Bitmap)System.Drawing.Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void grayscaleImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayscaleBT709 gray = new GrayscaleBT709();
            pictureBox2.Image = gray.Apply((Bitmap)pictureBox1.Image);
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sepia sp = new Sepia();
            pictureBox2.Image = sp.Apply((Bitmap)pictureBox1.Image);
        }

        private void hueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HueModifier hue = new HueModifier();
            pictureBox2.Image = hue.Apply((Bitmap)pictureBox1.Image);
        }

        private void rotateChannelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotateChannels rc = new RotateChannels();
            pictureBox2.Image = rc.Apply((Bitmap)pictureBox1.Image);
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invert invrt = new Invert();
            pictureBox2.Image = invrt.Apply((Bitmap)pictureBox1.Image);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image.Save(@"C:\Users\arvn\Desktop\aweSomePic.jpg", ImageFormat.Jpeg);
        }
    }
}
