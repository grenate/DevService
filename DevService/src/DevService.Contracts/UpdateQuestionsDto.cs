namespace DevService.Contracts;

public record UpdateQuestionDTO(string Title, string Body, Guid[] TagIds );
