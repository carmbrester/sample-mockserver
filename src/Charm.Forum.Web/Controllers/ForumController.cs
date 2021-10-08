using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charm.Forum.ForumServiceClient.Api;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Charm.Forum.Web.Controllers
{
    public class ForumController : Controller
    {
        // GET: ForumController
        public async Task<IActionResult> Index()
        {
            var client = new PostsApi(Environment.GetEnvironmentVariable("FORUM_SERVICE_URL"));
            var posts = await client.GetPostsAsync();
            return Ok(posts);
        }
    }
}
