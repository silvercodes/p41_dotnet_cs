
//          C++                             C#
// виртуальная функция              виртуальный метод
// чистая виртуальная функция       абстрактный метод
// абстрактный класс                абстрактный класс
// интерфейсный класс               интерфейс

// Абстрактными в рамках описания типа в C# могут быть
// 1. Метод
// 2. Свойство
// 3. События
// 4. Индексаторы

// Unit a = new Unit();        // ERROR

//Unit b = new Warrior();
//b.Defence();
//b.Force = 150;
//b.Points = 10;

//Unit c = new HumanWarrior();
//c.Defence();
//c.Force = 150;
//c.Points = 10;

//abstract class Unit
//{
//    public int Hp { get; protected set; }           // автосвойство

//    // Разворачивается в 2 абстратных метода
//    public abstract int Force { get; set; }     // НЕ АВТОСВОЙСТВО (не разворачивается в private forc + 2 метода)

//    // Разворачивается в 2 абстратных метода
//    public abstract int Points { get; set; }    // НЕ АВТОСВОЙСТВО (не разворачивается в private force + 2 метода)

//    // Абстрактный метод
//    public abstract void Defence();

//    public virtual void Move()
//    {
//        Console.WriteLine("Unit Move()");
//    }
//    public void Attack()
//    {
//        Console.WriteLine("Unit Attack()");
//    }
//}

//class Warrior : Unit
//{
//    private int points;
//    public override int Force { get; set; }         // АВТОСВОЙСТВО!!!
//    public override int Points                      // ОБЫЧНОЕ (развёрнутое) свойство
//    {
//        get => points;
//        set => points = value;
//    }
//    public override void Defence()
//    {
//        Console.WriteLine("Warrior Defence()");
//    }
//    public override void Move()
//    {
//        Console.WriteLine("Warrior Move()");
//    }
//}

//class HumanWarrior: Warrior
//{
//    public override int Force
//    {
//        get => base.Force;
//        set => base.Force = value * 2;
//    }
//    public override void Defence()
//    {
//        Console.WriteLine("HumanWarrior Defence()");
//    }
//}


#region Object class virtual methods

//Product a = new Product()
//{
//    Id = 101,
//    Title = "Table"
//};

//Console.WriteLine(a);

object a = new Product()
{
    Id = 101,
    Title = "Table"
};

Console.WriteLine(a);


class Product
{
    public int Id { get; set; }
    public string Title { get; set; } = "no_title";
    public override string ToString()
    {
        return $"id: {Id}, title: {Title}";
    }
    public override int GetHashCode()
    {
        return Id;
    }
    public override bool Equals(object? obj)
    {
        if (obj is Product p)
        {
            return Id == p.Id;
        }

        return false;
    }
}

#endregion


