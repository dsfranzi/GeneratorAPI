using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;
using PornTitleGenerator.Data;

namespace PornTitleGenerator.Controllers
{
    public class PornTitle
    {
        public string Title { get; set; }
        public string ButtonText { get; set; }
    }

    public class DefaultController : ApiController
    {

        public async Task<PornTitle> GetSingleTitle()
        {
            string acceptLanguage = Request.Headers.AcceptLanguage.ToString();

            var nameTask = Task<string>.Factory.StartNew(() => Generator.GetRandomName(acceptLanguage));
            var titleTask = Task<string>.Factory.StartNew(() => Generator.GetRandomTitle(acceptLanguage));

            string result = string.Concat(await nameTask, " ", await titleTask);

            var pornTitle = new PornTitle { Title = result, ButtonText = Generator.GetRandomButtonText(acceptLanguage) };
            return pornTitle;
        }

    }
}
