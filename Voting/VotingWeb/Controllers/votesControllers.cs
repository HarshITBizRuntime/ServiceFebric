    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

namespace VotingWeb.Controllers
{
    [Produces("application/json")]
    [Route("api/Votes")]
    public class votesControllers : Controller
    {
        private readonly HttpClient httpClient;

        public votesControllers(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        // GET: api/Votes
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<KeyValuePair<string, int>> votes = new List<KeyValuePair<string, int>>();
            votes.Add(new KeyValuePair<string, int>("Pizza", 3));
            votes.Add(new KeyValuePair<string, int>("Ice cream", 4));

            return Json(votes);
        }
    }
}