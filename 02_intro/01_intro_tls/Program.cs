
//// comment
///*
//    comment
//    comment
// */

//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello Vasia");

#region variable

//int a;

//int b = 2;

//string c = "brus_willis@mail.com";

//b = 5;
//c = "vasia@mail.com";

//Console.WriteLine(b);





//const int a = 23;
//a = 34;                 // ERROR



#endregion


#region Literal

//var a = 34;

//Console.WriteLine(true);
//Console.WriteLine(false);

//Console.WriteLine(2);
//Console.WriteLine(-2);
//Console.WriteLine(200);

//Console.WriteLine(0b101);
//Console.WriteLine(0xFF);


//Console.WriteLine(34.2);
//Console.WriteLine(3e4);     // 3 * 10 ^ 4


// Console.WriteLine('*');

//Console.WriteLine('\n');
//Console.WriteLine('\t');
//Console.WriteLine('\\');


//Console.WriteLine("hello");
//Console.WriteLine("Vasia");


//int? a = null;
//Console.WriteLine(a);

#endregion


#region Types
// value types (structs)
//bool a = true;

//byte b = 3;         // 0 -> 255
//sbyte c = -3;       // -128 -> 127

//short d = -234;
//ushort e = 23;

//int f = -45;
//uint g = 12;

//long h = -123;
//ulong i = 34;

//float j = 4.56f;
//double k = 4.67;
//decimal l = 4.6m;

//char m = '3';

//// reference types (classes)

//string n = "Vasia";
//object o = null;



//int a = 4;
//int b = 4;
//Console.WriteLine(a == b);

//User c = new User();
//User d = new User();
//Console.WriteLine(c == d);


//class User
//{ }

#endregion


#region Console

//Console.WriteLine("Vasia");
//Console.Write("Petya\n");

//string email = "vasia@mail.com";
//int age = 34;
//bool isAdmin = false;

//Console.WriteLine(email);
//Console.WriteLine(age);
//Console.WriteLine(isAdmin);

//Console.WriteLine($"email: {email}, age: {age}, isAdmin: {isAdmin}");



//Console.Write("Enter your email: ");
//string email = Console.ReadLine();
//Console.WriteLine($"Hello {email}");

//Console.Write("Enter your age: ");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"AGE: {age}");



Console.SetCursorPosition(10, 3);
Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.DarkGreen;

Console.WriteLine("VASIA");

Console.ResetColor();
Console.WriteLine("PETYA");

int a = 4;
int b = 6;
Console.WriteLine($"Result = {a + b}");


#endregion





