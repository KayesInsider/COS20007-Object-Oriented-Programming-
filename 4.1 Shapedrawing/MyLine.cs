using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ShapeDrawing
{
    public class MyLine : Shape
    {

        private float _endX;
        private float _endY;


        public MyLine(Color clr, int startX, int startY, float endX, float endY) : base(clr)
        {

        }



        public MyLine() : this(Color.Red, 0, 0, 4.5f, 6.7f)
        {
        }

        public float EndX
        {
            get { return _endX; }
            set { _endX = value; }
        }
        public float EndY
        {
            get { return _endY; }
            set { _endY = value; }
        }



        public override void Draw()
        {
            if (Selected)
            {
                DrawOutLine();
            }
            SplashKit.DrawLine(Color, X, Y, EndX, EndY);
        }

        public override void DrawOutLine()

        {


            SplashKit.FillCircle(Color.Black, X, Y, 10);
            SplashKit.FillCircle(Color.Black, EndX, EndY, 10);


        }

        public override bool IsAt(Point2D pt)
        {
            return SplashKit.PointOnLine(pt, SplashKit.LineFrom(X, Y, X + (EndX - X), Y + (EndY - Y)));
           


        }
    }
}
