
#region Intro
// string? a = null;

// string? input = Console.ReadLine();

//void Render(string? str)
//{
//    if (str == null)
//        Console.WriteLine("null!!!");
//    else
//        Console.WriteLine(str);
//}

//string? input = null;

////if (input != null)
////    Render(input);

//Render(input);

//Console.WriteLine();



// ====== nullable value types

// id email       age
//101      vasia@mail   23
//103      vasia2@mail  
//105      vasia3@mail  23

//User a = new() { Id = 101, Email = "vasia@mail.com", Age = 23 };
//User b = new() { Id = 103, Email = "vasia2@mail.com", Age = null };

//class User
//{
//    public int Id { get; set; }
//    public string Email { get; set; }
//    public int? Age { get; set; }
//}


// int a = null;       // ERROR
//int? b = null;         // Nullable<int> b = null;
//string? c = null;

//int a;
//int? b; 
#endregion

#region Null guard

//void Render(string? message)
//{
//    //if (message == null)
//    //    return;
//    //Console.WriteLine($"Message: {message}");


//    //if (message is null)
//    //    return;
//    //Console.WriteLine($"Message: {message}");


//    //if (message is not null)
//    //    Console.WriteLine($"Message: {message}");


//    //if (message is string)
//    //    Console.WriteLine($"Message: {message}");
//}

#endregion

#region Null union  ??  ??=

//Console.Write("Enter your name: ");

//// 1.
////string? input = Console.ReadLine();
////string value = input ?? "no_value";     // string value = input != null ? input : "no_value";

//// 2.
////string value = Console.ReadLine() ?? "no_value";

//// 3.
//string? input = Console.ReadLine();
//input ??= "no_value";                   // input = input ?? "no_value"

//Console.WriteLine($"Hello {input}");

#endregion

#region Conditional null (условный null)

//void RunProcess(User? user)
//{
//    //if (user is not null && user.Role is not null && user.Role.Title is not null)
//    //    user.Role.Render();

//    user?.Role?.Render();
//}

//User a = new() { Role = null };
//RunProcess(a);


//class Role
//{
//    public string? Title { get; set; }
//    public void Render() => Console.WriteLine($"Title = {Title}");
//}
//class User
//{
//    public Role? Role { get; set; }
//}

#endregion

#region Null forgiven operator  !

//string? input = null;
//Render(input!);

//void Render(string val) => Console.WriteLine(val);

//class Container
//{
//    public string Config { get; set; } = null!;
//}

#endregion

#region Enable/disable nullable ctx

#nullable disable
string a = null;
//
//
#nullable restore

string b = null;

#endregion
