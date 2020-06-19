using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace clash_royale_clan_tracker_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClansController : ControllerBase
    {
        static Repository.ClashRoyaleApiRepository clashRoyaleApi = new Repository.ClashRoyaleApiRepository();

        [HttpGet]
        public async Task<Object> Clan(string clanTag)
        {
            return await clashRoyaleApi.Get("/clans/%23" + clanTag);
        }
    }
}