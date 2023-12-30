using GamingNewsApp.Models;
using Newtonsoft.Json;

namespace GamingNewsApp.Services
{
    public interface IGamingNewsService
    {
        Root GetGamingNews();
    }

    public class NewsService : IGamingNewsService
    {
        private readonly IConfiguration Configuration; //dependncy injection for reading api key. reads key value pairs
        public NewsService(IConfiguration configuration) 
        {
            Configuration = configuration;
        }

        public Root GetGamingNews()
        {
            string apiKey = Configuration.GetValue<string>("News_Api_Key2");
            string baseurl = Configuration.GetValue<string>("News_Api_url2");

            using(var client = new HttpClient()) 
            {
                client.BaseAddress = new Uri(baseurl);

                HttpResponseMessage response = client.GetAsync("").Result;
                

                if(response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<Root>(result); //takes the json response and convert it into a WorldNews c# object
                }
                else
                {
                    return new Root()
                    {
                        Articles = new List<Article>(),
                        TotalResults = 0,
                        Status = ""

                    };
                }
            }
        }//after this method add this new service to the dependancy injection. Go to program.cs and add service 
    }
}
