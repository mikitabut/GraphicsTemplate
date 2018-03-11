using System;
using System.Collections.Generic;
using System.Drawing;

public class Ellipse : DoubleDimensional
{

    private Point point;

    public Ellipse()
    {
        this.Point = new Point(0, 0);
    }

    protected Point Point { get => point; set => point = value; }

    public override void dragOnCreate(Point startPoint,Point secondPoint)
    {
        this.Point = secondPoint;
        this.move(startPoint);
    }

    public override void draw(Graphics formGraphics)
    {
        int difX = Math.Abs(this.getCenter().X - this.Point.X);
        int difY = Math.Abs(this.getCenter().Y - this.Point.Y);
        formGraphics.DrawEllipse(
            this.BorderPen,
            new RectangleF(
                this.getCenter().X - difX,
                this.getCenter().Y - difY,
                2 * difX, 2 * difY
            )
        );
        formGraphics.FillEllipse(
            this.FillPen.Brush,
            new RectangleF(
                this.getCenter().X - difX,
                this.getCenter().Y - difY,
                2 * difX, 2 * difY
            )
        );
    }

    public Point GetPoint()
    {
        return this.Point;
    }

    public override List<Point> Location()
    {
        List<Point> locationPoints = new List<Point>();
        locationPoints.Add(this.getCenter());
        locationPoints.Add(this.Point);
        return locationPoints;
    }

    /// 
    /// <param name="newVal"></param>
    public void SetPoint(Point newVal)
    {
        if (newVal != null)
        {
            this.Point = newVal;
        }
    }

}//end Ellipse
