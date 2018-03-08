public class Ray : Line {

	public Ray(){

	}

	~Ray(){

	}

	public override void Dispose(){

	}

	public abstract void draw();

	public abstract vector<Point> location();

	/// 
	/// <param name="destination"></param>
	public abstract void move(Point destination);

}//end Ray
