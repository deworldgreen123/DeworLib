namespace DeworLib.Dal.Models;

public class Author : BaseModel
{
    public string Name { get; set; }
    public List<Book>? Books { get; set; } = [];
}