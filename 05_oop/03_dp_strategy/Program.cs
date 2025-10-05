
Compressor compressor = new Compressor("/var/logs.txt", "/var/dump/logs.archive")
{
    Strategy = new ZipStrategy()
};

compressor.Compress();
compressor.Decompress();

compressor.Strategy = new RarStrategy();
compressor.Compress();
compressor.Decompress();

compressor.Strategy = new DeflateStrategy();
compressor.Compress();
compressor.Decompress();

// --------------------------------------------------

abstract class Strategy
{
    public abstract void Packing(string filePath, string archivePath);
    public abstract void Unpacking(string filePath, string archivePath);
}

class ZipStrategy : Strategy
{
    public override void Packing(string filePath, string archivePath)
    {
        Console.WriteLine($"Zip: {filePath} ---> {archivePath}");
    }

    public override void Unpacking(string filePath, string archivePath)
    {
        Console.WriteLine($"Zip: {archivePath} ---> {filePath}");
    }
}
class RarStrategy : Strategy
{
    public override void Packing(string filePath, string archivePath)
    {
        Console.WriteLine($"Rar: {filePath} ---> {archivePath}");
    }

    public override void Unpacking(string filePath, string archivePath)
    {
        Console.WriteLine($"Rar: {archivePath} ---> {filePath}");
    }
}
class DeflateStrategy: Strategy
{
    public override void Packing(string filePath, string archivePath)
    {
        Console.WriteLine($"Deflate: {filePath} ---> {archivePath}");
    }

    public override void Unpacking(string filePath, string archivePath)
    {
        Console.WriteLine($"Deflate: {archivePath} ---> {filePath}");
    }
}

class Compressor
{
    public string FilePath { get; set; }
    public string ArchivePath { get; set; }
    public required Strategy Strategy { get; set; }
    public Compressor(string filePath, string archivePath)
    {
        FilePath = filePath;
        ArchivePath = archivePath;
    }
    public void Compress()
    {
        Console.WriteLine($"Call Compress for file {FilePath}");
        Strategy.Packing(FilePath, ArchivePath);
    }
    public void Decompress()
    {
        Console.WriteLine($"Call Decompress for archive {ArchivePath}");
        Strategy.Unpacking(FilePath, ArchivePath);
    }
}
