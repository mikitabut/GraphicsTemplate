using System.Drawing;
using System;
public class Ray : Line {

	public Ray(){

	}

    public override void draw(Graphics graphics)
    {
        Pen pen = new Pen(this.getBorderColor());
        Tuple<Point, Point> tuple = this.ResizeRay(this.getCenter(), this.GetSecondPoint(), 100000);
        graphics.DrawLine(pen,
            tuple.Item1,
            tuple.Item2);
        pen.Dispose();
    }

    private Tuple<Point, Point> ResizeRay(PointF start, PointF end, int length)
    {
        //Считаем вектор
        var v = new PointF(end.X - start.X, end.Y - start.Y);
        //Длина вектора
        var l = (float)Math.Sqrt(v.X * v.X + v.Y * v.Y);
        //Нормирование
        v = new PointF(v.X / l, v.Y / l);
        //Новые координаты отрезка
        var newEnd = new Point((int)(end.X + v.X * length), (int)(end.Y + v.Y * length));
        return new Tuple<Point, Point>(new Point((int)start.X, (int)start.Y), newEnd);
    }

}//end Ray
