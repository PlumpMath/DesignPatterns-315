using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Flyweight
{
    abstract class UniLine
    {
        Color _color;
        float _weight;
        public Point X { get; set; }
        public Point Y { get; set; }
        
        public UniLine(Point x, Point y, Color color, float weight)
        {
            X = x;
            Y = y;
            _color = color;
            _weight = weight;
           

        }
        public Pen Paint()
        {
            Pen pen = new Pen(_color, _weight);
            return pen;

        }
         
    }
}
