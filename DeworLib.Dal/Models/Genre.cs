namespace DeworLib.Dal.Models;

public class Genre : BaseModel
{
    public string Name { get; set; }
    public List<Book> Books { get; set; } = [];
}