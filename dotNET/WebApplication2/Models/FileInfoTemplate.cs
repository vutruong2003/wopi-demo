namespace WebApplication2.Models;

public class FileInfoTemplate
{
    public string BaseFileName { get; set; }

    public int Size { get; set; }

    public int UserId { get; set; }

    public bool UserCanWrite { get; set; }
}
