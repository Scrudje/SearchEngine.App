

namespace SearchEngine
{
    static public class ViewResults
    {

        public static void Show(string searchEngine, List<string> searchResults)
        {
            Console.WriteLine();
            switch (searchEngine)
            {
                case "google":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("GOOGLE SEARCH RESULTS:");
                    break;
                case "yandex":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YANDEX SEARCH RESULTS:");
                    break;
                case "bing":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("BING SEARCH RESULTS:");
                    break;
                case "yahoo":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("YAHOO SEARCH RESULTS:");
                    break;
                default:
                    break;

            }

            Console.WriteLine();
            foreach (string searchResult in searchResults)
            {
                Console.WriteLine(searchResult);
                Console.WriteLine();

            }
            Console.ResetColor();

        }


    }
}
