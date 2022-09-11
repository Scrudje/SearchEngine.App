using System.Text.Json.Serialization;

namespace SearchEngine.Lib.SerpClass
{
    public class SearchResult
    {
        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("displayed_link")]
        public string DisplayedLink { get; set; }

        [JsonPropertyName("snippet")]
        public string Snippet { get; set; }
    }
}
