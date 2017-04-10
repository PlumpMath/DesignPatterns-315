using System.Windows.Forms;

namespace Bitmap
{
    class UniBitmap
    {
        public System.Drawing.Bitmap Btmap { get; set; }
        OpenFileDialog openFileDialog;

        public UniBitmap()
        {
            Get();
        }
        public System.Drawing.Bitmap Get()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return null;
            string filename = openFileDialog.FileName;
            Btmap = new System.Drawing.Bitmap(filename);
            return Btmap;

        }

        public bool IsInUse { get; set; }
    }
}
