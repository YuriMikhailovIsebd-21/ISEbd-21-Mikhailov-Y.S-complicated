using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTeplovoz
{
    class ClassTurboTube : IDop
    {
        private DirectionTube dopEnum;
        public int numTube { set => dopEnum = (DirectionTube)value; }
        public ClassTurboTube(int x)
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
                g.FillRectangle(brush, x + 80, y - 20, 15, 15);
            }
            if (dopEnum == DirectionTube.Two || dopEnum == DirectionTube.Three)
            {
                g.FillRectangle(brush, x + 85, y - 15, 10, 15);
                g.FillRectangle(brush, x + 80, y - 20, 15, 15);
                g.FillRectangle(brush, x + 100, y - 15, 10, 15);
                g.FillRectangle(brush, x + 97, y - 25, 16, 15);
            }

            if (dopEnum == DirectionTube.Three)
            {
                g.FillRectangle(brush, x + 115, y - 15, 10, 15);
                g.FillRectangle(brush, x + 115, y - 20, 15, 15);
            }
        }
    }
}
