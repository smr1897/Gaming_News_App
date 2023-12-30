using GamingNewsApp.Models;
using Newtonsoft.Json;
namespace GamingNewsApp.Services
{
    public interface IGames
    {
        GameList getGames();
    }

    public class gameService : IGames
    {
        private readonly IConfiguration _configuration;

        public gameService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public GameList getGames()
        {
            string apikey = _configuration.GetValue<string>("Game_Api_key");
            string baseurl = _configuration.GetValue<string>("Game_Api_Url");

            using (var client = new HttpClient()) 
            {
                client.BaseAddress = new Uri(baseurl);
                HttpResponseMessage response = client.GetAsync("?key=" + apikey).Result;

                if(response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<GameList>(result);
                }
                else
                {
                    return new GameList()
                    {
                        Count = 0,
                        Next = "",
                        Previous = "",
                        Results = new List<Result>()
                    };
                }
            }
        }
    }
}
