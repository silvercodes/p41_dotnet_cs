
#region Intro


//User u = new User();
//u.SetId(101);

//class User
//{
//    private int id;
//    private int age;

//    public int GetId()
//    {
//        return id;
//    }

//    public void SetId(int id)
//    {
//        this.id = id;
//    }

//    public bool IsAdult()
//    {
//        return age >= 18;
//    }
//}



//User u = new User();
//u.Id = 101;
//Console.WriteLine(u.Id);

//u.Age = 23;
//Console.WriteLine(u.Age);


//class User
//{
//    private int id;
//    private int age;

//    public int Id
//    {
//        get
//        {
//            return id;
//        }
//        set
//        {
//            id = value;
//        }
//    }

//    public int Age
//    {
//        get
//        {
//            return age;
//        }
//        set
//        {
//            age = value < 0 ? 18 : value;
//        }
//    }

//}

#endregion

#region "partial" properties


//User u = new User();

////Console.WriteLine(u.Email);
////u.Email = "vasia@mail.com";         // ERROR

////u.Age = 34;
////Console.WriteLine(u.Age);               // ERROR

//Console.WriteLine(u.Info);
//Console.WriteLine(u.GetInfo());

//class User
//{
//    private string email = "no_email";
//    private int age;

//    public string Email
//    {
//        get
//        {
//            return email;
//        }
//    }

//    public int Age
//    {
//        set
//        {
//            age = value;
//        }
//    }

//    public string Info
//    {
//        get
//        {
//            return $"Email: {Email}, Age: {age}";
//        }
//    }

//    public string GetInfo()
//    {
//        return $"Email: {Email}, Age: {age}";
//    }
//}

#endregion

#region Modificators

User u = new();

class User
{
    private string email = "no_email";
    private int age;

    public string Email
    {
        get
        {
            return email;
        }
        protected set
        {
            email = value;
        }
    }

    //public int Age              // ERROR: Модификатор блока только у полновесного свойства
    //{
    //    protected get
    //    {
    //        return age;
    //    }
    //}


    protected int Age
    {
        get
        {
            return age;
        }
    }

}




#endregion
