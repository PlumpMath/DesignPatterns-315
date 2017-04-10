using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace Bitmap
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog;
        IBitmapAdapter adapter = new BitmapAdapter();
        BitmapPool pool;
        System.Windows.Forms.Timer moveTimer = new System.Windows.Forms.Timer();
        List<System.Drawing.Bitmap> images;
        int counter;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;

            pctOrigin.Image = Image.FromFile(filename);
            MessageBox.Show("You get image from disk");

        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
           
            Image newImage=adapter.GetNegative(pctOrigin.Image);
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(newImage);
            pctExchange.Image = (Image)bmp;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            pctExchange.Image = (Image)adapter.Rotate(pctExchange.Image, "left");
         }
        private void btnRight_Click(object sender, EventArgs e)
        {
            pctExchange.Image = (Image)adapter.Rotate(pctExchange.Image, "right");
        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {
            pctExchange.Image.Save(adapter.SaveOnDisk());
            MessageBox.Show("You save the image on the disk");

        }

        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            pool = new BitmapPool(1, 3);

            var c1 = pool.GetUniBitmap();
            var c2 = pool.GetUniBitmap();
            var c3 = pool.GetUniBitmap();
            
        }

        private void btnGetImg_Click(object sender, EventArgs e)
        {
            images = new List<System.Drawing.Bitmap>();
            pool.GetUniBitmapNegative();
            pool.GetUniBitmapRotateLeft();
            images = pool.GetUniBitmapRotateRight();
            moveTimer.Interval = 100;
            moveTimer.Tick += new EventHandler(moveTimer_Tick);
            moveTimer.Start();
        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
          
            pctExchange.Image = images[counter];
            if (counter < images.Count - 1)
            {
                counter = counter + 1;
            }
            else
            {
                counter = 0;
            }
        }
    }
}
