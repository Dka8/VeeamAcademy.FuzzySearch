using System.Collections.Generic;
using SearchPlayground.Service.DataAccess;
using SearchPlayground.Service.Engine;
using SearchPlayground.Service.Model;

namespace SearchPlayground.Service
{
    public class SearchLogic
    {
        private readonly IDataService _dataService;
        private readonly ISearchEngine _searchEngine;

        public SearchLogic(IDataService dataService, ISearchEngine searchEngine)
        {
            _dataService = dataService;
            _searchEngine = searchEngine;
        }

        public IEnumerable<Product> SearchClosestTo(string to, int distance)
        {
            var datas = _dataService.GetAllDatas();
            var closest = new List<Product>();

            foreach (var data in datas)
            {
                if (_searchEngine.CountDistance(data.Name, to) <= distance) closest.Add(data);
            }

            return closest;
        }
    }
}