public abstract class Shape {

	private Color borderColor;
	private Point center;

	public Shape(){

	}

	~Shape(){

	}

	public virtual void Dispose(){

	}

	public abstract void draw();

	public Color getBorderColor(){

		return null;
	}

	public Point getCenter(){

		return null;
	}

	public abstract vector<Point> location();

	/// 
	/// <param name="destination"></param>
	public abstract void move(Point destination);

	/// 
	/// <param name="newVal"></param>
	public void setBorderColor(Color newVal){

	}

	/// 
	/// <param name="newVal"></param>
	public void setCenter(Point newVal){

	}

}//end Shape
