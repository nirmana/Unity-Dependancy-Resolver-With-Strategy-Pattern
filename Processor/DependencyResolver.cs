using Resolver;
using System.ComponentModel.Composition;
using Util.Interfaces;

namespace Processor
{
    [Export(typeof(IComponent))]
    public class DependencyResolver : IComponent
    {
        public void SetUp(IRegisterComponent registerComponent)
        {
            registerComponent.RegisterType<IInitiate, Initiate>();
        }
    }
}
