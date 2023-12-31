﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ShapeDrawing
{

    public class MyRectangle : Shape
    {
        private float _width, _height;

        public MyRectangle(Color clr, float x, float y, float width, float height) : base(clr)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public MyRectangle() : this(Color.Green, 0, 0, 100, 100)
        {
        }

        public float Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public float Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutLine();
            }
            SplashKit.FillRectangle(Color, X, Y, Width, Height);

        }

        public override void DrawOutLine()
        {
            SplashKit.DrawRectangle(Color.Black, X - 2, Y - 2, _width + 4, _height + 4);
        }

        public override bool IsAt(Point2D pt)
        {
            if ((pt.X > X) && (pt.X < X + _width))
            {
                if ((pt.Y > Y) && (pt.Y < Y + _height))
                {
                    return true;
                }
            }
            return false;

        }


    }


}
