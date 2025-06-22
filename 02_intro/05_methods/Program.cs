
// [modificator] return_type name ([parameters])
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



void Add(ref int val) => val += 10;

int a = 3;
Add(ref a);
Console.WriteLine(a);




#endregion

