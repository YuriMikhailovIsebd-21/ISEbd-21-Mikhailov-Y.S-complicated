using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace WindowsFormsTeplovoz
{
    public class Teplovoz : Lokomotiv
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия трубы
        /// </summary>
        public bool Tube { private set; get; }

        private DirectionTube numTube;
        public int tubes { set => numTube = (DirectionTube)value; }
        IDop idop;
        /// <summary>
        /// Признак наличия "дисков"
        /// </summary>
        public bool Disk { private set; get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>

        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="tube"></param>
        /// <param name="disk"></param>

        public Teplovoz(int maxSpeed, float weight, Color mainColor, Color dopColor,bool tube, bool disk, int tubes, int tubeState) :
 base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Tube = tube;
            Disk = disk;
            this.tubes = tubes;
            switch (tubeState)
            {
                case 0:
                    idop = new ClassSimpleTube(tubes);
                    break;
                case 1:
                    idop = new ClassFastTube(tubes);
                    break;
                case 2:
                    idop = new ClassTurboTube(tubes);
                    break;
            }
        }

        public override void DrawTeplo(Graphics g)
        {
            base.DrawTeplo(g);
            Pen pen = Pens.Black;
            Brush brush = new SolidBrush(DopColor);

            if (Disk)
            {
                g.DrawEllipse(pen, _startPosX + 6, _startPosY + 40, 15, 15);
                g.DrawEllipse(pen, _startPosX + 35, _startPosY + 40, 15, 15);
                g.DrawEllipse(pen, _startPosX + 84, _startPosY + 40, 15, 15);
                g.DrawEllipse(pen, _startPosX + 115, _startPosY + 40, 15, 15);
                g.DrawLine(pen, _startPosX + 42, _startPosY + 40, _startPosX + 42, _startPosY + 55);
                g.DrawLine(pen, _startPosX + 13, _startPosY + 40, _startPosX + 13, _startPosY + 55);
                g.DrawLine(pen, _startPosX + 92, _startPosY + 40, _startPosX + 92, _startPosY + 55);
                g.DrawLine(pen, _startPosX + 123, _startPosY + 40, _startPosX + 123, _startPosY + 55);
            }
            idop.DrawDop(g, _startPosX, _startPosY, DopColor);
        }
    }
}

 
