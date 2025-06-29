namespace _01_class;

class User
{
    public int id;
    public string email = "default_email";

    //public User()
    //{
    //    id = 101;
    //    email = "no_email";
    //}
    //public User(int id)
    //{
    //    this.id = id;
    //    email = "no_email";
    //}
    //public User(int id, string email)
    //{
    //    this.id = id;
    //    this.email = email;
    //}

    public User()
        : this(101, "no_email")
    {}
    public User(int id)
        : this(id, "no_email")
    {}
    public User(int id, string email)
    {
        this.id = id;
        this.email = email;
    }

    public void Render()
    {
        Console.WriteLine($"id: {id}, email: {email}");
    }
}
