using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToffLeadDev.Properties;

namespace ToffLeadDev
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveData();

            Exit();
        }

        private void Exit()
        {
            Close();
        }

        private void LoadData()
        {
            textBoxMainTitle.Text = Settings.Default.MainTitle;
            textBoxApiUrl.Text = Settings.Default.ApiUrl;
            textBoxPhonePrefix.Text = Settings.Default.PhonePrefix;
            textBoxLeadProduct.Text = Settings.Default.LeadProduct;
            textBoxLeadSource.Text = Settings.Default.LeadSource;
            textBoxLeadSubsource.Text = Settings.Default.LeadSubsource;
            textBoxLeadTemperature.Text = Settings.Default.LeadTemperature;
            checkBoxLeadIsHot.Checked = Settings.Default.LeadIsHot;
        }

        private void SaveData()
        {
            Settings.Default.MainTitle = textBoxMainTitle.Text;
            Settings.Default.ApiUrl = textBoxApiUrl.Text;
            Settings.Default.PhonePrefix = textBoxPhonePrefix.Text;
            Settings.Default.LeadProduct = textBoxLeadProduct.Text;
            Settings.Default.LeadSource = textBoxLeadSource.Text;
            Settings.Default.LeadSubsource = textBoxLeadSubsource.Text;
            Settings.Default.LeadTemperature = textBoxLeadTemperature.Text;
            Settings.Default.LeadIsHot = checkBoxLeadIsHot.Checked;
            Settings.Default.Save();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
