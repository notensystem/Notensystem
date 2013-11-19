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
using Notensystem.DataAccess;
using Notensystem.Domain;
using Notensystem.Properties;

namespace Notensystem.Controls
{
    public partial class MainForm : Form, ILocalizable
    {
        private PreferencesDialog preferencesDialog;
        private MySqlWrapper wrapper;
        private ViewModel viewModel;

        private const string YearKey = "YearNode";
        private const string Cycle1Key = "Cycle1";
        private const string Cycle2Key = "Cycle2";
        private const string Cycle3Key = "Cycle3";
        private const string Cycle4Key = "Cycle4";

        private Year currentYear;
        private Period cycle1;
        private Period cycle2;
        private Period cycle3;
        private Period cycle4;

        private DatabaseConnection connection;

        public MainForm(ViewModel viewModel)
        {
            InitializeComponent();

            ApplicationEnvironment.LanguageChanged -= OnLanguageChanged;
            ApplicationEnvironment.LanguageChanged += OnLanguageChanged;

            this.viewModel = viewModel;
            labelCurrentUser.Text = ApplicationEnvironment.UserName;
            //InitTree();
        }

        private void OnLanguageChanged(object sender, EventArgs e)
        {
            Translate();
        }

        protected override void OnLoad(EventArgs e)
        {
            //connection = new DatabaseConnection("192.168.28.120", 3306, "notensystem", "admin", "admin");
            connection = DatabaseConnection.Read();
            //connection.Write();
            TryConnect();
            Translate();
            base.OnLoad(e);
        }

        public void InitTree()
        {
            // Jahr
            currentYear = new Year();
            TreeNode yearNode = new TreeNode
            {
                Text = Convert.ToString(currentYear.Name),
                Tag = currentYear
            };

            cycle1 = new Period(1, ApplicationEnvironment.GetString("FirstCycle"));
            cycle2 = new Period(2, ApplicationEnvironment.GetString("SecondCycle"));
            cycle3 = new Period(3, ApplicationEnvironment.GetString("ThirdCycle"));
            cycle4 = new Period(4, ApplicationEnvironment.GetString("FourthCycle"));

            yearNode.Nodes.Add(new TreeNode(cycle1.Name) { Tag = cycle1 });
            yearNode.Nodes.Add(new TreeNode(cycle2.Name) { Tag = cycle2 });
            yearNode.Nodes.Add(new TreeNode(cycle3.Name) { Tag = cycle3 });
            yearNode.Nodes.Add(new TreeNode(cycle4.Name) { Tag = cycle4 });

            treeView.Nodes.Add(yearNode);
        }

        public void Translate()
        {
            itemFile.Text = ApplicationEnvironment.GetString("ItemFile");
            itemEdit.Text = ApplicationEnvironment.GetString("ItemEdit");
            itemSettings.Text = ApplicationEnvironment.GetString("ItemSettings");
            itemPreferences.Text = ApplicationEnvironment.GetString("ItemPreferences");
            //if (wrapper.ConnectionState == ConnectionState.Open)
            //{
            //    labelConnectionState.Text = ApplicationEnvironment.GetString("Connected");
            //}
            //else
            //{
            //    labelConnectionState.Text = ApplicationEnvironment.GetString("NotConnected");
            //}
        }

        private void TreeView_OnAfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                IDatabaseObject obj = e.Node.Tag as IDatabaseObject;
                if (obj != null)
                {
                    Period period = obj as Period;
                    if (period != null && period.Classes.Count == 0)
                    {
                        viewModel.CurrentPeriod = period;

                        viewModel.CurrentPeriod.AddClasses(viewModel.GetDummyClasses());
                        foreach (Class c in viewModel.CurrentPeriod.Classes)
                        {
                            e.Node.Nodes.Add(new TreeNode
                            {
                                Tag = c,
                                Text = c.Name
                            });
                        }
                    }

                    Class cl = obj as Class;
                    if (cl != null && cl.Subjects.Count == 0)
                    {
                        viewModel.CurrentClass = cl;

                        viewModel.CurrentClass.AddSubjects(viewModel.GetDummySubjects());
                        foreach (Subject s in viewModel.CurrentClass.Subjects)
                        {
                            e.Node.Nodes.Add(new TreeNode
                            {
                                Tag = s,
                                Text = s.Name
                            });
                        }
                    }

                    Subject subject = obj as Subject;
                    if (subject != null && subject.Evaluations.Count == 0)
                    {
                        viewModel.CurrentSubject = subject;
                        subject.AddEvaluations(viewModel.GetDummyEvaluations());
                        EvaluationControl control = new EvaluationControl();
                        control.SetDataSource(new List<Evaluation>(subject.Evaluations));
                        control.Dock = DockStyle.Fill;
                        panelPlaceHolder.Controls.Add(control);
                    }

                    e.Node.Expand();
                }
            }
        }

        private void abcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wrapper.OpenConnection();
            wrapper.ExecuteScript("insert into student values(10, 'Richard', 'Hampl', 401075);");
            wrapper.CloseConnection();
        }

        private void TryConnect()
        {
            labelConnectionState.Enabled = false;
            labelConnectionState.Text = ApplicationEnvironment.GetString("Connecting");
            worker.RunWorkerAsync();
        }

        private void Worker_OnDoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                wrapper = new MySqlWrapper(connection);
                wrapper.OpenConnection();
            }
            catch (DatabaseException ex)
            {
                MessageBox.Show(string.Format(ex.Message, wrapper.DatabaseConnection.Database), ApplicationEnvironment.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (wrapper.ConnectionState == ConnectionState.Open)
            {
                labelConnectionState.Image = Resources.connected;
                labelConnectionState.Text = ApplicationEnvironment.GetString("Connected");
            }
            else
            {
                labelConnectionState.Image = Resources.not_connected;
                labelConnectionState.Text = ApplicationEnvironment.GetString("NotConnected");
            }
            labelConnectionState.Enabled = true;
        }

        private void LabelConnectionState_OnClick(object sender, EventArgs e)
        {
            if (wrapper.ConnectionState != ConnectionState.Open)
            {
                TryConnect();
            }
        }

        private void ItemPreferences_OnClick(object sender, EventArgs e)
        {
            if (preferencesDialog == null)
            {
                preferencesDialog = new PreferencesDialog();
            }
            preferencesDialog.ShowDialog();
        }
    }
}
