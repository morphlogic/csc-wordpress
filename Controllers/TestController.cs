using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace CSC.WordPress.Controllers
{
    public class TestController : Controller
    {
        public ContentResult Index()
        {
            return Content("Test worked");            
        }
    }
}
