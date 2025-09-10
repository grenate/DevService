namespace DevService.Contracts;

public record GetQuestionsDTO(string Searche, Guid[] TagIds, int page, int pageSize);