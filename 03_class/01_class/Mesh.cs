namespace _01_class;

internal class Mesh
{
    public string title;
    public Point3d position;

    public void Deconstruct(out string title, out Point3d position)
    {
        title = this.title;
        position = this.position;
    }
}
