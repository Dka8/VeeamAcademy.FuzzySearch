using System;
using System.Diagnostics;
using Newtonsoft.Json;
using SearchPlayground.Service;
using SearchPlayground.Service.DataAccess;
using SearchPlayground.Service.DataProcessing;
using SearchPlayground.Service.Engine;

namespace SearchPlayground.App
{
    
    class Program
    {
        private static Stopwatch _stopwatch = new Stopwatch();
        
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage:-\n\nLevenshteinDistance <string> <distance>");
                return;
            }

            var dataService = new DataCashedService(new FileDataService());
            var engine = new LevenshteinDistanceEngine();
            var searchLogic = new SearchLogic(dataService, engine);
            
//            _stopwatch.Start();
//            var closest = searchLogic.SearchClosestTo(args[0], int.Parse(args[1]));
//            _stopwatch.Stop();
            var processor = new TrieDataProcessing(dataService);
            _stopwatch.Start();
            var finded = processor.ProcessProducts(args[0]);
            _stopwatch.Stop();

            Console.WriteLine(JsonConvert.SerializeObject(finded));
            Console.WriteLine(_stopwatch.ElapsedMilliseconds);
        }
    }
}
