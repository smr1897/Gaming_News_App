using GamingNewsApp.Models;
using Newtonsoft.Json;

namespace GamingNewsApp.Services
{
    public interface IGamingNewsService
    {
        WorldNews GetGamingNews();
    }

    public class NewsService : IGamingNewsService
    {
        private readonly IConfiguration Configuration; //dependncy injection for reading api key. reads key value pairs
        public NewsService(IConfiguration configuration) 
        {
            Configuration = configuration;
        }

        public WorldNews GetGamingNews()
        {
            string apiKey = Configuration.GetValue<string>("napk");
            string baseurl = Configuration.GetValue<string>("newsap");

            using(var client = new HttpClient()) 
            {
                client.BaseAddress = new Uri(baseurl);

                HttpResponseMessage response = client.GetAsync("?country=us&apiKey=" + apiKey).Result;
                

                if(response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<WorldNews>(result); //takes the json response and convert it into a WorldNews c# object
                }
                else
                {
                    return new WorldNews()
                    {
                        Articles = new List<Article>(),
                        TotalResults = 0,
                        Status = "",

                    };
                }
            }
        }//after this method add this new service to the dependancy injection. Go to program.cs and add service 
    }
}
