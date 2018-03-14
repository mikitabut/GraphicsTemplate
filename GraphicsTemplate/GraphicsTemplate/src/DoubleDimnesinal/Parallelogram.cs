using System.Drawing;
using System.Collections.Generic;
public class Parallelogram : Poligon
{

    public override void draw(Graphics graphics)
    {
        Point[] vertexes = this.getVertexes().ToArray();
        if (vertexes.Length >= 3)
        {
            int deltaX = 0, deltaY = 0;
            Point theFourth = new Point();
            deltaX = vertexes[0].X - vertexes[1].X;
            deltaY = vertexes[0].Y - vertexes[1].Y;
            theFourth.X = vertexes[2].X + deltaX;
            theFourth.Y = vertexes[2].Y + deltaY;
            this.tapOnCreate(theFourth);
            graphics.DrawPolygon(this.BorderPen, this.getVertexes().ToArray());
            graphics.FillPolygon(this.FillPen.Brush, this.getVertexes().ToArray());
        }
    }

    public override List<Point> Location()
    {
        return this.getVertexes();
    }

    /// 
    /// <param name="destination"></param>
    public override void move(Point destination) { }

    public override bool tapOnCreate(Point vertex)
    {
        return base.tapOnCreate(vertex) || this.getVertexes().Count==3;
    }
}//end Parallelogram