public class Circle: Shape {
    
    public Circle(string color, double radius) : base(color) 
    {
        _radius = radius;
    }

    double _radius = 0;



    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}