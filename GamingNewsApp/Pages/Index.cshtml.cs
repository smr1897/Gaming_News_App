using GamingNewsApp.Models;
using GamingNewsApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamingNewsApp.Pages
{
    public class IndexModel : PageModel
    {
        public Root news;

        private readonly ILogger<IndexModel> _logger;
        private readonly IGamingNewsService _gamingNewsService;

        public IndexModel(ILogger<IndexModel> logger , IGamingNewsService gamingNewsService)
        {
            _logger = logger;
            _gamingNewsService = gamingNewsService;
        }

        public void OnGet() //index page getting rendered by this method
        {
            news = _gamingNewsService.GetGamingNews(); //when the index page gets rendered automatically calls our function
            //after the news variable is created.there were so many steps before this. now we can display all the information
            //that this variable has on our .html.cs file
        }
    }
}