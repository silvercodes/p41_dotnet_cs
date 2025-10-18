

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


// ??????

interface IWritable
{
    public void Write();
}
interface ISaver
{
    public void Write();
}

class Db: IWritable, ISaver
{
    // === Явная реализация
    // 1. НЕ ЯВЛЯЮТСЯ ЧЛЕНАМИ КЛАССА!!!
    // 2. Нельзя сделать publie
    void IWritable.Write()
    {
        System.Console.WriteLine("Write() from Db(IWritable)");
    }
    void ISaver.Write()
    {
        System.Console.WriteLine("Write() from Db(ISaver)");
    }

    // === Общая реализация (одна на все интерфейсы)
    public void Write()
    {
        System.Console.WriteLine("Common realization");
    }
}


#endregion




