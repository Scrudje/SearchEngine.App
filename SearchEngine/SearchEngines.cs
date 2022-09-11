using Newtonsoft.Json.Linq;
using SerpApi;
using System.Collections;
using SearchEngine.Lib.SerpClass;
using System.Text.Json;


namespace SearchEngine
{
    public class SearchEngines {
         public  List<String> Search(String engine, String searchedWord, String apiKey)
        {
            String query=String.Empty;
            switch (engine)
            {
                case "google":
                case "bing":
                case "baidu":
                    query = "q";
                    break;
                case "yandex":
                    query="text";
                    break;
                case "yahoo":
                    query = "p";
                    break;
                default:
                    break;
           
            }
            Hashtable ht = new Hashtable();
            ht.Add("engine", engine);

            ht.Add(query, searchedWord);

            List<String> results = new List<String>();

            try
            {
                GoogleSearch search = new GoogleSearch(ht, apiKey);
                JObject data = search.GetJson();
                var organic_results = data["organic_results"].ToString();
                var myDeserializedResponse = JsonSerializer.Deserialize<List<SearchResult>>(organic_results);
                foreach (SearchResult item in myDeserializedResponse)
                {
                    results.Add($"#{item.Position}:  Title: {item.Title}; Snippet: {item.Snippet}; URL: {item.DisplayedLink}");
                }
            }
            catch (SerpApiSearchException ex)
            {
                Console.WriteLine("Exception:");
                Console.WriteLine(ex.ToString());
            }
            return results;

        }
    }
}

