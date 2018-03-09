using System.Drawing;

public abstract class DoubleDimensional : Shape {

	private Color fillColor;

	public DoubleDimensional(){
        fillColor = new Color();
	}

	public Color getFillColor(){

		return fillColor;
	}

	/// 
	/// <param name="newVal"></param>
	public void setFillColor(Color newVal){
        if (newVal != null)
        {
            fillColor = newVal;
        }
	}

}
