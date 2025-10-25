

#region Intro

//interface IRenderable { }
//interface IMovable { }
//interface ILoggable { }
//interface ILogger { }
//interface IShape { }

// Интерфейс может включать
// 1. Methods
// 2. Properties
// 3. Events
// 4. Indexators
// 5. Static (const)


//interface ILogger
//{
//    // private int id;                          // ERROR
//    public const double PI = 3.1415;
//    public static int count = 0;
//    public void Log(string message);            // public abstract virtual void Log(string message)
//    public string Path { get; set; }            // public abstract virtual string Path { get; set; }
//}




//interface IRenderable
//{
//    private static int count = 0;
//    private const double PI = 3.1415;
//    private void Info()
//    {
//        Console.WriteLine("private Info()");
//    }
//    public void Render()
//    {
//        Console.WriteLine("Render");
//        Console.WriteLine(count);
//        Info();
//    }
//    public int Ratio { get => 0; }
//    public int Count
//    {
//        get => IRenderable.count;
//        set => IRenderable.count = value < 0 ? 0 : value;
//    }
//}

//class Unit : IRenderable
//{

//}

#endregion

#region Practice_1

//Unit a = new Unit();
//a.Render();
//// a.WriteLogs();           // ERROR

//IRenderable b = new Unit();
//b.Render();
//b.WriteLogs();


// Unit a = new Unit();
// a.Render();
// a.WriteLogs();

// IRenderable b = new Unit();
// b.Render();
// b.WriteLogs();


// interface IRenderable
// {
//     public void Render();
//     public void WriteLogs()
//     {
//         Console.WriteLine("IRenderable.WriteLogs()");
//     }
// }

// class Unit: IRenderable
// {
//     public void Render()
//     {
//         Console.WriteLine("Unit.Render()");
//     }

//     public void WriteLogs()
//     {
//         Console.WriteLine("Unit.WriteLogs()");
//     }
// }

#endregion

#region Multiple realization

// Db db = new Db();

// IWritable a = new Db();
// a.Write();
// IComparable b = new Db();
// b.Comapre(a);

// if (a is Db db1)
// {
//     db1.Compare();
// }

// if (db is IWritable iw)
// {
//     iw.Write();
// }


// interface IWritable
// {
//     public void Write();
// }

// interface IComparable
// {
//     public bool Comapre(object? obj);
// }

// class Db : IWritable, IComparable
// {
//     public void Write()
//     {
//         Console.WriteLine("Write to db...");
//     }
//     public bool Compare(object? obj)
//     {
//         return true;
//     }
//     public void Save()
//     {
//         System.Console.WriteLine("Db.Save()");
//     }
// }


#endregion

#region Explicit / Implicit realization


// Db db = new Db();
// // db.Write();             // ERROR

// IWritable a = new Db();
// a.Write();


// Db db = new Db();
// db.Write();

// IWritable a = new Db();
// a.Write();


// Db db = new Db();

// ((IWritable)db).Write();        // :-(

// if (db is IWritable wdb)
//     wdb.Write();                // :-)))

// IWritable w = db;               // :-)
// w.Write();

// interface IWritable
// {
//     public void Write();
// }
// interface ISaver
// {
//     public void Write();
// }

// class Db: IWritable, ISaver
// {
//     // === Явная реализация
//     // 1. НЕ ЯВЛЯЮТСЯ ЧЛЕНАМИ КЛАССА!!!
//     // 2. Нельзя сделать publie
//     void IWritable.Write()
//     {
//         System.Console.WriteLine("Write() from Db(IWritable)");
//     }
//     void ISaver.Write()
//     {
//         System.Console.WriteLine("Write() from Db(ISaver)");
//     }

//     // === Общая реализация (одна на все интерфейсы)
//     public void Write()
//     {
//         System.Console.WriteLine("Common realization");
//     }
// }


#endregion

#region Access modificators

// IRenderable a = new Mesh();
// // a.Show();                    // ERROR

// Mesh b = new Mesh();
// b.Show();

// interface IRenderable
// {
//     protected void Show();
// }

// class Mesh: IRenderable
// {
//     void IRenderable.Show()
//     {
//         System.Console.WriteLine("Mesh IRenderable.Show()");
//     }
//     public void Show()
//     {
//         System.Console.WriteLine("Mesh Show()");
//     }
// }

#endregion

#region Interfaces with inheritance !!!!!!!!!!!

// Tree a = new Tree();

// Shape b = a;
// b.Render();     // 3
// b.Calc();       // 4
// b.Update();     // 2

// IRenderable c = a;
// c.Render();     // 3
// c.Calc();       // 4
// c.Update();     // 2


// interface IRenderable
// {
//     public void Render();
//     public void Calc();
//     public void Update();
// }

// abstract class Shape : IRenderable
// {
//     public abstract void Render();
//     public virtual void Calc() => System.Console.WriteLine("1 Shape.Calc()");     // 1
//     public void Update() => System.Console.WriteLine("2 Shape.Update()");         // 2
// }

// class Tree: Shape
// {
//     public override void Render() => System.Console.WriteLine("3 Tree.Render()"); // 3
//     public override void Calc() => System.Console.WriteLine("4 Tree.Calc()");     // 4
//     public new void Update() => System.Console.WriteLine("5 Tree.Update()");      // 5
// }





// Unit a = new Unit();
// a.Render();             // 2
// Shape b = a;
// b.Render();             // 1
// IRenderable c = a;
// c.Render();             // 2

// interface IRenderable
// {
//     public void Render();
// }

// class Shape : IRenderable
// {
//     public void Render() => System.Console.WriteLine("1 Shape.Render()");
// }
// class Unit: Shape, IRenderable
// {
//     public new void Render() => System.Console.WriteLine("2 Unit.Render()");
// }





// Unit a = new Unit();
// a.Render();             // 2

// Shape b = a;
// b.Render();             // 1

// IRenderable c = a;
// c.Render();             // 3

// interface IRenderable
// {
//     public void Render();
// }

// class Shape : IRenderable
// {
//     public void Render() => System.Console.WriteLine("1 Shape.Render()");
// }
// class Unit: Shape, IRenderable
// {
//     public new void Render() => System.Console.WriteLine("2 Unit.Render()");
//     void IRenderable.Render() => System.Console.WriteLine("3 Explicit IRenderable.Render() from Unit");
// }



#endregion

#region Interfaces inheritance !!!!!!!!!!!!

// IWritable a = new FileManager();
// a.Write();                          // 6

// IFileSaver b = new FileManager();
// b.Write();                          // 4
// b.Save();                           // 7


// interface IWritable
// {
//     // public void Write();
//     public void Write() => System.Console.WriteLine("1. IWritable.Write()");
// }

// interface IFileSaver : IWritable
// {
//     // public void Save();
//     public void Save() => System.Console.WriteLine("2. IFileSaver.Save()");
//     public new void Write() => System.Console.WriteLine("3. IFileSaver.Write()");
// }

// class FileManager: IFileSaver
// {
//     public void Write() => System.Console.WriteLine("4. FileManager.Wirte()");
//     public void Save() => System.Console.WriteLine("5. FileManager.Write()");
//     void IWritable.Write() => System.Console.WriteLine("6. Explicit FileManager.IWritable.Write()");
//     void IFileSaver.Save() => System.Console.WriteLine("7. Explicit FileManager.IFileSaver.Save()");

// }

#endregion

#region Interface as generic constraints

// File file = new File("/var/log.txt");

// FileManager<File> fm = new FileManager<File>();
// fm.Save(file);

// interface IWritable
// {
//     public void Write();
// }

// interface ISavable
// {
//     string? Path { get; }
// }


// class File : IWritable, ISavable
// {
//     public string? Path { get; }
//     public File(string path) => Path = path;
//     public void Write() => System.Console.WriteLine($"File {Path} was written");
// }

// class FileManager<T>
//     where T: IWritable, ISavable
// {
//     public void Save(T data)
//     {
//         data.Write();
//         Console.WriteLine(data.Path);
//     }
// }

#endregion

#region Generic interfaces

// User<int> u = new User<int>(12);
// IAuthenticator<int> a = u;

// Admin b = new Admin("123456");
// IAuthenticator<string> c = b;

// Author d = new Author("546234");
// User<string> e = d;
// IAuthenticator<string> f = d;

// interface IAuthenticator<T>
// {
//     public T Id { get; }
// }

// class User<K> : IAuthenticator<K>
// {
//     public K Id { get; }
//     public User(K id) => Id = id;
// }

// class Admin : IAuthenticator<string>
// {
//     public string Id { get; }
//     public Admin(string id) => Id = id;
// }

// class Author: User<string>
// {
//     public Author(string id):
//         base(id)
//     {}
// }

#endregion

#region IComparable / IComparable<T>

// List<User> users = new List<User>()
// {
//     new User() { Id = 101, Email = "email1@mail.com", Age = 43 },
//     new User() { Id = 102, Email = "email2@mail.com", Age = 21 },
//     new User() { Id = 103, Email = "email3@mail.com", Age = 32 },
//     new User() { Id = 104, Email = "email4@mail.com", Age = 20 },
// };

// users.Sort();
// foreach (User u in users)
// {
//     System.Console.WriteLine(u);
// }



// class User : IComparable
// {
//     public int Id { get; set; }
//     public string? Email { get; set; }
//     public int Age { get; set; }

//     public int CompareTo(object? obj)
//     {
//         if (obj is null)
//             throw new NullReferenceException();

//         if (obj is User u)
//             return Age - u.Age;

//         throw new ArgumentException();
//     }

//     public override string ToString()
//     {
//         return $"id: {Id}, email: {Email}, age: {Age}";
//     }
// }


// class User : IComparable<User>
// {
//     public int Id { get; set; }
//     public string? Email { get; set; }
//     public int Age { get; set; }

//     public int CompareTo(User? obj)
//     {
//         if (obj is null)
//             throw new NullReferenceException();

//         return Age - obj.Age;
//     }

//     public override string ToString()
//     {
//         return $"id: {Id}, email: {Email}, age: {Age}";
//     }
// }

#endregion

#region IComparer<T>

// List<User> users = new List<User>()
// {
//     new User() { Id = 101, Email = "email1@mail.com", Age = 43 },
//     new User() { Id = 102, Email = "email2@mail.com", Age = 21 },
//     new User() { Id = 103, Email = "email3@mail.com", Age = 32 },
//     new User() { Id = 104, Email = "email4@mail.com", Age = 20 },
// };

// users.Sort(new UserAgeComparer());
// users.Sort(new UserIdComparer(Direction.Asc));
// foreach (var u in users)
// {
//     Console.WriteLine(u);
// }

// class User
// {
//     public int Id { get; set; }
//     public string? Email { get; set; }
//     public int Age { get; set; }

//     public override string ToString()
//     {
//         return $"id: {Id}, email: {Email}, age: {Age}";
//     }
// }

// class UserAgeComparer : IComparer<User>
// {
//     public int Compare(User? x, User? y)
//     {
//         if (x is null || y is null)
//             throw new NullReferenceException();

//         return x.Age - y.Age;
//     }
// }

// enum Direction
// {
//     Asc,
//     Desc,
// }

// class UserIdComparer : IComparer<User>
// {
//     public Direction Direction { get; set; } = Direction.Asc;
//     public UserIdComparer(Direction dir) => Direction = dir;
//     public int Compare(User? x, User? y)
//     {
//         if (x is null || y is null)
//             throw new NullReferenceException();

//         return Direction == Direction.Asc ? x.Id - y.Id : y.Id - x.Id;
//     }
// }

#endregion

#region invariance (as it is) / covariance (up to types, out T) / contrvariance (down to types, in T)

// ------------ обобщённый интерфейс с инвариантным универсальным параметром ----------------

//MySqlManager manager = new MySqlManager();

//IManager<MySqlConnection> manager_0 = manager;

//IManager<MySqlConnection> manager_1 = new MySqlManager();

//// IManager<Connection> manager_2 = new MySqlManager();                 // ERROR

////List<IManager<Connection>> list = new List<IManager<Connection>>()    // ERROR
////{
////    new MySqlManager(),
////}


//class Connection
//{
//    public string? Config { get; set; }
//    public Connection(string? config) => Config = config;
//}
//class MySqlConnection : Connection
//{
//    public MySqlConnection(string? config) : base(config)
//    {}
//}

//interface IManager<T>
//    where T : Connection
//{
//    T CreateConnection(string config);
//}
//class MySqlManager : IManager<MySqlConnection>
//{
//    public MySqlConnection CreateConnection(string config)
//    {
//        return new MySqlConnection(config);
//    }
//}





// ------------ обобщённый интерфейс с КОвариантным универсальным параметром ----------------

// EXAMPLE_1

//MySqlManager manager_0 = new MySqlManager();

//IManager<MySqlConnection> manager_1 = new MySqlManager();

//IManager<Connection> manager_2 = new MySqlManager();
//Connection conn1 = manager_2.CreateConnection("config_1 string");
//Console.WriteLine(conn1.Config);

//IManager<Connection> manager_3 = new SqlServerManager();
//Connection conn2 = manager_3.CreateConnection("config_2 string");
//Console.WriteLine(conn2.Config);

//List<IManager<Connection>> list = new List<IManager<Connection>>()
//{
//    new MySqlManager(),
//    new SqlServerManager(),
//};
//foreach(IManager<Connection> manager in list)
//    Console.WriteLine(manager.CreateConnection("config........"));

//class Connection
//{
//    public string? Config { get; set; }
//    public Connection(string? config) => Config = config;
//}
//class MySqlConnection : Connection
//{
//    public MySqlConnection(string? config) : base(config)
//    { }
//}
//class SqlServerConnection : Connection
//{
//    public SqlServerConnection(string? config) : base(config)
//    { }
//}

//interface IManager<out T>
//    where T : Connection
//{
//    T CreateConnection(string config);
//}
//class MySqlManager : IManager<MySqlConnection>
//{
//    public MySqlConnection CreateConnection(string config)
//    {
//        return new MySqlConnection(config);
//    }
//}
//class SqlServerManager : IManager<SqlServerConnection>
//{
//    public SqlServerConnection CreateConnection(string config)
//    {
//        return new SqlServerConnection(config);
//    }
//}



// EXAMPLE_2

//IUnitBuilder builder = new WarriorBuilder();
//List<IUnitBuilder> builders = new List<IUnitBuilder>()
//{
//    new WarriorBuilder(),
//    new ArcherBuilder(),
//};

//class Unit
//{
//    public string Title { get; set; }
//    public int Hp { get; set; }
//    public Unit(string title, int hp)
//    {
//        Title = title;
//        Hp = hp;
//    }
//}
//class Archer: Unit
//{
//    public Archer(string title, int hp) : base(title, hp)
//    {}
//}
//class Assasin: Archer
//{
//    public Assasin(string title, int hp) : base(title, hp)
//    { }
//}

//class Warrior: Unit
//{
//    public Warrior(string title, int hp) : base(title, hp)
//    {}
//}

//interface IUnitBuilder
//{
//    public Unit BuildUnit(string title, int hp);
//}
//class ArcherBuilder : IUnitBuilder
//{
//    public Unit BuildUnit(string title, int hp)
//    {
//        return new Archer(title, hp);
//    }
//}
//class WarriorBuilder : IUnitBuilder
//{
//    public Unit BuildUnit(string title, int hp)
//    {
//        return new Warrior(title, hp);
//    }
//}






//IUnitBuilder<Archer> a = new ArcherBuilder();
//IUnitBuilder<Assasin> b = new AssasinBuilder();
//IUnitBuilder<Warrior> c = new WarriorBuilder();

//List<IUnitBuilder<Unit>> builders = new List<IUnitBuilder<Unit>>()
//{
//    new ArcherBuilder(),
//    new AssasinBuilder(),
//    new WarriorBuilder(),
//};

//class Unit
//{
//    public string Title { get; set; }
//    public int Hp { get; set; }
//    public Unit(string title, int hp)
//    {
//        Title = title;
//        Hp = hp;
//    }
//}
//class Archer : Unit
//{
//    public Archer(string title, int hp) : base(title, hp)
//    { }
//}
//class Assasin : Archer
//{
//    public Assasin(string title, int hp) : base(title, hp)
//    { }
//}
//class Warrior : Unit
//{
//    public Warrior(string title, int hp) : base(title, hp)
//    { }
//}

//interface IUnitBuilder<out T>
//{
//    public T BuildUnit(string title, int hp);
//}
//class ArcherBuilder : IUnitBuilder<Archer>
//{
//    public Archer BuildUnit(string title, int hp)
//    {
//        return new Archer(title, hp);
//    }
//}
//class AssasinBuilder : IUnitBuilder<Assasin>
//{
//    public Assasin BuildUnit(string title, int hp)
//    {
//        return new Assasin(title, hp);
//    }
//}
//class WarriorBuilder : IUnitBuilder<Warrior>
//{
//    public Warrior BuildUnit(string title, int hp)
//    {
//        return new Warrior(title, hp);
//    }
//}




// ------------ обобщённый интерфейс с КОНТРвариантным универсальным параметром ----------------


//object m0 = new MySqlManager();

//MySqlManager m1 = new MySqlManager();

//IManager<Connection> m2 = new MySqlManager();

//IManager<MySqlConnection> m3 = new MySqlManager();
//m3.SetConnection(new MySqlConnection("config string"));
//// m3.SetConnection(new Connection("config string"));           ERROR

//IManager<SqlServerConnection> m4 = new SqlServerManager();
//m4.SetConnection(new SqlServerConnection("config string 2"));
//m4.SetConnection(new DefaultSqlServerConnection("config string 2"));



//class Connection
//{
//    public string? Config { get; set; }
//    public Connection(string? config) => Config = config;
//}
//class MySqlConnection : Connection
//{
//    public MySqlConnection(string? config) : base(config)
//    { }
//}
//class SqlServerConnection : Connection
//{
//    public SqlServerConnection(string? config) : base(config)
//    { }
//}
//class DefaultSqlServerConnection : SqlServerConnection
//{
//    public DefaultSqlServerConnection(string? config) : base(config)
//    {}
//}

//interface IManager<in T>
//    where T : Connection
//{
//    public void SetConnection(T conn);
//}
//class MySqlManager : IManager<Connection>
//{
//    public void SetConnection(Connection conn)
//    {
//        Console.WriteLine($"MySqlManager: {conn.Config}");
//    }
//}
//class SqlServerManager : IManager<Connection>
//{
//    public void SetConnection(Connection conn)
//    {
//        Console.WriteLine($"SqlServerManager: {conn.Config}");
//    }
//}





// ------------ обобщённый интерфейс с разными универсальными параметроми ----------------

interface ILogger<T, out K, in V>
{

}
class A { }

class B : A { }
class C : B { }

class Logger: ILogger<int, C, A>
{

}


#endregion





