using System;
using System.Collections.Generic;
using System.Drawing;

public class RegularPolygon : Poligon
{

    private int count;

    public RegularPolygon(int count)
    {
        this.count = count;
    }

    public override void dragOnCreate(Point startPoint, Point secondPoint)
    {
        base.move(startPoint);
        this.getVertexes().Clear();
        this.getVertexes().Add(secondPoint);
    }

    public override void draw(Graphics formGraphics)
    {
        Point topPoint = this.getVertexes().ToArray()[0];
        this.getVertexes().Clear();
        float radius = (float)Math.Sqrt((this.getCenter().X - topPoint.X) * (this.getCenter().X - topPoint.X) 
            + (this.getCenter().Y - topPoint.Y) * (this.getCenter().Y - topPoint.Y));
        float startAngle = XYToDegrees(topPoint, this.getCenter());
        float step = 360.0f / count;

        float angle = startAngle; //starting angle
        for (double i = startAngle; i < startAngle + 360.0; i += step) //go in a full circle
        {
            this.getVertexes().Add(DegreesToXY(angle, radius, this.getCenter())); //code snippet from above
            angle += step;
        }
        formGraphics.FillPolygon(this.FillPen.Brush, this.getVertexes().ToArray());
        formGraphics.DrawPolygon(this.BorderPen, this.getVertexes().ToArray());
    }

    private Point DegreesToXY(float degrees, float radius, Point origin)
    {
        Point xy = new Point();
        double radians = degrees * Math.PI / 180.0;

        xy.X = (int)(Math.Cos(radians) * radius + origin.X);
        xy.Y = (int)(Math.Sin(-radians) * radius + origin.Y);

        return xy;
    }

    private float XYToDegrees(Point xy, Point origin)
    {
        int deltaX = origin.X - xy.X;
        int deltaY = origin.Y - xy.Y;

        double radAngle = Math.Atan2(deltaY, deltaX);
        double degreeAngle = radAngle * 180.0 / Math.PI;

        return (float)(180.0 - degreeAngle);
    }

    public int getCount()
    {

        return 0;
    }

    public override List<Point> Location()
    {
        return base.Location();
    }

    /// 
    /// <param name="destination"></param>
    public override void move(Point destination) { }

    /// 
    /// <param name="newVal"></param>
    public void setCount(int newVal)
    {

    }

}//end RegularPolygon