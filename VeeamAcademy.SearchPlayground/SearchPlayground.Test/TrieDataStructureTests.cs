using System.Collections.Generic;
using SearchPlayground.Service.Model;
using Xunit;

namespace SearchPlayground.Test
{
    public class TrieDataStructureTests
    {
        IEnumerable<Product> data = new List<Product>{
            new Product{Name = "hello"},
            new Product{Name = "world"}
        };

        [Fact]
        public void Test()
        {
        }
    }
}