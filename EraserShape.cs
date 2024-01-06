using System.Drawing;

namespace Paint.Shapes
{
    class EraserShape : Shape
    {
        private Pen erasePen;

        public EraserShape(Point currentStartPoint, Point currentEndPoint, float eraserSize)
            : base(currentStartPoint, currentEndPoint, Color.White)
        {
            erasePen = new Pen(Color.White, eraserSize);
        }

        public override void Show(Graphics g)
        {
            g.DrawLine(erasePen, startPoint, endPoint);
        }

        public override Shape Clone()
        {
            return new EraserShape(this.startPoint, this.endPoint, erasePen.Width);
        }
    }
}