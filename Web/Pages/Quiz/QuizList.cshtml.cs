using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BackendLab01.Pages.Quiz
{
    public class QuizListModel : PageModel
    {

		private readonly IQuizUserService _quizUserService;
		public QuizListModel(IQuizUserService quizUserService)
		{
			_quizUserService = quizUserService;
		}
		[BindProperty]
		public List<BackendLab01.Quiz> Quizzes { get; set; }
		public void OnGet()
        {
			Quizzes = _quizUserService.FindAll();
		}
    }
}
