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
    public class PornTitle
    {
        public string Title { get; set; }
        public string ButtonText { get; set; }
    }

    public class DefaultController : ApiController
    {

        public Task<PornTitle> GetHelloWorld()
        {
            var test = new PornTitle { Title = "Test", ButtonText = "Test" };
            return Task.FromResult(test);
        }

    }
}
