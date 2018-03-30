using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using SearchPlayground.Service.Model;

namespace SearchPlayground.Service.DataAccess
{
    public class FileDataService : IDataService
    {
        private const string StorageFile = "products.json";
        
        public IEnumerable<Product> GetAllDatas()
        {
            return ReadFromFile();
        }

        private List<Product> ReadFromFile()
        {
            if (!File.Exists(StorageFile))
            {
                return new List<Product>
                {
                    new Product{Name = "table"},
                    new Product{Name = "plate"},
                    new Product{Name = "knife"},
                    new Product{Name = "cup"},
                    new Product{Name = "spoon"}
                };
            }

            var json = File.ReadAllText(StorageFile);
            return JsonConvert.DeserializeObject<List<Product>>(json);
        }
    }
}