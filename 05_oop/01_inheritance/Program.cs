
#region Inheritance

// Ограничения
// === 1. Только одиночное наследование (но... interfaces :-))
// === 2. Модификатор наследования - public (в терминах C++)
// === 3. Модификатор класса-наследника должен быть такой же или более строгий

//B obj = new B();

//internal class A
//{}

//public class B: A
//{}

// === 4. Класс можно сделать sealed (в C++ это финализированный final class)
// sealed class A {}
// class B: A {}       // ERROR

// === 5. Наследование от статического класса запрещено


//Admin a = new Admin("vasia@mail.com", 23, "read");
//a.Render();
//a.Show();

//internal class User
//{
//  private string email = string.Empty;

//  public string Email { get => email; set => email = value; }
//  public int Age { get; set; }

//  public User()
//  {}

//  public User(int age)
//  {
//    Age = age;
//    Console.WriteLine("User(int age)");
//  }

//  public User(string email, int age):
//    this(age)
//  {
//    Email = email;
//    Console.WriteLine("User(string email, int age)");
//  }

//  public void Render()
//  {
//    Console.WriteLine($"Email: {Email}");
//  }
//}

//internal class Admin: User
//{
//  public string Permission {get; set;}
//  public Admin(string email, int age, string permission):
//    base(email, age)
//  {
//    Permission = permission;
//    Console.WriteLine("Admin ctor");
//  }
//  public void Show()
//  {
//    Console.WriteLine($"Email: {Email}");
//  }
//}

#endregion

#region Type casting

// ======= upcasting (восходящее преобразование / упаковка оъекта / обощение) ======

//Warrior warrior = new Warrior(100, 250);
//warrior.Hp = 80;
//warrior.Force = 300;

//Unit unit = warrior;            // ---> upcasting
//unit.Hp = 80;
//// unit.Force = 300;            // ERROR

//object obj = warrior;           // ---> upcasting
//// obj.Hp = 80;
//// obj.Force = 300;            // ERROR


// ======= downcasting (нисходящее преобразование / распаковка объекта) =======

//Archer archer = new Archer(90, 15);
//Unit unit = archer;                 // upcasting

//Archer archer2 = (Archer)unit;      // downcasting
//archer2.ArrCount = 20;


//Unit u = new Archer(100, 20);
//Archer a = (Archer)u;


//object obj = new Archer(100, 20);
//Unit a = (Unit)obj;
//// Warrior b = (Warrior)obj;            // ERROR
//Archer c = (Archer)obj;



//Unit u = new Unit(100);
//object a = (object)u;
//Archer b = (Archer)u;               // ERROR
//Warrior c = (Warrior)u;             // ERROR



//List<Unit> units = new List<Unit>();
//units.Add(new Archer(100, 12));
//units.Add(new Warrior(80, 200));



// ======= as / is ==========

// Unit u = new Archer(100, 3);

//Archer? a = u as Archer;         // NO EXCEPTION
//a?.Render();

//if (u is Archer)
//    u.Render();

//if (u is Archer archer)
//{

//}
//// >>>> EQUALS <<<<<
//if (u is Archer)
//{
//    Archer aaa = (Archer)u;
//}

//class Unit
//{
//    public int Hp { get; set; }
//    public Unit(int hp)
//    {
//        Hp = hp;
//    }
//    public void Render()
//    {
//        Console.WriteLine($"Hp: {Hp}");
//    }
//}

//class Archer: Unit
//{
//    public int ArrCount { get; set; }
//    public Archer(int hp, int arrCount):
//        base(hp)
//    {
//        ArrCount = arrCount;
//    }
//}

//class Warrior: Unit
//{
//    public int Force { get; set; }
//    public Warrior(int hp, int force):
//        base(hp)
//    {
//        Force = force;
//    }
//}

#endregion

#region virtual / override

//User u = new Student(101, 23);
//u.Show();

//User a = new User(102, 34);
//a.Age = 15;
//a.Show();

//User a = new Student(102, 34);
//a.Age = 15;
//a.Show();

//User a = new SuperStudent(102, 34);
//a.Age = 15;
//a.Show();


//class User
//{
//    public int Id { get; set; }
//    public virtual int Age { get; set; }
//    public User(int id, int age)
//    {
//        Id = id;
//        Age = age;
//    }
//    public virtual void Show()
//    {
//        Console.WriteLine($"id {Id}, age: {Age}");
//    }
//    public static void Method()
//    { }
//    //public virtual static void Method()           // Не имеет смысла
//    //{}
//}

//class Student: User
//{
//    public override int Age 
//    {
//        get => base.Age;
//        set
//        {
//            base.Age = value >= 18 ? value : 18;
//        }
//    }

//    public Student(int id, int age) :
//        base(id, age)
//    { }
//    public override sealed void Show()
//    {
//        Console.WriteLine("Student---->");
//        base.Show();
//    }
//}

//class SuperStudent: Student
//{
//    public SuperStudent(int id, int age) : 
//        base(id, age)
//    {}
//    //public override void Show()                   // ERROR
//    //{
//    //    Console.WriteLine("SuperStudent---->");
//    //    base.Show();
//    //}
//}




//A a = new D();
//a.Show();

//B b = new D();
//b.Show();

//class A
//{
//    public virtual void Show() => Console.WriteLine("A Show()");
//}
//class B: A
//{}

//class C : B
//{
//    public override void Show() => Console.WriteLine("C Show()");
//}
//class D : C
//{}
//class E : D
//{
//    public override void Show() => Console.WriteLine("E Show()");
//}





//A a = new D();
//a.Show();

//B b = new D();
//b.Show();

//C c = new E();
//c.Show();

//class A
//{
//    public void Show() => Console.WriteLine("A Show()");
//}
//class B : A
//{
//    public virtual void Show() => Console.WriteLine("B Show()");
//}

//class C : B
//{
//    public override void Show() => Console.WriteLine("C Show()");
//}
//class D : C
//{ }
//class E : D
//{
//    public override void Show() => Console.WriteLine("E Show()");
//}

#endregion

#region Hiding (скрытие)
//Console.WriteLine(User.minAge);
//Console.WriteLine(Admin.minAge);

//Console.WriteLine(User.Pi);
//Console.WriteLine(Admin.Pi);


//Admin admin = new Admin(101, "vasia@mail.com");
//admin.Email = "brus@mail.com";
//admin.Show();

//User user = new Admin(101, "vasia@mail.com");
//user.Email = "brus@mail.com";
//user.Show();


//User user = new Admin(101, "vasia@mail.com");
//if (user is Admin admin)
//{
//    admin.Email = "brus@mail.com";
//    admin.Show();
//}

//class User
//{
//    public readonly static int minAge = 18;
//    public const double Pi = 3.14;
//    public int Id { get; set; }
//    public string Email { get; set; } = "no_email";
//    public User(int id, string email)
//    {
//        Id = id;
//        Email = email;
//    }
//    public void Show()
//    {
//        Console.WriteLine($"User: {Email}");
//    }
//}

//class Admin : User
//{
//    public new readonly static int minAge = 30;
//    public new const double Pi = 3.1415;
//    // public new int Id { get; set; }          // :-( Дублирование id в объекте Admin
//    public new string Email
//    {
//        get => $"admin: {base.Email}";
//        set => base.Email = value;
//    }
//    public Admin(int id, string email) 
//        : base(id, email)
//    {}
//    public new void Show()
//    {
//        base.Show();
//        Console.WriteLine($"Admin: {Email}");
//    }
//}

#endregion
