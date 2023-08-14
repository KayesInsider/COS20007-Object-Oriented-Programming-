using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ShapeDrawering
{
    public class Drawing
    {

        private readonly List<Shape> _shapes;
        private Color _background;


        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }
        public Drawing() : this(Color.White)
        { }

        public Color Background
        {
            get { return _background; }
            set { _background = value; }
        }


        public int ShapeCount
        {
            get { return _shapes.Count; }
        }



        public void AddShape(Shape shapes)
        {
            _shapes.Add(shapes);
        }

        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            foreach (Shape shapes in _shapes)
            {
                shapes.Draw();
            }

        }


        public void RemoveShape(Shape shapes)
        {
            _shapes.Remove(shapes);
        }



        public void SelectShapeAt(Point2D pt)
        {
            foreach (Shape s in _shapes)
            {
                if (s.IsAt(pt))
                {
                    s.Selected = true;
                }
                else
                {
                    s.Selected = false;
                }
            }

        }

        public List<Shape> SelectedShapes
        {
            get
            {
                List<Shape> shapes = new List<Shape>();
                foreach (Shape shape in _shapes)
                {
                    if (shape.Selected)
                    {
                        shapes.Add(shape);
                    }
                }
                return shapes;
            }
        }


    }
}
