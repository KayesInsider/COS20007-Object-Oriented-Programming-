using System;
using SplashKitSDK;


namespace ShapeDrawering
{
    public class Program
    {
        public static void Main()

        {
            Window window = new Window("Shape Drawer", 800, 600);
            Drawing drawing = new Drawing();

            do
            {
                SplashKit.ProcessEvents();

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape myShape = new Shape();
                    myShape.X = SplashKit.MouseX();
                    myShape.Y = SplashKit.MouseY();
                    drawing.AddShape(myShape);

                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    drawing.Background = SplashKit.RandomRGBColor(255);
                }
                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    drawing.SelectShapeAt(SplashKit.MousePosition());
                }

                if (SplashKit.KeyTyped(KeyCode.DeleteKey) || SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    foreach (Shape shape in drawing.SelectedShapes)
                    {
                        drawing.RemoveShape(shape);
                    }
                }

                drawing.Draw();
                SplashKit.RefreshScreen();
            }

            while (!window.CloseRequested);

        }
    }
}

