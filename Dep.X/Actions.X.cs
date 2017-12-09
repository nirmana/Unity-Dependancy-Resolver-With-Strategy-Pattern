using Util.Interfaces;

namespace Dep.X
{
    public class Actions : IDependencyProvider
    {
        public string MyMethod()
        {
            return "Hello";
        }
    }
}
