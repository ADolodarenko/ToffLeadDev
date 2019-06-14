using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToffLeadDev
{
    public class ToffHeaders
    {
        private string agentId;
        private string apiKey;
        private string apiSecret;

        public ToffHeaders(string agentId, string apiKey, string apiSecret)
        {
            this.agentId = agentId;
            this.apiKey = apiKey;
            this.apiSecret = apiSecret;
        }

        public Dictionary<string, string> GetHttpHeaders()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Partner-Basic api-key=\"");
            builder.Append(apiKey);
            builder.Append("\", api-secret=\"");
            builder.Append(apiSecret);
            builder.Append("\", agent-id=\"");
            builder.Append(agentId);
            builder.Append("\"");

            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Authorization", builder.ToString());

            return headers;
        }
    }
}
