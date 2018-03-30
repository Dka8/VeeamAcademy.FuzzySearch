using IEnumerableTrie;

namespace SearchPlayground.Service.Model
{
    public class Product : IHasStringKeys
    {
        public string Name { get; set; }

        public string[] Keys => new[] {Name.ToLower()};
    }
}