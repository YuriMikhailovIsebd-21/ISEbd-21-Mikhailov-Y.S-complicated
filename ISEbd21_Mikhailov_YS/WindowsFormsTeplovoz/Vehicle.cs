﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace WindowsFormsTeplovoz
{
    public abstract class Vehicle : ITransport
    {
        protected float _startPosX;
        protected float _startPosY;

        protected int _pictureWidth;
        protected int _pictureHeight;

        public Color MainColor { protected set; get; }
       
        public int MaxSpeed { protected set; get; }
       public float Weight { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureHeight = height;
            _pictureWidth = width;
        }
        public abstract void DrawTeplo(Graphics g);
        public abstract void MoveTeplo(Direction direction);     
    }
}

