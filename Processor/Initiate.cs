using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Util.Interfaces;

namespace Processor
{
    public class Initiate : IInitiate
    {
        IStrategyResolver _IStrategyResolver;
        public Initiate(IStrategyResolver IStrategyResolver)
        {
            _IStrategyResolver = IStrategyResolver;
        }

        public string GetMyDependancies()
        {
            string response = string.Empty;
            List<string> assemblyNames = GetAllDependantAssemblyNames();
            foreach (string assemblyName in assemblyNames) {
                var provider = _IStrategyResolver.Resolve<IDependencyProvider>(assemblyName);
                response += provider.MyMethod()+" from "+ assemblyName + "</br>";
            }
            return response;
        }

        public List<string> GetAllDependantAssemblyNames() {
            List<string> allAssemblyNames = new List<string>();
            string binPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin");
            foreach (string dll in Directory.GetFiles(binPath, "Dep.*.dll"))
                allAssemblyNames.Add(Assembly.LoadFile(dll).GetName().Name);

            return allAssemblyNames;
        }
    }
}
