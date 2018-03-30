using System.Collections.Generic;
using SearchPlayground.Service.Model;

namespace SearchPlayground.Service.DataAccess
{
    public class DataCashedService : IDataService
    {
        private readonly IDataService _dataService;
        private IEnumerable<Product> _datas;

        public DataCashedService(IDataService dataService)
        {
            _dataService = dataService;
        }

        public IEnumerable<Product> GetAllDatas()
        {
            return _datas ?? (_datas = _dataService.GetAllDatas());
        }
    }
}