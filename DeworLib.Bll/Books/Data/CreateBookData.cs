namespace DeworLib.Bll.Books.Data;

public class CreateBookData
{
    public Guid Id { get; init; }
    public string Title { get; init; }
    public string Description { get; init; }
    public int[] AuthorIds { get; init; }
}