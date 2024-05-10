namespace DeworLib.Dal.Models;

public class Book : BaseModel
{
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    
    public List<Chapter>? Chapters { get; set; } = [];
    public List<Genre>? Genres { get; set; } = [];
    public List<Genre>? Authors { get; set; } = [];
}