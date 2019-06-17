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
        Button pathButton;

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
            InitSourceFileTextBox();

            FillTextBoxes();
        }

        private void InitSourceFileTextBox()
        {
            pathButton = new Button();
            pathButton.Size = new Size(25, textBoxSourceFile.ClientSize.Height + 2);
            pathButton.Location = new Point(textBoxSourceFile.ClientSize.Width - pathButton.Width, -1);
            pathButton.Cursor = Cursors.Default;
            pathButton.Image = Properties.Resources.OpenFolder;
            pathButton.Click += new EventHandler(pathButton_Click);
            textBoxSourceFile.Controls.Add(pathButton);

            // Send EM_SETMARGINS to prevent text from disappearing underneath the button
            SendMessage(textBoxSourceFile.Handle, 0xd3, (IntPtr)2, (IntPtr)(pathButton.Width << 16));            
        }

        private void FillTextBoxes()
        {
            textBoxURL.Text = ToffAPI.DEFAULT_API_URL;
            textBoxAgentId.Text = ToffAPI.DEFAULT_AGENT_ID;
            textBoxApiKey.Text = ToffAPI.DEFAULT_API_KEY;
            textBoxApiSecret.Text = ToffAPI.DEFAULT_API_SECRET;
        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                textBoxSourceFile.Text = openFileDialog.FileName;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            DataProcessor dataProcessor = new DataProcessor(textBoxSourceFile.Text,
                                                            textBoxURL.Text, textBoxAgentId.Text,
                                                            textBoxApiKey.Text, textBoxApiSecret.Text);

            List<string> logLines = dataProcessor.Process();

            textBoxResponce.Lines = logLines.ToArray();


            /*
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
            */
        }

        private void textBoxSourceFile_Resize(object sender, EventArgs e)
        {
            if (sender.Equals(textBoxSourceFile))
                ResetPathButton(pathButton, textBoxSourceFile);
        }

        private void ResetPathButton(Button button, TextBox parentTextBox)
        {
            button.Size = new Size(button.Width, parentTextBox.ClientSize.Height + 2);
            button.Location = new Point(parentTextBox.ClientSize.Width - button.Width, -1);

            // Send EM_SETMARGINS to prevent text from disappearing underneath the button
            SendMessage(parentTextBox.Handle, 0xd3, (IntPtr)2, (IntPtr)(button.Width << 16));
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
    }
}
