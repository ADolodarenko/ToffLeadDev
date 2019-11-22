using System;
using System.Drawing;
using System.Windows.Forms;
using ToffLeadDev.Properties;

namespace ToffLeadDev
{
    /*
     * Главная форма приложения.
     */
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
            SetMainTitle(Settings.Default.MainTitle, true, false);

            InitSourceFileTextBox();

            FillTextBoxes();
        }

        private void InitSourceFileTextBox()
        {
            pathButton = new Button();
            pathButton.Size = new Size(25, textBoxSourceFile.ClientSize.Height + 2);
            pathButton.Location = new Point(textBoxSourceFile.ClientSize.Width - pathButton.Width, -1);
            pathButton.Cursor = Cursors.Default;
            pathButton.Image = Resources.OpenFolder;
            pathButton.Click += new EventHandler(pathButton_Click);
            textBoxSourceFile.Controls.Add(pathButton);

            // Send EM_SETMARGINS to prevent text from disappearing underneath the button
            SendMessage(textBoxSourceFile.Handle, 0xd3, (IntPtr)2, (IntPtr)(pathButton.Width << 16));
        }

        private void FillTextBoxes()
        {
            textBoxURL.Text = Settings.Default.ApiUrl;
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

            dataProcessor.Process();

            //dataProcessor.Start();

            textBoxResponce.Lines = dataProcessor.GetLogLines().ToArray();
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

        private void SetMainTitle(string title, bool withVersion = false, bool withBuildDate = false)
        {
            this.Text = title;

            if (withVersion)
                this.Text += (" " + AppService.GetVersion());

            if (withBuildDate)
                this.Text += (" (" + AppService.GetBuildDate().ToString() + ")");
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void ShowSettings()
        {
            using (FormSettings formSettings = new FormSettings())
            {
                formSettings.ShowDialog(this);
            }

            SetMainTitle(Settings.Default.MainTitle, true, false);
        }
    }
}
