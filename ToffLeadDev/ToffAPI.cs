using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ToffLeadDev
{
    public class ToffAPI
    {
        public const string DEFAULT_API_URL = "https://origination.tinkoff.ru/api/v1/public/partner/";
        public const string DEFAULT_MEDIA_TYPE = "application/json";
        public const string CREATE_APP_FUNC = "createApplication";

        public const string DEFAULT_AGENT_ID = "0ec65cde-acfa-4e66-a42f-28fca3fa617a";
        public const string DEFAULT_API_KEY = "ecb6e61f-c4b5-4a4b-a468-0f3bd1d54e1d";
        public const string DEFAULT_API_SECRET = "8GLURP5BVH9WEZ5D";

        private static string pApiUrl;
        private static string pAgentId;
        private static string pApiKey;
        private static string pApiSecret;

        public static void setAuthParams(string apiUrl, string agentId, string apiKey, string apiSecret)
        {
            pApiUrl = apiUrl;
            pAgentId = agentId;
            pApiKey = apiKey;
            pApiSecret = apiSecret;
        }
        
        public static string createApplication(ToffLead lead)
        {
            string result = "";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(pApiUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(DEFAULT_MEDIA_TYPE));
                makeHttpHeaders(client, pAgentId, pApiKey, pApiSecret);

                var response = client.PostAsJsonAsync(CREATE_APP_FUNC, lead).Result;
                var reponseMess = response.Content.ReadAsStringAsync();

                result = reponseMess.Result.ToString();
            }

            return result;
        }

        private static void makeHttpHeaders(HttpClient client, string agentId, string apiKey, string apiSecret)
        {
            ToffHeaders toffHeaders = new ToffHeaders(agentId, apiKey, apiSecret);

            foreach (KeyValuePair<string, string> pair in toffHeaders.GetHttpHeaders())
                client.DefaultRequestHeaders.Add(pair.Key, pair.Value);
        }
    }
}
