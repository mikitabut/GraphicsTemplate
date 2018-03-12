using System.Drawing;
using System.Collections.Generic;
public class Poligon : DoubleDimensional
{

    private List<Point> vertexes;
    private decimal vertexNumber;

    public Poligon(decimal n)
    {
        vertexNumber = n;
        vertexes = new List<Point>();
    }

    ~Poligon()
    {

    }

    public override void dragOnCreate(Point startPoint, Point secondPoint) { }

    public override void tapOnCreate(Point vertex)
    {
        if (vertexes.Count < vertexNumber)
        {
            if (this.vertexes.Count == 0)
            {
                this.setCenter(vertex);
            }
            vertexes.Add(vertex);
        }
    }

    public override void draw(Graphics formGraphics)
    {
        Point prevVertex = new Point(0, 0);
        Point first = new Point(0, 0);
        int i = 0;
        foreach (Point curVertex in this.vertexes)
        {
            if (i == 0)
            {
                first = curVertex;
                prevVertex = curVertex;
            }
            else
            {
                formGraphics.DrawLine(this.BorderPen, prevVertex, curVertex);
                if (i == this.vertexNumber - 1)
                {
                    formGraphics.DrawLine(this.BorderPen, curVertex, first);
                }
                prevVertex = curVertex;
            }
            i++;
        }
        //formGraphics.DrawPolygon(this.BorderPen, vertexes.ToArray());
        formGraphics.FillPolygon(this.FillPen.Brush, vertexes.ToArray());
    }

    public override List<Point> Location()
    {
        return this.vertexes;
    }

    /// 
    /// <param name="destination"></param>
    public override void move(Point destination){}

    /// 
    /// <param name="newVal"></param>
    public void setVertexes(List<Point> newVal)
    {
        this.vertexes = newVal;
    }
    public List<Point> getVertexes()
    {
        return this.vertexes;
    }

}//end Poligon
