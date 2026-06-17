public class Shape
{

    public Shape(string color) 
    {
        _color = color;
    }

    string _color = "";
    public string GetColor()
    {
        string color = _color;
        return color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}