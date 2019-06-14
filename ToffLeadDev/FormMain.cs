using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToffLeadDev
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            textBoxURL.Text = ToffAPI.DEFAULT_API_URL;
            textBoxAgentId.Text = ToffAPI.DEFAULT_AGENT_ID;
            textBoxApiKey.Text = ToffAPI.DEFAULT_API_KEY;
            textBoxApiSecret.Text = ToffAPI.DEFAULT_API_SECRET;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            ToffAPI.setAuthParams(textBoxURL.Text, textBoxAgentId.Text, textBoxApiKey.Text, textBoxApiSecret.Text);

            ToffLead lead = new ToffLead();
            lead.product = "РКО";
            lead.source = "Локальные агенты";
            lead.subsource = "API";
            lead.firstName = "ВАЛЕРИЯ";
            lead.middleName = "СЕРГЕЕВНА";
            lead.lastName = "ЧЕКУНОВА";
            lead.phoneNumber = "+79221747787";
            lead.email = null;
            lead.isHot = false;
            lead.companyName = "ОБЩЕСТВО С ОГРАНИЧЕННОЙ ОТВЕТСТВЕННОСТЬЮ \"МЭД ГРУПП\"";
            lead.innOrOgrn = "667011019699";
            lead.comment = null;
            lead.temperature = "COLD";

            textBoxResponce.Text = ToffAPI.createApplication(lead);
        }        
    }
}
