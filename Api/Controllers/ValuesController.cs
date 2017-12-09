using System;
using System.Web.Http;
using Util.Interfaces;

namespace Api.Controllers
{
    public class ValuesController : ApiController
    {
        IInitiate _Initiate;

        public ValuesController(IInitiate Initiate)
        {
            _Initiate = Initiate;
        }
        
        public string Get()
        {
            return _Initiate.GetMyDependancies();
        }

       
    }
}