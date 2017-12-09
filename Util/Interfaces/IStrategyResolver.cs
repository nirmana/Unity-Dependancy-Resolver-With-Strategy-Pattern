namespace Util.Interfaces
{
    public interface IStrategyResolver
    {
        T Resolve<T>(string namedStrategy);
    }
}
