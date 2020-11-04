using GoodProject2020.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace GoodProject2020.Controllers
{
    [Route("api")]
    public class HomeController : ApiController
    {
        IRepo _repo;
        public HomeController(IRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<string> Index()
        {
            return _repo.Get();
        }
    }
}