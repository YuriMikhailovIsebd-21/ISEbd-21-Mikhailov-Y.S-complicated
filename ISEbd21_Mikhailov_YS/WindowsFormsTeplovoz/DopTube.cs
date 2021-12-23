using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsTeplovoz
{
    class DopTube
    {
        private DirectionTube tube;
        public int Dop { set => tube = (DirectionTube)value; }
        public void DrawTube(Graphics g, Brush dopcolor, float _startPosX, float _startPosY)
        {
            switch (tube)
            {
                case DirectionTube.One:
                    DrawTubeOne(g, dopcolor, _startPosX, _startPosY);
                    break;

                case DirectionTube.Two:
                    DrawTubeTwo(g, dopcolor, _startPosX, _startPosY);
                    break;

                case DirectionTube.Three:
                    DrawTubeThree(g, dopcolor, _startPosX, _startPosY);
                    break;
            }
        }
        public DopTube(int dop_count)
        {
            Dop = dop_count;
        }
        private void DrawTubeOne(Graphics g, Brush dopcolor, float x, float y)
        {
         
            g.FillRectangle(dopcolor, x + 85, y - 15, 10, 15);
        }
        private void DrawTubeTwo(Graphics g, Brush dopcolor, float x, float y)
        {
            DrawTubeOne(g, dopcolor, x, y);
            g.FillRectangle(dopcolor, x + 100, y - 15, 10, 15);

        }
        private void DrawTubeThree(Graphics g, Brush dopcolor, float x, float y)
        {
            DrawTubeTwo(g, dopcolor, x, y);
            g.FillRectangle(dopcolor, x + 115, y - 15, 10, 15);
        }
    }
}
