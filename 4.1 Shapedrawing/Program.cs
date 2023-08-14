using System;
using SplashKitSDK;

namespace ShapeDrawing
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle,
            Circle,
            Line
        }
        public static void Main()

        {
            Window window = new Window("Shape Drawer", 800, 600);
            Drawing mydrawing = new Drawing();
            ShapeKind kindToAdd = ShapeKind.Circle;
            do
            {
                SplashKit.ProcessEvents();

                if (SplashKit.KeyTyped(KeyCode.RKey))
                {
                    kindToAdd = ShapeKind.Rectangle;
                }
                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    kindToAdd = ShapeKind.Circle;
                }
                if (SplashKit.KeyTyped(KeyCode.LKey))
                {
                    kindToAdd = ShapeKind.Line;
                }
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {

                    Shape newShape;
                    if (kindToAdd == ShapeKind.Circle)
                    {
                        newShape = new MyCircle();
                    }

                    else if (kindToAdd == ShapeKind.Rectangle)
                    {
                        newShape = new MyRectangle();
                    }
                    else
                    {
                        MyLine newLine = new MyLine();
                        newLine.X = 10;
                        newLine.Y = 10;
                        newShape = newLine;
                    }
                    newShape.X = SplashKit.MouseX();
                    newShape.Y = SplashKit.MouseY();
                    mydrawing.AddShape(newShape);
                }





                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    mydrawing.Background = SplashKit.RandomRGBColor(255);
                }


                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    mydrawing.SelectShapeAt(SplashKit.MousePosition());
                }



                




                if (SplashKit.KeyTyped(KeyCode.DeleteKey) || SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    foreach (Shape shape in mydrawing.SelectedShapes)
                    {
                        mydrawing.RemoveShape(shape);
                    }


                }

                mydrawing.Draw();
                SplashKit.RefreshScreen();
            }
            while (!SplashKit.WindowCloseRequested("Shape Drawer"));


        }
    }
}

