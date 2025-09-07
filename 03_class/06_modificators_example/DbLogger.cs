namespace _06_modificators_example;

public class DbLogger : Logger
{
    public DbLogger()
    {
        this.path = "/var/log";
        this.level = 3;
        this.key = "lkj";
    }
}
