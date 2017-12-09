using Util.Interfaces;

namespace Dep.Z
{
    public class Actions : IDependencyProvider
    {
        public string MyMethod()
        {
            return "Hello";
        }
    }
}
