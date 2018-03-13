using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RightTriangle : Poligon
{
    public RightTriangle()
    {
    }

    public override void dragOnCreate(Point startPoint, Point secondPoint)
    {
        base.move(startPoint);
        this.getVertexes().Clear();
        this.getVertexes().Add(secondPoint);
        this.getVertexes().Add(startPoint);
    }

    public override void draw(Graphics formGraphics)
    {
        Point[] topPoints = this.getVertexes().ToArray();
        this.getVertexes().Clear();
        this.getVertexes().AddRange(topPoints);
        Point top = -topPoints[0].Y < -topPoints[1].Y ? topPoints[1] : topPoints[0];
        Point bot = -topPoints[0].Y < -topPoints[1].Y ? topPoints[0] : topPoints[1];
        this.getVertexes().Add(new Point(top.X, bot.Y));
        base.draw(formGraphics);
    }
}

