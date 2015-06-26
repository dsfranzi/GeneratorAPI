using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;

namespace PornTitleGenerator.Controllers
{
    public class DefaultController : ApiController
    {

        public Task<string> GetHelloWorld()
        {
            return Task.FromResult("Hello World");
        }

    }
}
