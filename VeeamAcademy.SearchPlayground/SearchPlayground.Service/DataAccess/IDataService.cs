using System.Collections.Generic;
using SearchPlayground.Service.Model;

namespace SearchPlayground.Service.DataAccess
{
    public interface IDataService
    {
        IEnumerable<Product> GetAllDatas();
    }
}