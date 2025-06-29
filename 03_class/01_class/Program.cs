using _01_class;


//User user = new User();

//Console.WriteLine($"id = {user.id}");
//user.id = 101;

//user.Render();


//User a = new User();
//User b = new User(101);
//User c = new User(102, "vasia@mail.com");


//Unit unit = new Unit("warrior", 5);


//User user = new User()
//{
//    email = "brus_willis@mail.com",
//    id = 102,
//};

//user.Render();


//Mesh mesh = new Mesh()
//{
//    title = "archer",
//    //position = new Point3d() { x = 0, y = 0, z = 0 },
//    // >>>>> EQUALS <<<<<
//    position = { x = 0, y = 0, z = 0 },
//};

//Mesh a = new()
//{
//    title = "warrior",
//    position = new() { x = 0, y = 0, z = 0 },
//};



//Figure f = new(new Point3d() { x = 3, y = 4, z = 5 }, 45, 50)
//{
//    lablel = "f_1"
//};


//Point3d p = new Point3d() { x = 1, y = 2, z = 9 };

//(int x, int y, int z) = p;
//Console.WriteLine($"{x};{y};{z}");



Mesh m = new()
{
    title = "m1",
    position = new Point3d() { x = 0, y = 0, z = 0 },
};

(string a, Point3d b) = m;

(_, Point3d p) = m;

m.Deconstruct(out string str, out Point3d ptr);


