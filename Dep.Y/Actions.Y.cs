using Util.Interfaces;

namespace Dep.Y
{
    public class Actions : IDependencyProvider
    {
        public string MyMethod()
        {
            return "Hello";
        }
    }
}
