namespace _01_class;

internal class Point3d
{
    public int x;
    public int y;
    public int z;

    public void Deconstruct(out int x, out int y, out int z)
    {
        x = this.x;
        y = this.y;
        z = this.z;
    }
}
