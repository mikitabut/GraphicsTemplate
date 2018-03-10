using System.Collections.Generic;
using System.Drawing;

public abstract class Shape
{

    private Color borderColor;
    private Point center;

    public Shape()
    {
        borderColor = new Color();
        center = new Point(0, 0);
    }

    public Color getBorderColor()
    {

        return borderColor;
    }

    public Point getCenter()
    {
        return center;
    }

    public abstract List<Point> Location();

    /// 
    /// <param name="destination"></param>
    public abstract void move(Point destination);

    /// 
    /// <param name="newVal"></param>
    public void setBorderColor(Color newVal)
    {
        if (newVal != null)
        {
            borderColor = newVal;
        }

    }

    public abstract void draw(Graphics formGraphics);

    /// 
    /// <param name="newVal"></param>
    public void setCenter(Point newVal)
    {
        if (newVal != null)
        {
            center = newVal;
        }
    }

}//end Shape
