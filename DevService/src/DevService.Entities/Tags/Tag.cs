namespace DevService.Entities.Tags;

public class Tag
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public string Description { get; set; }
}