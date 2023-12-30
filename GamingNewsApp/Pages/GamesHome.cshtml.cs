using GamingNewsApp.Models;
using GamingNewsApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamingNewsApp.Pages
{
    public class GamesHomeModel : PageModel
    {
        public GameList games;

        private readonly ILogger<GamesHomeModel> _logger;
        private readonly IGames _gameService;

        public GamesHomeModel(ILogger<GamesHomeModel> logger, IGames gamingNewsService)
        {
            _logger = logger;
            _gameService = gamingNewsService;
        }

        public void OnGet() //index page getting rendered by this method
        {
            games = _gameService.getGames(); //when the index page gets rendered automatically calls our function
            //after the news variable is created.there were so many steps before this. now we can display all the information
            //that this variable has on our .html.cs file
        }
    }
}
