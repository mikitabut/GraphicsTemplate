using System.Collections.Generic;
using System.Drawing;

public abstract class Shape
{

    private Color borderColor;
    private Point center;
    private Pen borderPen;

    protected Pen BorderPen { get { return borderPen; } }
    protected Point Center
    {
        get { return center; }
        set { center = value; }
    }

    public Shape()
    {
        borderColor = Color.Red;
        borderPen = new Pen(borderColor);
        Center = new Point(0, 0);
    }

    public abstract void dragOnCreate(Point startPoint, Point secondPoint);

    public virtual bool tapOnCreate(Point vertex) { return false; }

    public Color getBorderColor()
    {
        return borderColor;
    }

    public Point getCenter()
    {
        return Center;
    }

    public abstract List<Point> Location();

    public virtual void move(Point destination)
    {
        this.Center = destination;
    }

    /// 
    /// <param name="newVal"></param>
    public void setBorderColor(Color newVal)
    {
        if (newVal != null)
        {
            if (borderPen != null)
            {
                borderPen.Dispose();
            }
            borderColor = newVal;
            borderPen = new Pen(borderColor);
            borderPen.Width = 3;
        }

    }

    public abstract void draw(Graphics formGraphics);
    /// 
    /// <param name="newVal"></param>
    public void setCenter(Point newVal)
    {
        if (newVal != null)
        {
            Center = newVal;
        }
    }

}//end Shape
