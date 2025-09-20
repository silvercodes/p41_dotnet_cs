
#region Intro


//User u = new User();
//u.SetId(101);

//class User
//{
//    private int id;
//    private int age;

//    public int GetId()
//    {
//        return id;
//    }

//    public void SetId(int id)
//    {
//        this.id = id;
//    }

//    public bool IsAdult()
//    {
//        return age >= 18;
//    }
//}



//User u = new User();
//u.Id = 101;
//Console.WriteLine(u.Id);

//u.Age = 23;
//Console.WriteLine(u.Age);


//class User
//{
//    private int id;
//    private int age;

//    public int Id
//    {
//        get
//        {
//            return id;
//        }
//        set
//        {
//            id = value;
//        }
//    }

//    public int Age
//    {
//        get
//        {
//            return age;
//        }
//        set
//        {
//            age = value < 0 ? 18 : value;
//        }
//    }

//}

#endregion

#region "partial" properties


//User u = new User();

////Console.WriteLine(u.Email);
////u.Email = "vasia@mail.com";         // ERROR

////u.Age = 34;
////Console.WriteLine(u.Age);               // ERROR

//Console.WriteLine(u.Info);
//Console.WriteLine(u.GetInfo());

//class User
//{
//    private string email = "no_email";
//    private int age;

//    public string Email
//    {
//        get
//        {
//            return email;
//        }
//    }

//    public int Age
//    {
//        set
//        {
//            age = value;
//        }
//    }

//    public string Info
//    {
//        get
//        {
//            return $"Email: {Email}, Age: {age}";
//        }
//    }

//    public string GetInfo()
//    {
//        return $"Email: {Email}, Age: {age}";
//    }
//}

#endregion

#region Modificators

//User u = new();

//class User
//{
//    private string email = "no_email";
//    private int age;

//    public string Email
//    {
//        get
//        {
//            return email;
//        }
//        protected set
//        {
//            email = value;
//        }
//    }

//    //public int Age              // ERROR: Модификатор блока только у полновесного свойства
//    //{
//    //    protected get
//    //    {
//    //        return age;
//    //    }
//    //}


//    protected int Age
//    {
//        get
//        {
//            return age;
//        }
//    }

//}




#endregion

#region Autoproperties

//User user = new(23);
//Console.WriteLine(user.Age);
//class User
//{
//    public string Email { get; set; }
//    // ==== EQUALS ====
//    //private string email;
//    //public string Email
//    //{
//    //    get
//    //    {
//    //        return this.email;
//    //    }
//    //    set
//    //    {
//    //        this.email = value;
//    //    }
//    //}

//    //public int Age { get; } = 18;
//    //public string Name { get; private set; }
//    //public string Password { get; set; } = "no_password";

//    //public User(int age)
//    //{
//    //    Age = age;
//    //}

//    //public void Render()
//    //{
//    //    // this.Age = 34;
//    //}
//}

#endregion

#region init block

//User user1 = new();
//User user2 = new User("vasia@mail.com");                // no_email
//User user3 = new() { Email = "petya@mail.com" };
//User user4 = new User() { Username = "chack_norris" };
//Console.WriteLine($"{user4.Username} {user4.Email}");

//// User user5 = new() { Password = "123123123" };       // ERROR



//class User
//{
//    private string username;
//    public string Email { get; init; } = "no_email";
//    public string Username
//    {
//        get
//        {
//            return username;
//        }
//        init
//        {
//            username = value;
//            Email = $"{username}@mail.com";
//        }
//    }

//    public string Password { get; } = "no_password";

//    public User()
//    {

//    }
//    public User(string email)
//    {

//    }
//}



// User user = new User() { Email = "lkj" };
//class User
//{
//    public int Id { get; }
//    public string Email { get; private set; }
//    public string Password { private get; init; }
//}

#endregion

#region Buns :-)

//class User
//{
//    private string email;
//    private string password;

//    public string Email
//    {
//        get => email;
//        set => email = value;
//    }

//    //public string Password
//    //{
//    //    get => password;
//    //}
//    // ==== EQALS ====
//    public string Password => password;
//}

#endregion

#region required

//User a = new User();                      // ERROR

//User b = new User("vasia@mail.com");      // ERROR

//User c = new User("vasia@mail.com")       // ERROR
//{
//    Age = 23
//};



// User d = new User()
// {
//    Age = 34,
//    Email = "vasia@mail.com",
// };

// class User
// {
//    public required int Age { get; set; }
//    public required string Email { get; set; }
//    public User()
//    { }

//     public User(string email)
//     {
//         Email = email;
//         Age = 1;
//     }
// }




#endregion

#region Task_1

//public class Product
//{
//    public string Title { get; private set; }
//    public decimal Price { get; protected set; }
//    public int Stock { get; internal set; } = 0;

//    public Product(string title, decimal price)
//    {
//        Title = title; 
//        Price = price;
//    }
//}

//public class DiscountProduct : Product
//{
//    public DiscountProduct(string title, decimal price, float factor) :
//        base(title, price)
//    {
//        Price = price * Convert.ToDecimal(factor);
//    }
//}




//var student = new Student();
//student.Grade = 10;
//student.Email = "vasia";

//public class Student
//{
//    private int grade;
//    private string email;
//    public string Email 
//    {
//        get => email;
//        set
//        {
//            if(string.IsNullOrEmpty(value) || !value.Contains('@'))
//                throw new ArgumentException("Invalid email");

//            email = value;
//        }
//    }

//    public int Grade
//    {
//        get => grade;
//        set
//        {
//            if (value < 1 || value > 12)
//                throw new ArgumentException("Grade must be between 1 and 12");

//            grade = value;
//        }
//    }
//}


#endregion

#region Task_2
// Создать класс WeatherData, который позволяет добавлять показания температуры
// Класс позволяет получить среднее значение температуры на основании накопленных заранее значений
// Класс должен уметь кэшировать результат вычислений


// WeatherData wd = new WeatherData();
// wd.AddTemp(15);
// wd.AddTemp(15);
// wd.AddTemp(30);

// Console.WriteLine(wd.Average);
// Console.WriteLine(wd.Average);
// Console.WriteLine(wd.Average);
// Console.WriteLine(wd.Average);

// wd.AddTemp(30);
// Console.WriteLine(wd.Average);
// Console.WriteLine(wd.Average);

// public class WeatherData
// {
//     private List<double> store = new List<double>();
//     private double average;
//     private bool isChanged = false;

//     public double Average
//     {
//         get
//         {
//             if (isChanged)
//             {
//                 average = store.Average();
//                 Console.WriteLine("RECALC");
//                 isChanged = false;
//             }

//             return average;
//         }
//     }

//     public void AddTemp(double temp)
//     {
//         store.Add(temp);
//         isChanged = true;
//     }
// }

#endregion