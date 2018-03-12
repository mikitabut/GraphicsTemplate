using System.Drawing;
using System;
public class Ray : Line {

	public Ray(){

	}

    public override void draw(Graphics graphics)
    {
        Tuple<Point, Point> tuple = this.ResizeRay(this.getCenter(), this.GetSecondPoint(), 100000);
        graphics.DrawLine(this.BorderPen,
            tuple.Item1,
            tuple.Item2);
        this.BorderPen.Dispose();
    }

    private Tuple<Point, Point> ResizeRay(PointF start, PointF end, int length)
    {
        var v = new PointF(end.X - start.X, end.Y - start.Y);
        var l = (float)Math.Sqrt(v.X * v.X + v.Y * v.Y);
        v = new PointF(v.X / l, v.Y / l);
        var newEnd = new Point((int)(end.X + v.X * length), (int)(end.Y + v.Y * length));
        return new Tuple<Point, Point>(new Point((int)start.X, (int)start.Y), newEnd);
    }

}//end Ray
