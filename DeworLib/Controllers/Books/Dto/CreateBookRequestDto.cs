namespace DeworLib.Controllers.Books.Dto;

public class CreateBookRequestDto
{
    public string Title { get; init; }
    public string Description { get; init; }
    public int[] AuthorIds { get; init; }
}