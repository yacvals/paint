using System;
using System.Collections.Generic;
using System.Drawing;

namespace Paint.Shapes
{
    class HexagonShape : Shape
    {
        List<Shape> hexagonParts = new List<Shape>();

        public HexagonShape(Point currentStartPoint, Point currentEndPoint, Color normalFillColor) :
               base(currentStartPoint, currentEndPoint, normalFillColor)
        {
        }

        private void DrawHexagon(Point center, int radius)
        {
            int sides = 6;
            double angleStep = 2 * Math.PI / sides;

            Point[] points = new Point[sides];
            for (int i = 0; i < sides; i++)
            {
                double angle = i * angleStep;
                points[i] = new Point(
                    (int)(center.X + radius * Math.Cos(angle)),
                    (int)(center.Y + radius * Math.Sin(angle))
                );
            }

            for (int i = 0; i < sides; i++)
            {
                LineShape side = new LineShape(points[i], points[(i + 1) % sides], _normalFillColor);
                hexagonParts.Add(side);
            }
        }

        private void CreateSubShapes()
        {
            hexagonParts.Clear();

            if (startPoint == endPoint) return;

            int radius = Math.Abs(endPoint.X - startPoint.X) / 2;
            Point center = new Point(startPoint.X + radius, startPoint.Y + radius);

            DrawHexagon(center, radius);
        }

        public override void Show(Graphics g)
        {
            CreateSubShapes();

            foreach (Shape shape in hexagonParts)
            {
                shape.Show(g);
            }
        }

        public override Shape Clone()
        {
            return new HexagonShape(this.startPoint, this.endPoint, this._normalFillColor);
        }
    }
}
