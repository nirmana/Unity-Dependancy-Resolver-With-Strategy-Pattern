using Resolver;
using System.ComponentModel.Composition;
using System.Reflection;
using Util.Interfaces;

namespace Dep.Z
{
    [Export(typeof(IComponent))]
    public class DependencyResolver : IComponent
    {
        public void SetUp(IRegisterComponent registerComponent)
        {
            string assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            registerComponent.RegisterType<IDependencyProvider, Actions>(assemblyName);
        }
    }
}
