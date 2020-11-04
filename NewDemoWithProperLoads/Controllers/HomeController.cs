using NewDemoWithProperLoads.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace NewDemoWithProperLoads.Controllers
{
    [System.Web.Http.Route("api")]
    public class HomeController : ApiController
    {
        private IRepo _repo;

        public HomeController(IRepo repo)
        {
            _repo = repo;
        }

        [System.Web.Http.HttpGet]
        public IEnumerable<string> Index()
        {
            return _repo.Get();
        }

    }
}