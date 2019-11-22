using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ToffLeadDev
{
    /*
     * Класс с методами вызова API на сайте.
     */
    public class ToffAPI
    {
        public const string DEFAULT_MEDIA_TYPE = "application/json";
        public const string CREATE_APP_FUNC = "createApplication";

        private static string pApiUrl;
        private static string pAgentId;
        private static string pApiKey;
        private static string pApiSecret;

        /*
         * Установка параметров подключения.
         */
        public static void setAuthParams(string apiUrl, string agentId, string apiKey, string apiSecret)
        {
            pApiUrl = apiUrl;
            pAgentId = agentId;
            pApiKey = apiKey;
            pApiSecret = apiSecret;
        }
        
        /*
         * Создание заявки на обслуживание.
         */
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
