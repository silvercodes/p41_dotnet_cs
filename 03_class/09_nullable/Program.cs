

// string? a = null;

// string? input = Console.ReadLine();

void Render(string? str)
{
    if (str == null)
        Console.WriteLine("null!!!");
    else
        Console.WriteLine(str);
}

string? input = null;

//if (input != null)
//    Render(input);

Render(input);

Console.WriteLine();

