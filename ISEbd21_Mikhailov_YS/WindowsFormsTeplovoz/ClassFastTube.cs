using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace WindowsFormsTeplovoz
{
    class ClassFastTube : IDop
    {
        private DirectionTube dopEnum;
        public int numTube { set => dopEnum = (DirectionTube)value; }
        public ClassFastTube(int x)
        {
            numTube = x;
        }

        public void DrawDop(Graphics g, float x, float y, Color dopcolor)
        {
            Brush brush = new SolidBrush(dopcolor);
            Pen pen = Pens.Black;
            if (dopEnum == DirectionTube.One)
            {
                g.FillRectangle(brush, x + 85, y - 15, 10, 15);
                g.FillRectangle(brush, x + 90, y - 10, 10, 10);
            }
            if (dopEnum == DirectionTube.Two || dopEnum == DirectionTube.Three)
            {
                g.FillRectangle(brush, x + 85, y - 15, 10, 15);
                g.FillRectangle(brush, x + 90, y - 10, 10, 10);
                g.FillRectangle(brush, x + 100, y - 15, 10, 15);
                g.FillRectangle(brush, x + 105, y - 10, 10, 10);
            }

            if (dopEnum == DirectionTube.Three)
            {
                
                g.FillRectangle(brush, x + 115, y - 15, 10, 15);
                g.FillRectangle(brush, x + 120, y - 10, 10, 10);
            }
        }
    }
}
