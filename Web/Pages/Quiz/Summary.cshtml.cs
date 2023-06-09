using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BackendLab01.Pages;

public class Summary : PageModel
{
    private readonly IQuizUserService _userService;

    public int Score { get; set; }
    public Summary(IQuizUserService userService)
    {
        _userService = userService;
    }
    public void OnGet(int quizId, int userId)
    {
        Score = _userService.CountCorrectAnswersForQuizFilledByUser(quizId, userId);
    }
}