#include <iostream>

//struct Point
//{
//    int x{};
//    int y{};
//};
//
//
//class User
//{
//public:
//    int id;
//    std::string email;
//};
//
//
//int main()
//{
//    /*Point a{ 3, 4 };
//    Point* b = new Point{ 3, 4 };
//
//    User c{ 101, "vasia@mail.com" };
//    User* d = new User{ 102, "petya@mail.com" };
//
//    bool e = true;*/
//
//
//    /*User* a = new User{};
//    User* b = new User{};
//    std::cout << a == b << '\n';*/
//
//    /*std::string input;
//    std::cin >> input;*/
//
//    //int a = 4;
//    //int b = 5;
//    //std::cout << a + b;     // operator+(a, b)
//
//    int arr[3]{ 4, 6, 7 };
//    for (int item : arr)
//        std::cout << item << '\n';
//}




// static void modify1(int val)
// {
// 	val = val * 2;
// }

// static void modify2(int& val)
// {
// 	val = val * 2;
// }

// static void modify3(int* val)
// {
// 	*val = *val * 2;
// }
// static void modify4(int*& val)
// {
// 	*val = *val * 2;
// }
// static void modify5(int** val)
// {
// 	**val = **val * 2;
// }

// void add(int a, int b, int& result)
// {
// 	// result = a + b;
// }

// //void f1(const int& val)
// //{
// //	val = 45;	// ERROR
// //}

// void f1(const int* const val)
// {
// 	*val = 45;	// ERROR
// }


// int main()
// {
// 	int a{ 12 };
// 	modify1(a);
// 	modify2(a);
// 	modify3(&a);

// 	int* ptr = &a;
// 	modify4(ptr);

// 	modify5(&ptr);

// }



class User
{
	public:
		int id;
		std::string email;

		User(int id, std::string email)
		{
			this->id = id;
			this->email = email;
		}
		User(int id)
			: User(id, "vasia@mail.com")
		{}
}

