
using System.Drawing;


namespace Bitmap
{
    public interface IBitmapAdapter
    {
        Image GetNegative(Image image);
        Image Rotate(Image img, string rotateDirection);
        string SaveOnDisk();
    }
}
