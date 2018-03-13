using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IsoscelesTriangle : RightTriangle
{

    public override void draw(Graphics formGraphics)
    {
        base.draw(formGraphics);
        Point[] topPoints = this.getVertexes().ToArray();
        this.getVertexes().Clear();
        this.getVertexes().Add(topPoints[0]);
        Point top = -topPoints[0].Y < -topPoints[1].Y ? topPoints[1] : topPoints[0];
        Point bot = -topPoints[0].Y < -topPoints[1].Y ? topPoints[0] : topPoints[1];
        this.getVertexes().Add(new Point(top.X + top.X - bot.X , bot.Y));
        this.getVertexes().Add(topPoints[1]);
        base.draw(formGraphics);
    }
}