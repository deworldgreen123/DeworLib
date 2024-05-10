namespace DeworLib.Dal.Models;

public class Chapter : BaseModel
{
    public int Number { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Content { get; set; }
    
    public int BookId { get; init; }
    public Book? Book { get; init; }
}