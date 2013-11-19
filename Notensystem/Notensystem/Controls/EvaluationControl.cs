using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notensystem.Domain;
using System.Collections.ObjectModel;

namespace Notensystem.Controls
{
    public partial class EvaluationControl : UserControl
    {
        private List<Evaluation> evaluations;

        public EvaluationControl()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<Evaluation> evaluations)
        {
            this.evaluations = evaluations;
            evaluationBindingSource.DataSource = evaluations;
        }
    }
}
