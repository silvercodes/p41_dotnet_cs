// Value types
// Все целочисленные
// Все типы с плавающей запятой
// bool
// char
// enum
// --> struct

// Reference types
// 1. --> Классы
// 2.       Object
// 3.       String
// 4. Интерфейсы
// 5. Делегат

#region Struct in class
// -----------------------------------

//Unit a = new Unit("warrior", new Point(3, 4));
//Unit b = a;

//void Exec(Unit u)
//{
//    u.position.x = 55;
//    u.position.y = 77;
//}

//a.Render();
//Exec(a);
//a.Render();


//Unit a = new Unit("warrior", new Point(3, 4));

//void Exec(ref Unit u)
//{
//    u = new Unit("archer", new Point(12, 15));

//    u.position.x = 55;
//    u.position.y = 77;
//}

//a.Render();
//Exec(ref a);
//a.Render();


//record struct Point(int x, int y);
//class Unit
//{
//    public string title;
//    public Point position;
//    public Unit(string title, Point position)
//    {
//        this.title = title;
//        this.position = position;
//    }
//    public void Render() => Console.WriteLine($"{title} --> {position.x}, {position.y}");
//}
#endregion


#region Class in struct

//Point a = new Point(1, 3, new PointInfo("A", 4));
//Point b = a;

//void Exec(Point p)
//{
//    p.info.pontTitle = "B";
//}

//Point a = new Point(1, 3, new PointInfo("A", 4));
//Exec(a);



//void Exec(ref Point p)
//{
    
//}

//Point a = new Point(1, 3, new PointInfo("A", 4));
//Exec(ref a);


//class PointInfo
//{
//    public string pontTitle;
//    public int pointLevel;

//    public PointInfo(string pontTitle, int pointLevel)
//    {
//        this.pontTitle = pontTitle;
//        this.pointLevel = pointLevel;
//    }
//}
//record struct Point
//{
//    public int x;
//    public int y;
//    public PointInfo info;

//    public Point(int x, int y, PointInfo info)
//    {
//        this.x = x;
//        this.y = y;
//        this.info = info;
//    }
//}

#endregion
