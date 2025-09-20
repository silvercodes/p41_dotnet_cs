
#region Overloading

// 1. Имя должно совпадать
// 2. Другое кол-во параметров
// 3. Тип (порядок) параметров
// 4. Модифификаторы параметров

//Console.WriteLine();
//class Container
//{
//    public void Method(int a, int b)
//    { }

//    public void Method(int a, int b, int c)
//    { }

//    public void Method(int a, string b)
//    { }

//    public void Method(string a, int b)
//    { }

//    public void Method(ref string a, ref readonly int b)
//    { }
//}

#endregion

#region static

//User a = new();
//User b = new();
//Console.WriteLine($"{a.id} {b.id}");

//class User
//{
//    // Статическое поле (НЕ является частью состояния объекта)
//    private static int maxId;

//    // Обычное поле (является частью состояния объекта)
//    public int id;

//    // Статический "конструктор" (Инициализирует статические поля и св-ва)
//    // 1. Нельзя использовать модификатор доступа
//    // 2. Нельзя вызвать явно ("вызывается" автоматически)
//    // 3. Нет this
//    // 4. Нет параметров
//    static User()
//    {
//        maxId = 0;
//    }

//    // Статический метод
//    // 1. Нет this
//    // 2. Внутри можно использовать только статические поля и св-ва
//    public static void ResetMaxId() => User.maxId = 101;

//    // Статическое св-во
//    public static int MaxId 
//    {
//        get => User.maxId;
//        set => User.maxId = value;
//    }

//    // Статическое автосвойство
//    public static int InstanceCount { get; set; } = 0;

//    // Обычный конструктор
//    public User()
//    {
//        id = ++User.MaxId;
//    }
//}

#endregion

#region const

//class User
//{
//    // НЕ является частью состояния объекта
//    // Инициализация при объявлении
//    public const string DEFAULT_ROLE = "guest";

//    // является частью состояния объекта
//    // Инициализация при объявлении либо в конструкторе
//    public readonly string DEFAULT_NAME = "no_name";

//    public static readonly int DEFAULT_LEVEL = 1;

//    public User(string defaultName)
//    {
//        DEFAULT_NAME = defaultName;
//    }
//}



//static class Tools
//{
//}


//readonly struct Shape
//{
//    public readonly string DEFAULT_NAME;
//    public int Size { get; }
//    public string Title { get; init; }
//    public Shape(int size, string title)
//    {
//        Size = size;
//        Title = title;
//    }
//}

#endregion
