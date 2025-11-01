
#region Intro
//ExecuteDel del;

////del = f1;
////// del += f2;          // ERROR
////del += User.Show;

////del();
////del?.Invoke();


//ExecuteDel del1 = f1;
//ExecuteDel del2 = User.Show;

//ExecuteDel del3 = del1 + del2;
//del3?.Invoke();


//void f1()
//{
//    Console.WriteLine("f1()");
//}
//void f2(int x = 10)
//{
//    Console.WriteLine($"x = {x}");
//}
//class User
//{
//    public static void Show()
//    {
//        Console.WriteLine("Show() from user class");
//    }
//}

//// ExecuteDel --> MulticastDelegate --> Delegate

//delegate void ExecuteDel();
#endregion

#region Practice_1

//Notifier notifier = new Notifier();
//notifier.Process("Hello Vasia", true, false, true);

//class Notifier
//{
//    delegate void NotifyHandler(string message);

//    private NotifyHandler handler;
//    public void Process(string message, bool email = true, bool tlg = false, bool sms = false)
//    {
//        // ------ Раннее (статическое) связывание
//        //if (email)
//        //    NotifyEmail(message);
//        //if (tlg)
//        //    NotifyTelegram(message);
//        //if (sms)
//        //    NotifySMS(message);

//        // ------ Позднее (динамическое) связывание
//        if (email)
//            handler += NotifyEmail;
//        if (tlg)
//            handler += NotifyTelegram;
//        if (sms)
//            handler += NotifySMS;

//        handler?.Invoke(message);
//    }

//    private void NotifyEmail(string message)
//    {
//        Console.WriteLine($"Email: {message}");
//    }
//    private void NotifyTelegram(string message)
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine($"Telegram: ${message}");
//        Console.ResetColor();
//    }
//    private void NotifySMS(string message)
//    {
//        Console.ForegroundColor = ConsoleColor.Blue;
//        Console.WriteLine($"Sms: ${message}");
//        Console.ResetColor();
//    }
//}

#endregion

#region Practice_2

//NotifyHandler handler = SendEmail;
//handler += SendTelegram;
//handler += SendSms;

//handler?.Invoke("Hello");

//handler -= SendTelegram;
//handler?.Invoke("Buy");


//void SendEmail(string message) => Console.WriteLine($"Email: {message}");
//void SendTelegram(string message) => Console.WriteLine($"Tlelgram: {message}");
//void SendSms(string message) => Console.WriteLine($"Sms: {message}");

//delegate void NotifyHandler(string message);

#endregion

#region Generic delegates

//Operation<string, int> op = Process;
//Console.WriteLine(op?.Invoke(3, 4));

//Operation<Operation<int, double>, int> op2;

//string Process(int a, int b) => $"{a} + {b} = {a + b}";

//delegate T Operation<T, K>(K a, K b);





//int? Execute(int a, int b, Operation<int> op)
//{
//    return op?.Invoke(a, b);
//}

//Operation<int> GetOperation(OpType opType) => opType switch
//{ 
//    OpType.Add => Add,
//    OpType.Multiply => Mult,
//    OpType.Substract => Sub,

//    _ => throw new NotSupportedException()
//};

//Operation<int> operation = GetOperation(OpType.Add);
//Console.WriteLine(operation?.Invoke(4, 5));
//Console.WriteLine(Execute(2, 3, operation));


//int Add(int a, int b) => a + b;
//int Mult(int a, int b) => a * b;
//int Sub(int a, int b) => a - b;

//enum OpType
//{
//    Add,
//    Multiply,
//    Substract,
//}

//delegate T Operation<T>(T a, T b);

#endregion

#region Practice_3 (Observer pattern)

// Account acc = new Account(1000);
// acc.AddNotifier(new EmailNotifier());
// acc.AddNotifier(new TelegramNotifier());
// acc.AddNotifier(new SmsNotifier());

// acc.Add(100);
// acc.Withdraw(2000);

// interface INotifier
// {
//     void Notify(string message);
// }

// class TelegramNotifier : INotifier
// {
//     public void Notify(string message)
//     {
//         Console.WriteLine($"Telegram: ${message}");
//     }
// }
// class EmailNotifier : INotifier
// {
//     public void Notify(string message)
//     {
//         Console.WriteLine($"Email: ${message}");
//     }
// }
// class SmsNotifier : INotifier
// {
//     public void Notify(string message)
//     {
//         Console.WriteLine($"Sms: ${message}");
//     }
// }

// class Account
// {
//     private int sum;
//     private List<INotifier> notifiers = new List<INotifier>();
//     public void AddNotifier(INotifier notifier) => notifiers.Add(notifier);
//     public Account(int initSum) => sum = initSum;
//     public void Add(int val)
//     {
//         sum += val;

//         EmitEvent($"ADDED: {val}");
//     }
//     public void Withdraw(int val)
//     {
//         if (sum >= val)
//         {
//             sum -= val;
//             EmitEvent($"WITHDRAWN: {val}");
//         }
//         else
//         {
//             EmitEvent($"ERROR: {val}");
//         }
//     }

//     private void EmitEvent(string message)
//     {
//         foreach (INotifier notifier in notifiers)
//         {
//             notifier.Notify(message);
//         }
//     }
// }





#endregion

#region Anonymus methods

// NotifyHandler handler = delegate (string message)
// {
//     System.Console.WriteLine($"From anonymus method: {message}");
// };

// handler?.Invoke("vasia");

// delegate void NotifyHandler(string message);






// void WindowsNotifier(string message)
// {
//     System.Console.WriteLine($"Windows: {message}");
// }
// Notify("Hello Vasia", WindowsNotifier);



// Notify("Hello Petya", delegate (string message)
// {
//     Console.ForegroundColor = ConsoleColor.Green;
//     System.Console.WriteLine($"From anonymus: {message}");
//     Console.ResetColor();
// });



// NotifyHandler handler = WindowsNotifier;
// Notify("Hello Dima", handler);


// Notify("Hello Kolya", delegate
// {
//     System.Console.WriteLine("Hardcoded text");
// });


// void Notify(string message, NotifyHandler handler)
// {
//     handler?.Invoke(message);
// }

// delegate void NotifyHandler(string message);




// int factor = 4;

// ResultGetter rg = delegate (int a, int b)
// {
//     return (a + b) * factor;
// };
// System.Console.WriteLine(rg(3, 4));

// delegate int ResultGetter(int a, int b);






// Executor GenerateExecutor(int factor)
// {
//     return delegate (int a, int b)
//     {
//         return (a + b) * factor;
//     };
// }

// Executor a = GenerateExecutor(2);
// System.Console.WriteLine(a(1, 1));
// System.Console.WriteLine(a(2, 2));

// Executor b = GenerateExecutor(10);
// System.Console.WriteLine(b(1, 1));
// System.Console.WriteLine(b(2, 2));

// delegate int Executor(int a, int b);






// Counter CreateCounter(int initValue)
// {
//     int count = initValue;
//     return delegate ()
//     {
//         System.Console.WriteLine($"Count = {count}");
//         count++;
//     };
// }

// Counter a = CreateCounter(0);
// a();
// a();
// a();
// a();

// Counter b = CreateCounter(100);
// b();
// b();
// b();
// b();

// delegate void Counter();

#endregion

#region Lambda

// Handler h1 = Method1;
// // >>> EQUALS <<<
// Handler h2 = new Handler(Method1);

// Handler h3 = delegate ()
// {
//     System.Console.WriteLine("From anonymus method");
// };

// Handler h4 = () => { System.Console.WriteLine("From lambda"); };

// Handler h5 = () => System.Console.WriteLine("From lambda");

// h5 += () => System.Console.WriteLine("HOHOHO");

// h5();



// void Method1()
// {
//     System.Console.WriteLine("Method1()");
// }

// delegate void Handler();
// delegate void Valenok();



// ===== lambda parameters / returns

// OperationHandler operation1 = (int a, int b) => { return a + b; };          // :-|
// // >>> EQUALS <<<
// OperationHandler operation2 = (a, b) => a + b;                              // :-)))

// int result = operation2(3, 4);


// RenderHandler rh1 = (string message) => { System.Console.WriteLine(message); }; // :-|
// // >>> EQUALS <<<
// RenderHandler rh2 = m => System.Console.WriteLine(m);                           // :-)))

// rh2("Hello Vasia");


// delegate int OperationHandler(int a, int b);
// delegate void RenderHandler(string message);

#endregion

#region Practice_4
// TASK
// Создать метод, который суммирует элементы массива по условию, которое опредляется вне метода

// using System.Runtime.InteropServices;

// int[] arr = [4, 6, 7, 2, 2, 4, 9, 1, 1, 1, 5];

// int Sum(int[] arr)
// {
//     int sum = 0;

//     foreach (int item in arr)
//         if (item % 2 == 0)
//             sum += item;

//     return sum;
// }

// System.Console.WriteLine(Sum(arr));




// int Sum(int[] arr, Predicate predicate)
// {
//     int sum = 0;

//     foreach (int item in arr)
//         if (predicate(item))
//             sum += item;

//     return sum;
// }

// System.Console.WriteLine(Sum(arr, n => n % 2 == 0));
// System.Console.WriteLine(Sum(arr, n => n > 5));

// delegate bool Predicate(int val);

#endregion

#region Practice_5
// TASK
// Написать метод для поиска пользователей в коллекции по разным условиям (критериям)
// id == 110
// age < 18
// email starts with 'k'



List<User> users = new List<User>()
{
    new User(110, "vasia@mail.com", 34),
    new User(45, "petya@mail.com", 24),
    new User(112, "dima@mail.com", 15),
    new User(165, "kolya@mail.com", 21),
    new User(110, "chack_norris@mail.com", 23),
};

List<User> Find(List<User> users, Predicate predicate)
{
    List<User> result = new List<User>();

    foreach (User u in users)
        if (predicate(u))
            result.Add(u);

    return result;
}

// List<User> res1 = Find(users, u => u.Id == 110);
// res1.ForEach(u => Console.WriteLine(u));

// List<User> res2 = Find(users, u => u.Age < 18);
// res2.ForEach(u => Console.WriteLine(u));

// List<User> res3 = Find(users, u => u.Email.StartsWith('k'));
// res3.ForEach(u => Console.WriteLine(u));

List<User> res4 = Find(users, u =>
{
    if (u.Email is string e)
        return e.StartsWith('k');

    return false;
});
res4.ForEach(u => Console.WriteLine(u));

class User
{
    public int Id { get; set; }
    public string? Email { get; set; }
    public int Age { get; set; }
    public User(int id, string? email, int age)
    {
        Id = id;
        Email = email;
        Age = age;
    }
    public override string ToString()
    {
        return $"id: {Id}, email: {Email}, age: {Age}";
    }
}

delegate bool Predicate(User user);
#endregion



