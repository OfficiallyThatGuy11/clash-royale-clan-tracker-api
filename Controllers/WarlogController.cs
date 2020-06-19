using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace clash_royale_clan_tracker_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WarlogController : Controller
    {
        static Repository.ClashRoyaleApiRepository clashRoyaleApi = new Repository.ClashRoyaleApiRepository();

        [HttpGet]
        public async Task<Object> Warlog(string clanTag)
        {
            return await clashRoyaleApi.Get("/clans/%23" + clanTag + "/warlog");
        }
    }
}