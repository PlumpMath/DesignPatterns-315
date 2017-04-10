using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmap
{
    class BitmapPool
    {
        IBitmapAdapter adapter = new BitmapAdapter();
        private readonly int _maxSize;
        private readonly List<UniBitmap> _uniBitmaps;
        private List<System.Drawing.Bitmap> list;
            public BitmapPool(int minSize, int maxSize)
            {
                _maxSize = maxSize;

                _uniBitmaps = new List<UniBitmap>();
                for (int i = 0; i < minSize; i++)
                {
                    var UniBitmap = new UniBitmap();
                    _uniBitmaps.Add(UniBitmap);
                }
            }

            public UniBitmap GetUniBitmap()
            {
                var uniBitmap = _uniBitmaps.FirstOrDefault(x => !x.IsInUse);
                if (uniBitmap == null)
                {
                uniBitmap = CreateUniBitmap();
                }
                uniBitmap.IsInUse = true;

                return uniBitmap;
            }
        public List<System.Drawing.Bitmap> GetUniBitmapNegative()
        {
            list = new List<System.Drawing.Bitmap>();
            Image img;
            foreach (var item in _uniBitmaps)
            {
                img = adapter.GetNegative((Image)item.Btmap);
                System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(img);
                list.Add(bmp);
            }
            return list;
        }
        public List<System.Drawing.Bitmap> GetUniBitmapRotateLeft()
        {
           
            Image img;
            foreach (var item in _uniBitmaps)
            {
                img = adapter.Rotate((Image)item.Btmap, "left");
                System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(img);
                list.Add(bmp);
            }
            return list;
        }
        public List<System.Drawing.Bitmap> GetUniBitmapRotateRight()
        {
          
            Image img;
            foreach (var item in _uniBitmaps)
            {
                img = adapter.Rotate((Image)item.Btmap, "right");
                System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(img);
                list.Add(bmp);
            }
            return list;
        }

        public void ReleaseUniBitmap(UniBitmap uniBitmap)
            {
                if (!_uniBitmaps.Contains(uniBitmap))
                {
                    throw new InvalidOperationException();
                }

                uniBitmap.IsInUse = false;
            }

            private UniBitmap CreateUniBitmap()
            {
                if (_uniBitmaps.Count == _maxSize)
                {
                    throw new InvalidOperationException();
                }

                var uniBitmap = new UniBitmap();
                _uniBitmaps.Add(uniBitmap);
                return uniBitmap;
            }
      }
}
