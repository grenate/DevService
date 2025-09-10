using DevService.Contracts;
using DevService.Entities.Questions;
using Microsoft.AspNetCore.Mvc;

namespace DevService.Presenters;
[ApiController]
[Route("[controller]")]
public class QuestionController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(
        [FromBody] CreateQuestionDTO questionDto, CancellationToken cancellationToken)
    {
        return Ok("Question Created");
    }

    [HttpGet]
    public async Task<IActionResult> Get(
        [FromQuery] GetQuestionsDTO questionDto, CancellationToken cancellationToken )
    {
        return Ok("Question get");
    }

    [HttpGet("{questionId:guid}")]
    public async Task<IActionResult> GetById([FromRoute] Guid questionId, CancellationToken cancellationToken)
    {
        return Ok("Question get");
    }
    [HttpPut("{questionId:guid}")]
    public async Task<IActionResult> Update(
        [FromRoute] Guid questionId, [FromBody]UpdateQuestionDTO updateQuestionDto, 
        CancellationToken cancellationToken)
    {
        return Ok("Question updated");
    }

    [HttpDelete("{questionId:guid}")]
    public async Task<IActionResult> Delete([FromRoute] Guid questionId, CancellationToken cancellationToken)
    {
        return Ok("Question deleted");
    }

    /// <summary>
    /// Выбирает правильный ответ
    /// </summary>
    /// <param name="questionId"></param>
    /// <param name="answerId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPut("{questionId:guid}/solution")]
    public async Task<IActionResult> SelectSolution([FromRoute] Guid questionId, [FromQuery] Guid answerId,
        CancellationToken cancellationToken)
    {
        return Ok("Solution selected");
    }
    
    [HttpPost("{questionId:guid}/answers")]
    public async Task<IActionResult> AddAnswer(
        [FromRoute] Guid questionId, [FromBody] AddAnswerDTO questionDto, CancellationToken cancellationToken)
    {
        return Ok("Answer added");
    }
}