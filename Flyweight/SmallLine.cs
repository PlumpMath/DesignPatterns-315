using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flyweight
{
    class SmallLine : UniLine
    {
        Point _x;
        Point _y;
        Color _color;
        float _weight;
        public SmallLine(Point x, Point y, Color color, float weight) : base(x, y, color, weight)
        {
            _x = x;
            _y = y;
            _color = color;
            _weight = weight;
        }
        
    }
}
