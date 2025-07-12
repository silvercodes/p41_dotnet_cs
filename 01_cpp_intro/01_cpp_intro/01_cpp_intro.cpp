#include <iostream>

//int main()
//{
//    /*int a = 45;
//    
//    int* ptr = &a;
//
//    std::cout << &ptr << '\n';
//    std::cout << ptr << '\n';
//    std::cout << *ptr;*/
//
//
//
//    /*int* a = new int{ 32 };
//
//    int* arr = new int[3] {};
//
//    int arr2[3];
//
//    std::cout << arr << '\n';
//    std::cout << arr2 << '\n';*/
//
//
//
//    //int* arr = new int[5] {4, 6, 8, 2, 3};
//
//    //std::cout << *arr << '\n';
//    //std::cout << *(arr + 1) << '\n';        // arr + 1 * size(int)
//
//
//
//
//    //int** arr = new int* [3];
//    //for (int i = 0; i < 3; ++i)
//    //    // arr[i] = new int[3];
//    //    *(arr + i) = new int[3];
//    //
//    ////arr[i][j];                    // *(*(arr + i) + j)
//    //arr[1][2];                      // *(*(arr + 1) + 2)
//
//
//
//
//    int a = 45;
//
//    int& ref = a;
//    int* const ptr = &a;
//
//    const int& ref2 = a;
//    const int* const ptr2 = &a;
//    
//}


struct Point
{
public:
	int x;
	int y;
	Point(int x = 0, int y = 0):
		x{x},
		y{y}
	{ }
};
class Unit
{
public:
	std::string* title;
	Point position;
	Unit(std::string* title, Point position)
	{
		this->title = title;
		this->position = position;
	}
	void Render()
	{
		std::cout << *(this->title) << ' ' << this->position.x << ' ' << this->position.y << '\n';
	}
};

//void Exec(Unit* u)
//{
//    u->position.x = 55;
//    u->position.y = 77;
//}
//
//int main()
//{
//	std::string title = "warrior";
//	Unit* a = new Unit{ &title, {7, 8} };
//
//	a->Render();
//	Exec(a);
//	a->Render();
//}


void Exec(Unit*& u)
{
	std::string title = "archer";
	u = new Unit{ &title, {12, 15} };
	u->position.x = 55;
	u->position.y = 77;
}

int main()
{
	std::string title = "warrior";
	Unit* a = new Unit{ &title, {7, 8} };

	a->Render();
	Exec(a);
	a->Render();
}