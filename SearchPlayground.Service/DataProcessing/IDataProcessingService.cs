using System.Collections.Generic;
using SearchPlayground.Service.Model;

namespace SearchPlayground.Service.DataProcessing
{
    public interface IDataProcessingService
    {
        IEnumerable<Product> ProcessProducts(string include);
    }
}