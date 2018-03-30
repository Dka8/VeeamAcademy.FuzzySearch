using System.Collections.Generic;
using IEnumerableTrie;
using SearchPlayground.Service.DataAccess;
using SearchPlayground.Service.Model;

namespace SearchPlayground.Service.DataProcessing
{
    public class TrieDataProcessing : IDataProcessingService
    {
        private IDataService _dataService;

        public TrieDataProcessing(IDataService dataService)
        {
            _dataService = dataService;
        }
            
        public IEnumerable<Product> ProcessProducts(string include)
        {
            var products = _dataService.GetAllDatas();
            var trie = new Trie<Product>(products);

            return trie.GetValuesByPrefix(include);
        }
    }
}