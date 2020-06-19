using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace clash_royale_clan_tracker_api.Repository
{
    public class ClashRoyaleApiRepository
    {
        static HttpClient httpClient = new HttpClient();

        public async Task<Object> Get(string endpoint)
        {
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri("https://api.clashroyale.com/v1" + endpoint),
                Method = HttpMethod.Get,
            };
            request.Headers.Add("authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiIsImtpZCI6IjI4YTMxOGY3LTAwMDAtYTFlYi03ZmExLTJjNzQzM2M2Y2NhNSJ9.eyJpc3MiOiJzdXBlcmNlbGwiLCJhdWQiOiJzdXBlcmNlbGw6Z2FtZWFwaSIsImp0aSI6ImE5NTNiNTI3LWI4ZjgtNDQzNS1iZDdmLWNkMzVkZDBiYTdiNSIsImlhdCI6MTU2MDYwMDE4OCwic3ViIjoiZGV2ZWxvcGVyL2ZlZmIyZGQ1LWI4OTktODlkMC0yYmY4LTk2NmZlODk5OGMwOCIsInNjb3BlcyI6WyJyb3lhbGUiXSwibGltaXRzIjpbeyJ0aWVyIjoiZGV2ZWxvcGVyL3NpbHZlciIsInR5cGUiOiJ0aHJvdHRsaW5nIn0seyJjaWRycyI6WyI4MS4xMTEuMTM4LjQ1Il0sInR5cGUiOiJjbGllbnQifV19.kAufsv_nf0pWqswUBZVy_DUmU-n44MLM01tGhJfT78W3pNddEdN69ktPFUKSDWcGMm2DfNmpjK-jaVb7_1mFRQ");


            HttpResponseMessage response = await httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
