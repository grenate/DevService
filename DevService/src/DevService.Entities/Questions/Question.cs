using DevService.Entities.Answers;

namespace DevService.Entities.Questions;


public class Question
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public required string Text { get; set; }
    public required Guid UserId { get; set; }
    public Guid? ScreenshotId { get; set; }
    public List<Answer> Answers { get; set; } =  new List<Answer>();
    public Answer? Solution {get; set;}
    public List<Guid> Tags { get; set; } = new List<Guid>();
    public List<Guid> Comments { get; set; } = new List<Guid>();
    
    
    
}