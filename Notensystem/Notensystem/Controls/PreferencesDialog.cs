using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notensystem.Core;

namespace Notensystem.Controls
{
    public partial class PreferencesDialog : BaseDialog, ILocalizable
    {
        public PreferencesDialog()
        {
            InitializeComponent();

            Translate();

            ApplicationEnvironment.LanguageChanged -= OnLanguageChanged;
            ApplicationEnvironment.LanguageChanged += OnLanguageChanged;

            comboBoxCulture.DataSource = ApplicationEnvironment.GetSupportedCultures();
            comboBoxCulture.SelectedItem = ApplicationEnvironment.CurrentCulture;
        }

        private void OnLanguageChanged(object sender, EventArgs e)
        {
            Translate();
        }

        public override void Translate()
        {
            labelServer.Text = ApplicationEnvironment.GetString("LabelServer");
            labelPort.Text = ApplicationEnvironment.GetString("LabelPort");
            labelDatabase.Text = ApplicationEnvironment.GetString("LabelDatabase");
            labelUser.Text = ApplicationEnvironment.GetString("LabelUser");
            labelPassword.Text = ApplicationEnvironment.GetString("LabelPassword");
            labelCulture.Text = ApplicationEnvironment.GetString("LabelCulture");
            grpDatabase.Text = ApplicationEnvironment.GetString("GroupDatabase");
            grpGeneral.Text = ApplicationEnvironment.GetString("GroupGeneral");
            if (ApplicationEnvironment.CurrentCulture.ToLower().Contains("en"))
            {
                comboBoxCulture.DisplayMember = "EnglishName";
            }
            else
            {
                comboBoxCulture.DisplayMember = "DisplayName";
            }
            base.Translate();
        }

        protected override void ButtonOk_OnClick(object sender, EventArgs e)
        {
            string setLanguage = Convert.ToString(comboBoxCulture.SelectedValue);
            if (setLanguage != ApplicationEnvironment.CurrentCulture)
            {
                ApplicationEnvironment.SetCulture(Convert.ToString(comboBoxCulture.SelectedValue));
            }
        }
    }
}
