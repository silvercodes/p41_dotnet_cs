

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

class User: IComparable
{
    public int Id { get; set; }
    public string? Email { get; set; }
    public int Age { get; set; }

    public int CompareTo(object? obj)
    {
        if (obj is null)
            throw new NullReferenceException();

        if (obj is User u)
            return Age - u.Age;

        throw new ArgumentException();
    }

    public override string ToString()
    {
        return $"id: {Id}, email: {Email}, age: {Age}";
    }
}



#endregion


