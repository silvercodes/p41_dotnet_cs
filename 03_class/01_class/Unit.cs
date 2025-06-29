namespace _01_class;

class Unit(string title, int position)
{
    public Unit(string title)
        : this(title, 0) 
    {}
    public void Render() => Console.WriteLine($"title: {title}, position: {position}");
}

// >>>>>> EQUALS <<<<<<

//class Unit
//{
//    private string titile;
//    private int position;
//    public Unit(string titile, int position)
//    {
//        this.titile = titile;
//        this.position = position;
//    }
//    public void Render() => Console.WriteLine($"title: {title}, position: {position}");
//}