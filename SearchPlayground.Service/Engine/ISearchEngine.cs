namespace SearchPlayground.Service.Engine
{
    public interface ISearchEngine
    {
        int CountDistance(string from, string to);
    }
}