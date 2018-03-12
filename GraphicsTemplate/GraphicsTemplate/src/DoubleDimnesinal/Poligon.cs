using System.Drawing;
using System.Collections.Generic;
public class Poligon : DoubleDimensional {

	private List<Point> vertexes;

	public Poligon(){

	}

	~Poligon(){

	}

	public override void Dispose(){

	}

	public abstract override void draw();

	public List<Point> getVertexes(){

		return null;
	}

	public override List<Point> location(){

		return null;
	}

	/// 
	/// <param name="destination"></param>
	public abstract override void move(Point destination);

	/// 
	/// <param name="newVal"></param>
	public void setVertexes(List<Point> newVal){

	}

}//end Poligon
