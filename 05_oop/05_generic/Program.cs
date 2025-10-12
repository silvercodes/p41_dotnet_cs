
#region Generic classes

//User a = new User() { Id = 101, Email = "vasia@mail.com" };
//User b = new User() { Id = "102", Email = "petya@mail.com" };

//if (a.Id is not null)
//{
//    int aId = (int)a.Id;
//}

//if (b.Id is not null && b.Id is string)
//{
//    string bId = (string)b.Id;
//}

//class User
//{
//    public object? Id { get; set; }
//    public string? Email { get; set; } = null;
//}





//User<int> a = new User<int>() { Id = 101, Email = "vasia@mail.com" };
//User<string> b = new User<string>() { Id = "102", Email = "petya@mail.com" };

//User<int>.maxId = 100;
//User<string>.maxId = "0";
//User<double>.maxId = 1.0;

//class User<T>
//{
//    public static T maxId;
//    public T Id { get; set; }
//    public string? Email { get; set; } = null;
//}



//User<int, Role<string>> user = new User<int, Role<string>>(101, "vasia@mail.com");

//class Role<T>
//{
//    public T Id { get; set; }
//    public string Title { get; set; }
//}

//class User<K, T>
//{
//    public K Id { get; set; }
//    public string? Email { get; set; }
//    public T Role { get; set; }
//    public User(K id, string? email)
//    {
//        Id = id;
//        Email = email;
//    }
//}

#endregion


#region Generic method

//Logger.Analyze<string>("Json data");
//Logger.Analyze<Entry>(new Entry() { Data = "XML data" });

//class Entry
//{
//    public string Data { get; set; }
//    public override string ToString()
//    {
//        return $"Data: {Data}";
//    }
//}

//class Logger
//{
//    //
//    //

//    public static void Analyze<T>(T val)
//    {
//        Console.WriteLine(val);
//    }
//}

#endregion


#region Generic methods constraints

////Archer a = new Archer(100);
////Renderer.Render<Unit>(a);
////Renderer.Render<Archer>(a);

//Archer a = new Archer(100);
//// Renderer.Render<int>(120);       // ERROR
//Renderer.Render(a);

//class Unit
//{
//    public int Hp { get; set; }
//    public Unit(int hp) => Hp = hp;
//}

//class Warrior: Unit
//{
//    public Warrior(int hp) :
//        base(hp)
//    { }
//}
//class Archer: Unit
//{
//    public Archer(int hp) : 
//        base(hp)
//    { }
//}

//// ---- via type checking       :-|
////class Renderer
////{
////    public static void Render<T>(T obj)
////    {
////        if (obj is Unit u)
////            Console.WriteLine($"Render(): {u.Hp}");
////    }
////}

//// ---- via constrints       :-)))
//class Renderer
//{
//    public static void Render<T>(T obj)
//        where T : Unit
//    {
//        Console.WriteLine($"Render(): {obj.Hp}");
//    }
//}

#endregion


#region Generic classes contrints

//Renderer<Unit>.Render(new Warrior(120));
//// Renderer<int>.Render(30);                // ERROR

//class Unit
//{
//    public int Hp { get; set; }
//    public Unit(int hp) => Hp = hp;
//}

//class Warrior : Unit
//{
//    public Warrior(int hp) :
//        base(hp)
//    { }
//}
//class Archer : Unit
//{
//    public Archer(int hp) :
//        base(hp)
//    { }
//}

//class Renderer<T>
//    where T : Unit
//{
//    public static void Render(T obj)
//    {
//        Console.WriteLine($"Render(): {obj.Hp}");
//    }
//}
#endregion


#region Generics contraints types

// where T: s1, s2, s3

// --- s1 ---
// Конкретный класс
// ИЛИ
// class            // любой ссылочный тип
// ИЛИ
// struct           // любой значимый тип

// --- s2 ---
// Конкретные интерфейсы

// --- s3 ---
// new()            // Тип Т должен иметь конструктор по-умолчанию


//Logger<Zabor> a = new Logger<Zabor>();
//Logger<Document> b = new Logger<Document>();
//Logger<Bober> c = new Logger<Bober>();

//class Zabor
//{ }
//struct Bober
//{ }
//class Document
//{
//    public int Id { get; set; }
//    public Document(int id) => Id = id;
//    public Document() { }
//}

//class Logger<T>
//    // where T : Document
//    // where T : class
//    // where T : struct
//    // where T : class, new()
//    where T : new()
//{
//    //void Execute()
//    //{
//    //    T obj = new T();
//    //}
//}

//class Compressor<T, K>
//    where T : class
//    where K : Logger<int>
//{

//}

#endregion


#region Inheritance

class Identity
{
    public Identity()
    { }
}

class Level
{ }

class Unit<T>
    where T: new()
{
    public T Id { get; set; }
    public Unit(T id) => Id = id;
}

// 1. Обобщённый наследник с тем же типом
//class Archer<K>: Unit<K>
//    where K : new()
//{
//    public Archer(K id) : base(id) { }
//}
//Unit<int> a = new Unit<int>(101);
//Archer<int> b = new Archer<int>(102);
//Unit<int> c = new Archer<int>(103);


// 2. Обычный (необобщённый) наследник
//class Warrior : Unit<Identity>
//{
//    public Warrior(Identity id): base(id) { }
//}
//Warrior a = new Warrior(new Identity());
//Unit<Identity> b = new Warrior(new Identity());
//// Unit<int> c = new Warrior(new Identity());           // ERROR


// 3. Обобщённый наследник с собственным типом
//class Archer<T>: Unit<int>
//{
//    public T? Value { get; set; }
//    public Archer(int id): base(id) { }
//}
//Archer<string> a = new Archer<string>(101);
//Unit<int> b = new Archer<string>(101);
//// Unit<string> c = new Archer<string>(101);        // ERROR


// 4. Сочетание нескольких вариантов
//class Archer<T, K>: Unit<K>
//    where K : class, new()
//{
//    public T? Value { get; set; }
//    public Archer(K val) : base(val) { }
//}
//Archer<string, Identity> a = new Archer<string, Identity>(new Identity());
//Unit<Identity> b = new Archer<string, Identity>(new Identity());
//Unit<Level> c = new Archer<int, Level>(new Level());

#endregion
