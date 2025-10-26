
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

Account acc = new Account(1000);
acc.AddNotifier(new EmailNotifier());
acc.AddNotifier(new TelegramNotifier());
acc.AddNotifier(new SmsNotifier());

acc.Add(100);
acc.Withdraw(2000);

interface INotifier
{
    void Notify(string message);
}

class TelegramNotifier : INotifier
{
    public void Notify(string message)
    {
        Console.WriteLine($"Telegram: ${message}");
    }
}
class EmailNotifier : INotifier
{
    public void Notify(string message)
    {
        Console.WriteLine($"Email: ${message}");
    }
}
class SmsNotifier : INotifier
{
    public void Notify(string message)
    {
        Console.WriteLine($"Sms: ${message}");
    }
}

class Account
{
    private int sum;
    private List<INotifier> notifiers = new List<INotifier>();
    public void AddNotifier(INotifier notifier) => notifiers.Add(notifier);
    public Account(int initSum) => sum = initSum;
    public void Add(int val)
    {
        sum += val;

        EmitEvent($"ADDED: {val}");
    }
    public void Withdraw(int val)
    {
        if (sum >= val)
        {
            sum -= val;
            EmitEvent($"WITHDRAWN: {val}");
        }
        else
        {
            EmitEvent($"ERROR: {val}");
        }
    }

    private void EmitEvent(string message)
    {
        foreach (INotifier notifier in notifiers)
        {
            notifier.Notify(message);
        }
    }
}





#endregion




