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




Unit a = new Unit("warrior", new Point(3, 4));

void Exec(ref Unit u)
{
    u = new Unit("archer", new Point(12, 15));

    u.position.x = 55;
    u.position.y = 77;
}

a.Render();
Exec(ref a);
a.Render();



record struct Point(int x, int y);
class Unit
{
    public string title;
    public Point position;
    public Unit(string title, Point position)
    {
        this.title = title;
        this.position = position;
    }
    public void Render() => Console.WriteLine($"{title} --> {position.x}, {position.y}");
}