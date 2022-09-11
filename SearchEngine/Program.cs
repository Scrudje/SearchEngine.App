String apiKey=SearchEngine.KeyLoad.Load();

if (apiKey =="")
{
    Console.WriteLine("Ключ не найден!");
    return;
}

Console.Write("Введите слово для поиска: ");
var searchedWord = Console.ReadLine();

Console.WriteLine("Выберите поисковую систему (можно несколько): ");
Console.WriteLine("1 - Google");
Console.WriteLine("2 - Yandex");
Console.WriteLine("3 - Bing");
Console.WriteLine("4 - Yahoo");
var searchedEngines = Console.ReadLine();



Task[] tasks = new Task[searchedEngines.Length];
for (int i = 0; i < searchedEngines.Length; i++)
{ 
        switch (searchedEngines[i])
        {
            case '1':
                tasks[i]=new Task (()=>SearchEngine.ViewResults.Show ("google", new SearchEngine.SearchEngines().Search("google",searchedWord,apiKey)));
                break;
            case '2':
                tasks[i]=new Task (()=>SearchEngine.ViewResults.Show ("yandex", new SearchEngine.SearchEngines().Search("yandex",searchedWord,apiKey)));
                break;
            case '3':
                tasks[i]=new Task (()=>SearchEngine.ViewResults.Show ("bing", new SearchEngine.SearchEngines().Search("bing",searchedWord,apiKey)));
                break;
            case '4':
                tasks[i]=new Task (()=>SearchEngine.ViewResults.Show ("yahoo", new SearchEngine.SearchEngines().Search("yahoo",searchedWord,apiKey)));
                break;
            default:
                tasks[i] = new Task(() => Console.WriteLine("Некорректно введена поисковая система!")); ;
                break;
        }

}

foreach (var task in tasks)
{
    if (task is not null)
    { 
        task.Start();    
    }

}

Task.WaitAll(tasks);

