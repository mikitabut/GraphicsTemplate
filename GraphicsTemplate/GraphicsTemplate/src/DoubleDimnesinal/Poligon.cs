using System.Drawing;
using System.Collections.Generic;
public class Poligon : DoubleDimensional
{

    private List<Point> vertexes;

    public Poligon()
    {
        vertexes = new List<Point>();
    }

    public override void dragOnCreate(Point startPoint, Point secondPoint) { }

    public override void tapOnCreate(Point vertex)
    {
        if (this.vertexes.Count == 0)
        {
            this.setCenter(vertex);
        }
        vertexes.Add(vertex);
        
    }

    public override void draw(Graphics formGraphics)
    {
        if (this.vertexes.Count >= 3)
        {
            formGraphics.DrawPolygon(this.BorderPen, vertexes.ToArray());
            formGraphics.FillPolygon(this.FillPen.Brush, vertexes.ToArray());
        }
    }

    public override List<Point> Location()
    {
        return this.vertexes;
    }

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
