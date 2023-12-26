using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class CubeShape : Shape
    {
        List<Shape> cubeParts = new List<Shape>();

        public CubeShape(Point currentStartPoint, Point currentEndPoint, Color normalFillColor) :
               base(currentStartPoint, currentEndPoint, normalFillColor)
        {
            ukr_name = "Каркас куба";
        }

        private void CreateSubShapes()
        {
            cubeParts.Clear();
            cubeParts.Add(new RectangleShape(startPoint, endPoint, _normalFillColor));

            int width = Math.Abs(endPoint.X - startPoint.X);
            int height = Math.Abs(endPoint.Y - startPoint.Y);

            Point backRectangleStartPoint = new Point(startPoint.X + width / 3, startPoint.Y - height / 3);
            Point backRectangleEndPoint = new Point(endPoint.X + width / 3, endPoint.Y - height / 3);
            cubeParts.Add(new RectangleShape(backRectangleStartPoint, backRectangleEndPoint, _normalFillColor));
            cubeParts.Add(new LineShape(startPoint, backRectangleStartPoint, _normalFillColor));

            Point secondLineEndPoint = new Point(startPoint.X + width / 3 + width, startPoint.Y - height / 3);
            Point secondLineStartPoint = new Point(startPoint.X + width, startPoint.Y);
            cubeParts.Add(new LineShape(secondLineStartPoint, secondLineEndPoint, _normalFillColor));

            Point thirdLineStartPoint = new Point(startPoint.X, startPoint.Y + height);
            Point thirdLineEndPoint = new Point(startPoint.X + width / 3, startPoint.Y + height * 2 / 3);
            cubeParts.Add(new LineShape(thirdLineStartPoint, thirdLineEndPoint, _normalFillColor));
            cubeParts.Add(new LineShape(backRectangleEndPoint, endPoint, _normalFillColor));

        }
        public override void Show(Graphics g)
        {
            CreateSubShapes();
            foreach (Shape shape in cubeParts)
            {
                shape.Show(g);
            }
        }

        public override Shape Clone()
        {
            return new CubeShape(this.startPoint, this.endPoint, this._normalFillColor);
        }
    }
}
