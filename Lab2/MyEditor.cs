using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint

{
    class MyEditor
    {
        private static MyEditor? instance;
        public List<Shape> shapes = new List<Shape>();
        private bool isLBdown = false;

        private MyEditor() { }

        public static MyEditor GetInstance()
        {
            if (instance == null)
            {
                instance = new MyEditor();
            }
            return instance;
        }


        public void OnLBdown(Point location)
        {
            isLBdown = true;
            currentShape.startPoint = location;
            currentShape.SetRubber();
        }
        public void OnLBup(Point location)
        {
            currentShape.endPoint = location;
            currentShape.SetNormal();
            AddNewShapeToArray(currentShape.Clone());
            currentShape.startPoint = Point.Empty;
            currentShape.endPoint = Point.Empty;
            isLBdown = false;
        }

        public void OnMouseMove(Point location)
        {
            if (isLBdown)
            {
                currentShape.endPoint = location;
            }
        }
        public void OnPaint (Graphics g)
        {
            foreach (Shape shape in shapes)
            {
                shape.SetNormal();
                shape.Show(g);
            }
            currentShape.Show(g);
        }
        public void AddNewShapeToArray (Shape shape)
        {
            shapes.Add(shape);
        }
        
        private Shape _currentShape = new PointShape (Point.Empty, Point.Empty, Color.Empty);
        public Shape currentShape
        {
            get { return _currentShape; }
            set { _currentShape = value; }
        }

    }
}
