using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Flyweight
{
    public partial class Form1 : Form
    {
        SmallLine small;
        MediumLine medium;
        LargeLine large;

        Color _color = Color.Black;
        float _weight = 12;
        bool IsClicked = false;
        int X = 0;
        int Y = 0;

        int X1 = 0;
        int Y1 = 0;
        public Form1()
        {
            InitializeComponent();
         }

        private void pctPaint_Paint(object sender, PaintEventArgs e)
        {
            Pen pen;
            Point point = new Point(X, Y);
            Point point1 = new Point(X1, Y1);
            if (_weight == 5)
            {
                small = new SmallLine(point, point1, _color, _weight);
                pen = small.Paint();
                e.Graphics.DrawLine(pen, point, point1);
                
            }
            else if (_weight == 12)
            {
                medium = new MediumLine(point, point1, _color, _weight);
                pen = medium.Paint();
                e.Graphics.DrawLine(pen, point, point1);
               
            }
            else if (_weight == 20)
            {
                large = new LargeLine(point, point1, _color, _weight);
                pen = large.Paint();
                e.Graphics.DrawLine(pen, point, point1);
                
            }
         
        }

        private void pctPaint_MouseDown(object sender, MouseEventArgs e)
        {
            IsClicked = true;
            X = e.X;
            Y = e.Y;
        }

        private void pctPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked)
            {
                X1 = e.X;
                Y1 = e.Y;
                pctPaint.Invalidate();
            }
        }

        private void pctPaint_MouseUp(object sender, MouseEventArgs e)
        {
            IsClicked = false;
            
        }

        private void lstColors_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListViewItem lst = lstColors.FocusedItem;
            string selColor = lst.Text;
            _color = Color.FromName(selColor);
        }

        private void lstWeights_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem lst = lstWeights.FocusedItem;
            string selweight= lst.Text;
            _weight = float.Parse(selweight);
         



        }
    }
}
