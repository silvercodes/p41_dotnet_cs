
// [modificators] return_type Name ([parameters])
// {
//
// }


//void Render()
//{
//    Console.WriteLine("test method");
//}
//// >>>>>> EQUALS <<<<<<<
//void Render2() => Console.WriteLine("test method");


//int Sum(int a, int b)
//{
//    return a + b;
//}
//// >>>>>> EQUALS <<<<<<<
//int Sum2(int a, int b) => a + b;


// void Sum(int a, int b) => Console.WriteLine($"RESULT = {a + b}");


//void Render(int id, string email = "no_email", int age = 18) 
//    => Console.WriteLine($"{id} {email} {age}");

//Render(101, "vasia@mail.com", 26);
//Render(101, "vasia@mail.com");
//Render(101);



#region Передача "по значению" и "по ссылке"

//int Add(int val) => val + 10;

//int a = 10;
//Add(a);

//Add(12);



//void Add(ref int val) => val += 10;

//int a = 3;
//Add(ref a);
//Console.WriteLine(a);



// ---- out (Выходной параметр) -----
//void Sum(int a, int b, out int result)
//{
//    result = a + b;
//}

//int result;
//Sum(3, 4, out result);
//Console.WriteLine(result);

//// >>>>>> EQUALS <<<<<<

//Sum(3, 4, out int result2);
//Console.WriteLine(result2);



//string Process(int h, int w, out int perimieter, out int area)
//{
//    perimieter = 2 * (h + w);
//    area = h * w;

//    return $"P = {perimieter}, S = {area}";
//}

//string info = Process(3, 4, out int p, out int s);
//Console.WriteLine($"s = {s}");
//Console.WriteLine($"p = {p}");
//Console.WriteLine(info);




// ---- in (Входной параметр) ----

//string Process(in int h, in int w, out int perimieter, out int area)
//{
//    // h = 45;         // ERROR
//    // w = 12;         // ERROR
//    perimieter = 2 * (h + w);
//    area = h * w;

//    return $"P = {perimieter}, S = {area}";
//}


// ---- ref readonly ----
//void Modify(ref readonly int val)
//{
//    val = 2;        // ERROR
//}



#endregion


#region params

//int Sum(params int[] values)
//{
//    int res = 0;
//    foreach (int value in values)
//        res += value;

//    return res;
//}

//int[] arr = { 4, 6, 7, 3, 4, 5 };
//int[] arr2 = { 4, 6, 7, 3, 4, 5 };
//Console.WriteLine(Sum(arr));
//Console.WriteLine(Sum(4, 5, 6, 7, 8));
//Console.WriteLine(Sum());




//int Sum(int init, params int[] values)
//{
//    int res = init;
//    foreach (int value in values)
//        res += value;

//    return res;
//}

//int[] arr = { 4, 6, 7, 3, 4, 5 };
//int[] arr2 = { 4, 6, 7, 3, 4, 5 };
//Console.WriteLine(Sum(10, arr));
//Console.WriteLine(Sum(4, 5, 6, 7, 8));
//Console.WriteLine(Sum(10));

#endregion


#region Recursion
// TASK
// Написать метод для вычисления n-го числа Фибоначчи
// 0 1 1 2 3 5 8 13 21 ....

//int Fibo(int index)
//{
//    if (index == 0 || index == 1)
//        return index;

//    return Fibo(index - 1) + Fibo(index - 2);
//}

//Console.WriteLine(Fibo(3));


#endregion


#region Local function

//void CompareArrays(int[] a, int[] b)
//{
//    int s1 = Sum(a);
//    int s2 = Sum(b);

//    Console.WriteLine(s1 > s2 ? "a > b": "a < b");

//    int Sum(int[] arr)
//    {
//        int result = 0;
//        foreach (int n in arr)
//            result += n;

//        return result;
//    }

//    static void Test()
//    {
//        // Console.WriteLine(s1);  // ERROR
//    }
//}

//// Sum();      // ERROR

#endregion


#region switch

//int val = 56;

//switch (val)
//{
//    case 0:
//        Console.WriteLine(0);
//        break;
//    case 1:
//    case 2:
//    case 3:
//        Console.WriteLine("1, 2, 3");
//        break;
//    case 4:
//        goto case 0;
//        break;
//    default:
//        Console.WriteLine("default");
//        break;

//}



//int Calc(int a, int b, int op)
//{
//    int result = op switch
//    {
//        1 => a + b,
//        2 => a - b,
//        3 => a * b,
//        4 => a / b,
//        _ => 0
//    };

//    return result;
//}


//int Calc(int a, int b, int op)
//{
//    return op switch
//    {
//        1 => a + b,
//        2 => a - b,
//        3 => a * b,
//        4 => a / b,
//        _ => 0
//    };
//}


//static int Calc(int a, int b, int op) => op switch
//{
//    1 => a + b,
//    2 => a - b,
//    3 => a * b,
//    4 => a / b,
//    _ => 0
//};

#endregion


#region enum


Console.WriteLine(Status.Fatal);
Console.WriteLine((byte)Status.Fatal);

enum Status : byte
{
    Running = 2,
    Pending = 4,
    Finished = 8,
    Error = 2,
    Fatal = Error
}

#endregion
