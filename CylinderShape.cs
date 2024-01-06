using System;
using System.Collections.Generic;
using System.Drawing;

namespace Paint.Shapes
{
    class CylinderShape : Shape
    {
        List<Shape> cylinderParts = new List<Shape>();

        public CylinderShape(Point currentStartPoint, Point currentEndPoint, Color normalFillColor) :
               base(currentStartPoint, currentEndPoint, normalFillColor)
        {
        }

        private void DrawCylinderSurface(Point topCenter, Point bottomCenter, int radius, int height)
        {
            int segments = 2; // Зменшено кількість сегментів
            double angleStep = 2 * Math.PI / segments;

            for (int i = 0; i < segments; i++)
            {
                double angle1 = i * angleStep;
                double angle2 = (i + 1) * angleStep;

                Point topPoint1 = new Point(
                    (int)(topCenter.X + radius * Math.Cos(angle1)),
                    (int)(topCenter.Y + radius * Math.Sin(angle1))
                );
                Point topPoint2 = new Point(
                    (int)(topCenter.X + radius * Math.Cos(angle2)),
                    (int)(topCenter.Y + radius * Math.Sin(angle2))
                );

                Point bottomPoint1 = new Point(
                    (int)(bottomCenter.X + radius * Math.Cos(angle1)),
                    (int)(bottomCenter.Y + radius * Math.Sin(angle1))
                );
                Point bottomPoint2 = new Point(
                    (int)(bottomCenter.X + radius * Math.Cos(angle2)),
                    (int)(bottomCenter.Y + radius * Math.Sin(angle2))
                );

                LineShape verticalLine1 = new LineShape(topPoint1, bottomPoint1, _normalFillColor);
                LineShape verticalLine2 = new LineShape(topPoint2, bottomPoint2, _normalFillColor);

                cylinderParts.Add(verticalLine1);
                cylinderParts.Add(verticalLine2);
            }
        }

        private void CreateSubShapes()
        {
            cylinderParts.Clear();

            if (startPoint == endPoint) return;

            int radius = Math.Abs(endPoint.X - startPoint.X) / 2;
            int height = Math.Abs(endPoint.Y - startPoint.Y);

            Point topCenter = new Point(startPoint.X + radius, startPoint.Y);
            Point bottomCenter = new Point(startPoint.X + radius, startPoint.Y + height);

            DrawCylinderSurface(topCenter, bottomCenter, radius, height);
        }

        public override void Show(Graphics g)
        {
            CreateSubShapes();

            foreach (Shape shape in cylinderParts)
            {
                shape.Show(g);
            }

            int radius = Math.Abs(endPoint.X - startPoint.X) / 2;
            int height = Math.Abs(endPoint.Y - startPoint.Y);

            Point topCenter = new Point(startPoint.X + radius, startPoint.Y);
            Point bottomCenter = new Point(startPoint.X + radius, startPoint.Y + height);

            // Замініть параметри DrawEllipse для еліпсів
            g.DrawEllipse(_pen, topCenter.X - radius, topCenter.Y - radius /2, radius* 2, radius);
            g.DrawEllipse(_pen, bottomCenter.X - radius, bottomCenter.Y - radius /2, radius* 2, radius);
        }





        public override Shape Clone()
        {
            return new CylinderShape(this.startPoint, this.endPoint, this._normalFillColor);
        }
    }
}
