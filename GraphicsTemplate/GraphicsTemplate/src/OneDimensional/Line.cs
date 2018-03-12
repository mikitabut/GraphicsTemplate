using System;
using System.Collections.Generic;
using System.Drawing;

public class Line : OneDimensional
{

    private Point point;

    public Line()
    {
        point = new Point(0, 0);
    }

    public override void draw(Graphics graphics)
    {
        Tuple<Point, Point> tuple = this.ResizeLine(this.getCenter(), this.point, 100000);
        graphics.DrawLine(this.BorderPen, 
            tuple.Item1,
            tuple.Item2);
        this.BorderPen.Dispose();
    }

    public Point GetSecondPoint()
    {
        return this.point;
    }

    public override List<Point> Location()
    {
        List<Point> locationPoints = new List<Point>();
        locationPoints.Add(this.getCenter());
        locationPoints.Add(this.point);
        return locationPoints;
    }

    public override void move(Point destination)
    {
        int x = this.Center.X - this.point.X;
        int y = this.Center.Y - this.point.Y;
        base.move(destination);
        this.point = new Point(destination.X + x, destination.Y + y);
    }

    /// 
    /// <param name="newVal"></param>
    public void SetSecondPoint(Point newVal)
    {
        if (newVal != null)
        {
            this.point = newVal;
        }
    }

    public override void dragOnCreate(Point startPoint, Point secondPoint)
    {
        this.point = secondPoint;
        base.move(startPoint);
    }

    private Tuple<Point, Point> ResizeLine(PointF start, PointF end, int length)
    {
        var v = new PointF(end.X - start.X, end.Y - start.Y);
        var l = (float)Math.Sqrt(v.X * v.X + v.Y * v.Y);
        v = new PointF(v.X / l, v.Y / l);
        var newStart = new Point((int)(start.X - v.X * length), (int)(start.Y - v.Y * length));
        var newEnd = new Point((int)(end.X + v.X * length), (int)(end.Y + v.Y * length));
        return new Tuple<Point, Point>(newStart, newEnd);
    }
}//end Line
