using System;
using System.Collections.Generic;
using System.Drawing;

namespace Paint.Shapes
{
    class TrapezoidShape : Shape
    {
        List<Shape> trapezoidParts = new List<Shape>();

        public TrapezoidShape(Point currentStartPoint, Point currentEndPoint, Color normalFillColor) :
               base(currentStartPoint, currentEndPoint, normalFillColor)
        {
        }

        private void DrawTrapezoid(Point startPoint, Point endPoint)
        {
            int width = Math.Abs(endPoint.X - startPoint.X);
            int height = Math.Abs(endPoint.Y - startPoint.Y);

            Point point1 = new Point(startPoint.X + width / 4, startPoint.Y);
            Point point2 = new Point(startPoint.X + 3 * width / 4, startPoint.Y);
            Point point3 = new Point(startPoint.X + width, startPoint.Y + height);
            Point point4 = new Point(startPoint.X, startPoint.Y + height);

            LineShape side1 = new LineShape(point1, point2, _normalFillColor);
            LineShape side2 = new LineShape(point2, point3, _normalFillColor);
            LineShape side3 = new LineShape(point3, point4, _normalFillColor);
            LineShape side4 = new LineShape(point4, point1, _normalFillColor);

            trapezoidParts.Add(side1);
            trapezoidParts.Add(side2);
            trapezoidParts.Add(side3);
            trapezoidParts.Add(side4);
        }

        private void CreateSubShapes()
        {
            trapezoidParts.Clear();

            if (startPoint == endPoint) return;

            DrawTrapezoid(startPoint, endPoint);
        }

        public override void Show(Graphics g)
        {
            CreateSubShapes();

            foreach (Shape shape in trapezoidParts)
            {
                shape.Show(g);
            }
        }

        public override Shape Clone()
        {
            return new TrapezoidShape(this.startPoint, this.endPoint, this._normalFillColor);
        }
    }
}