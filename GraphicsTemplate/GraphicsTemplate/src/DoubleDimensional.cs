using System.Drawing;

public abstract class DoubleDimensional : Shape {

	private Color fillColor;
    private Pen fillPen;

	public DoubleDimensional(){
        fillColor = new Color();
	}

    protected Pen FillPen { get { return fillPen; } }

    public Color getFillColor(){

		return fillColor;
	}

	/// 
	/// <param name="newVal"></param>
	public void setFillColor(Color newVal){
        if (fillPen != null)
        {
            fillPen.Dispose();
        }
        fillColor = newVal;
        fillPen = new Pen(Color.FromArgb(128,fillColor));
    }

}
