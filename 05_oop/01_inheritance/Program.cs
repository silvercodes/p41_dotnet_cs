
#region Inheritance

// Ограничения
// === 1. Только одиночное наследование (но... interfaces :-))
// === 2. Модификатор наследования - public (в терминах C++)
// === 3. Модификатор класса-наследника должен быть такой же или более строгий

//B obj = new B();

//internal class A
//{}

//public class B: A
//{}

// === 4. Класс можно сделать sealed (в C++ это финализированный final class)
// sealed class A {}
// class B: A {}       // ERROR

// === 5. Наследование от статического класса запрещено



Admin a = new Admin("vasia@mail.com", 23, "read");
a.Render();
a.Show();

internal class User
{
  private string email = string.Empty;

  public string Email { get => email; set => email = value; }
  public int Age { get; set; }

  public User()
  {}

  public User(int age)
  {
    Age = age;
    Console.WriteLine("User(int age)");
  }

  public User(string email, int age):
    this(age)
  {
    Email = email;
    Console.WriteLine("User(string email, int age)");
  }

  public void Render()
  {
    Console.WriteLine($"Email: {Email}");
  }
}

internal class Admin: User
{
  public string Permission {get; set;}
  public Admin(string email, int age, string permission):
    base(email, age)
  {
    Permission = permission;
    Console.WriteLine("Admin ctor");
  }
  public void Show()
  {
    Console.WriteLine($"Email: {Email}");
  }
}







#endregion



