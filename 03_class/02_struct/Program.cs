
//Point p = new Point();
//p.Render();
//p.x = 12;
//p.y = 15;
//p.Render();

//struct Point
//{
//    public int x;
//    public int y;

//    public static Point origin = new() { x = 0, y = 0 };

//    public Point()
//    {
//        x = 0;
//        y = 0;
//    }
//    public Point(int x, int y)
//    {
//        this.x = x;
//        this.y = y;
//    }
//    public void Render() => Console.WriteLine($"({x}, {y})");
//}






//Point p = new();
//p.Render();
//p.x = 12;
//p.y = 15;
//p.Render();

//struct Point
//{
//    public int x = -1;
//    public int y = -1;

//    public Point()
//    {
//    }

//    //public static Point origin = new() { x = 0, y = 0 };
//    public void Render() => Console.WriteLine($"({x}, {y})");
//}








//Point a = new() { x = 9, y = -4 };
//a.Render();

//Point b = new(56, -47) { title = "B" };
//b.Render();

////b = a;
////b.Render();

//Point c = b with { title = "C"};
//c.Render();

//struct Point
//{
//    public int x;
//    public int y;
//    public string title = "no_title";

//    public Point()
//    {
//        x = 0;
//        y = 0;
//    }
//    public Point(int x, int y)
//    {
//        this.x = x;
//        this.y = y;
//    }
//    public void Render() => Console.WriteLine($"{title} ({x}, {y})");
//}




// ======= record struct =======

//TemperatureRecord t = new TemperatureRecord(20);
//Console.WriteLine(t.GetFahrenheit());
//Console.WriteLine(t);

//Coord coord = new Coord();
//Coord coord2 = new Coord(3, 4);
//coord.x = 100;
//coord.y = 100;
//Console.WriteLine(coord.GetMagnitude());

//record struct TemperatureRecord
//{
//    public float celsius;
//    public TemperatureRecord(float t) => celsius = t;
//    public float GetFahrenheit() => 32 + celsius * 9 / 5;
//}

//record struct Coord(int x, int y)
//{
//    public double GetMagnitude() => Math.Sqrt(x * x + y * y);
//}





// -------- readonly struct --------
ImmutableVector a = new ImmutableVector(3, 4, 5);

readonly record struct ImmutableVector
{
    public readonly double x;
    public readonly double y;
    public readonly double z;

    public ImmutableVector(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public double GetMagnitude() => Math.Sqrt(x * x + y * y + z * z);
}