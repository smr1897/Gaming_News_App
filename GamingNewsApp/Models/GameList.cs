using Newtonsoft.Json;

namespace GamingNewsApp.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AddedByStatus
    {
        [JsonProperty("yet")]
        public int Yet { get; set; }

        [JsonProperty("owned")]
        public int Owned { get; set; }

        [JsonProperty("beaten")]
        public int Beaten { get; set; }

        [JsonProperty("toplay")]
        public int Toplay { get; set; }

        [JsonProperty("dropped")]
        public int Dropped { get; set; }

        [JsonProperty("playing")]
        public int Playing { get; set; }
    }

    public class EsrbRating
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public class Filters
    {
        [JsonProperty("years")]
        public List<Year> Years { get; set; }
    }

    public class Genre
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("games_count")]
        public int GamesCount { get; set; }

        [JsonProperty("image_background")]
        public string ImageBackground { get; set; }
    }

    public class ParentPlatform
    {
        [JsonProperty("platform")]
        public Platform Platform { get; set; }
    }

    public class Platform
    {
        [JsonProperty("platform")]
        public Platform platform { get; set; }

        [JsonProperty("released_at")]
        public string ReleasedAt { get; set; }

        [JsonProperty("requirements_en")]
        public RequirementsEn RequirementsEn { get; set; }

        [JsonProperty("requirements_ru")]
        public RequirementsRu RequirementsRu { get; set; }
    }

    public class Platform2
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("image")]
        public object Image { get; set; }

        [JsonProperty("year_end")]
        public object YearEnd { get; set; }

        [JsonProperty("year_start")]
        public int? YearStart { get; set; }

        [JsonProperty("games_count")]
        public int GamesCount { get; set; }

        [JsonProperty("image_background")]
        public string ImageBackground { get; set; }
    }

    public class Rating
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }
    }

    public class RequirementsEn
    {
        [JsonProperty("minimum")]
        public string Minimum { get; set; }

        [JsonProperty("recommended")]
        public string Recommended { get; set; }
    }

    public class RequirementsRu
    {
        [JsonProperty("minimum")]
        public string Minimum { get; set; }

        [JsonProperty("recommended")]
        public string Recommended { get; set; }
    }

    public class Result
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("released")]
        public string Released { get; set; }

        [JsonProperty("tba")]
        public bool Tba { get; set; }

        [JsonProperty("background_image")]
        public string BackgroundImage { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("rating_top")]
        public int RatingTop { get; set; }

        [JsonProperty("ratings")]
        public List<Rating> Ratings { get; set; }

        [JsonProperty("ratings_count")]
        public int RatingsCount { get; set; }

        [JsonProperty("reviews_text_count")]
        public int ReviewsTextCount { get; set; }

        [JsonProperty("added")]
        public int Added { get; set; }

        [JsonProperty("added_by_status")]
        public AddedByStatus AddedByStatus { get; set; }

        [JsonProperty("metacritic")]
        public int Metacritic { get; set; }

        [JsonProperty("playtime")]
        public int Playtime { get; set; }

        [JsonProperty("suggestions_count")]
        public int SuggestionsCount { get; set; }

        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        [JsonProperty("user_game")]
        public object UserGame { get; set; }

        [JsonProperty("reviews_count")]
        public int ReviewsCount { get; set; }

        [JsonProperty("saturated_color")]
        public string SaturatedColor { get; set; }

        [JsonProperty("dominant_color")]
        public string DominantColor { get; set; }

        [JsonProperty("platforms")]
        public List<Platform> Platforms { get; set; }

        [JsonProperty("parent_platforms")]
        public List<ParentPlatform> ParentPlatforms { get; set; }

        [JsonProperty("genres")]
        public List<Genre> Genres { get; set; }

        [JsonProperty("stores")]
        public List<Store> Stores { get; set; }

        [JsonProperty("clip")]
        public object Clip { get; set; }

        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }

        [JsonProperty("esrb_rating")]
        public EsrbRating EsrbRating { get; set; }

        [JsonProperty("short_screenshots")]
        public List<ShortScreenshot> ShortScreenshots { get; set; }

        public List<Result> Results { get; set; }
    }

    public class GameList
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }

        [JsonProperty("seo_title")]
        public string SeoTitle { get; set; }

        [JsonProperty("seo_description")]
        public string SeoDescription { get; set; }

        [JsonProperty("seo_keywords")]
        public string SeoKeywords { get; set; }

        [JsonProperty("seo_h1")]
        public string SeoH1 { get; set; }

        [JsonProperty("noindex")]
        public bool Noindex { get; set; }

        [JsonProperty("nofollow")]
        public bool Nofollow { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("filters")]
        public Filters Filters { get; set; }

        [JsonProperty("nofollow_collections")]
        public List<string> NofollowCollections { get; set; }

    }

    public class ShortScreenshot
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class Store
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("store")]
        public Store store { get; set; }
    }

    public class Store2
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("games_count")]
        public int GamesCount { get; set; }

        [JsonProperty("image_background")]
        public string ImageBackground { get; set; }
    }

    public class Tag
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("games_count")]
        public int GamesCount { get; set; }

        [JsonProperty("image_background")]
        public string ImageBackground { get; set; }
    }

    public class Year
    {
        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("decade")]
        public int Decade { get; set; }

        [JsonProperty("years")]
        public List<Year> Years { get; set; }

        [JsonProperty("nofollow")]
        public bool Nofollow { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("year")]
        public int year { get; set; }
    }



}
