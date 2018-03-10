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
        Pen pen = new Pen(this.getBorderColor());
        graphics.DrawLine(pen, 
            new Point(getCenter().X + getCenter().X - this.point.X,
                        getCenter().Y + getCenter().Y - this.point.Y),
            this.point);
        pen.Dispose();
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
        if (destination != null)
        {
            this.setCenter(destination);
        }
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

}//end Line
