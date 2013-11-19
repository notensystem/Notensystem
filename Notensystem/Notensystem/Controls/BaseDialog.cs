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
    public partial class BaseDialog : Form, ILocalizable
    {
        public BaseDialog()
        {
            InitializeComponent();
        }

        public virtual void Translate()
        {
            buttonCancel.Text = ApplicationEnvironment.GetString("Cancel");
            buttonOk.Text = ApplicationEnvironment.GetString("Ok");
        }

        protected virtual void ButtonCancel_OnClick(object sender, EventArgs e)
        {

        }

        protected virtual void ButtonOk_OnClick(object sender, EventArgs e)
        {

        }
    }
}
