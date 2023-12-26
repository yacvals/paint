using System.Drawing;
using System.Net;

namespace Paint
{
    class LineShape : Shape
    {
        public LineShape(Point currentStartPoint, Point currentEndPoint, Color normalFillColor) :
                    base(currentStartPoint, currentEndPoint, normalFillColor)
        {
            ukr_name = "Лінія";
        }
        public override void Show(Graphics g)
        {
            g.DrawLine(_pen, startPoint, endPoint);
        }

        public override Shape Clone()
        {
            return new LineShape(this.startPoint, this.endPoint, this._normalFillColor);
        }
    }
}