using System;
using System.Collections.Generic;
using System.Drawing;

namespace Paint.Shapes
{
    class ArrowShape : Shape
    {
        List<Shape> arrowParts = new List<Shape>();

        public ArrowShape(Point currentStartPoint, Point currentEndPoint, Color normalFillColor) :
               base(currentStartPoint, currentEndPoint, normalFillColor)
        {
        }

        private void DrawArrow(Point startPoint, Point endPoint)
        {
            LineShape mainLine = new LineShape(startPoint, endPoint, _normalFillColor);
            arrowParts.Add(mainLine);

            double angle = Math.Atan2(endPoint.Y - startPoint.Y, endPoint.X - startPoint.X) + Math.PI;

            Point arrowPoint1 = new Point(
                (int)(endPoint.X + 10 * Math.Cos(angle - 0.3)),
                (int)(endPoint.Y + 10 * Math.Sin(angle - 0.3))
            );
            Point arrowPoint2 = new Point(
                (int)(endPoint.X + 10 * Math.Cos(angle + 0.3)),
                (int)(endPoint.Y + 10 * Math.Sin(angle + 0.3))
            );

            LineShape arrowLine1 = new LineShape(endPoint, arrowPoint1, _normalFillColor);
            LineShape arrowLine2 = new LineShape(endPoint, arrowPoint2, _normalFillColor);

            arrowParts.Add(arrowLine1);
            arrowParts.Add(arrowLine2);
        }

        private void CreateSubShapes()
        {
            arrowParts.Clear();

            if (startPoint == endPoint) return;

            DrawArrow(startPoint, endPoint);
        }

        public override void Show(Graphics g)
        {
            CreateSubShapes();

            foreach (Shape shape in arrowParts)
            {
                shape.Show(g);
            }
        }

        public override Shape Clone()
        {
            return new ArrowShape(this.startPoint, this.endPoint, this._normalFillColor);
        }
    }
}
