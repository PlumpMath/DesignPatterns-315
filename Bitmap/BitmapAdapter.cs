using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Bitmap
{
    public class BitmapAdapter : IBitmapAdapter
    {
      
        SaveFileDialog saveFileDialog;
        int rotationAngle;
        public Image GetNegative(Image image)
        {
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cm = new ColorMatrix(
            new float[][]
             {
            new float[] {-1, 0, 0, 0, 0},
            new float[] {0, -1, 0, 0, 0},
            new float[] {0, 0, -1, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {1, 1, 1, 0, 1}
            });
            ia.SetColorMatrix(cm);
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(image);
            Graphics g = Graphics.FromImage(bmp);

            g.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, ia);

            return (Image)bmp;
        }

        public Image Rotate(Image img, string rotateDirection)
        {
           System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(img.Width, img.Height);

            Graphics gfx = Graphics.FromImage(bmp);
            float dx = bmp.Width / 2;
            float dy = bmp.Height / 2;
            gfx.TranslateTransform((float)dx, (float)dy);
            if (rotateDirection.Equals("left"))
            {
                rotationAngle = -90;
            }
            else if (rotateDirection.Equals("right"))
            {
                rotationAngle = 90;
            }
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)dx, -(float)dy);
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gfx.DrawImage(img, new Point(0, 0));
            gfx.Dispose();
            return bmp;
          
        }
        public string SaveOnDisk()
        {
            saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return null;

            string filename = saveFileDialog.FileName;
            filename = String.Format("{0}.jpg", filename);
            return filename;
        }
    }
}
