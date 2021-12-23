using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace WindowsFormsTeplovoz
{
    interface IDop
    {
        int numTube { set; }
        void DrawDop(Graphics g, float x, float y, Color color);
    }
}
