namespace Notensystem.Controls
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.itemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.abcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView = new System.Windows.Forms.TreeView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelConnectionState = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelPlaceHolder = new System.Windows.Forms.Panel();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.environmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.environmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.06449F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.93551F));
            this.tableLayoutPanel.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.treeView, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.statusStrip, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.panelPlaceHolder, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1117, 570);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.SetColumnSpan(this.menuStrip, 2);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFile,
            this.itemEdit,
            this.itemSettings});
            this.menuStrip.Location = new System.Drawing.Point(8, 8);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1101, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // itemFile
            // 
            this.itemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abcToolStripMenuItem,
            this.importToolStripMenuItem});
            this.itemFile.Name = "itemFile";
            this.itemFile.Size = new System.Drawing.Size(37, 20);
            this.itemFile.Text = "File";
            // 
            // abcToolStripMenuItem
            // 
            this.abcToolStripMenuItem.Name = "abcToolStripMenuItem";
            this.abcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abcToolStripMenuItem.Text = "abc";
            this.abcToolStripMenuItem.Click += new System.EventHandler(this.abcToolStripMenuItem_Click);
            // 
            // itemEdit
            // 
            this.itemEdit.Name = "itemEdit";
            this.itemEdit.Size = new System.Drawing.Size(39, 20);
            this.itemEdit.Text = "Edit";
            // 
            // itemSettings
            // 
            this.itemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemPreferences});
            this.itemSettings.Name = "itemSettings";
            this.itemSettings.Size = new System.Drawing.Size(61, 20);
            this.itemSettings.Text = "Settings";
            // 
            // itemPreferences
            // 
            this.itemPreferences.BackColor = System.Drawing.Color.White;
            this.itemPreferences.Image = global::Notensystem.Properties.Resources.preferences;
            this.itemPreferences.Name = "itemPreferences";
            this.itemPreferences.Size = new System.Drawing.Size(147, 22);
            this.itemPreferences.Text = "Preferences ...";
            this.itemPreferences.Click += new System.EventHandler(this.ItemPreferences_OnClick);
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.Location = new System.Drawing.Point(11, 35);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(314, 504);
            this.treeView.TabIndex = 3;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_OnAfterSelect);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.SetColumnSpan(this.statusStrip, 2);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelConnectionState,
            this.labelCurrentUser});
            this.statusStrip.Location = new System.Drawing.Point(8, 542);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1101, 20);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // labelConnectionState
            // 
            this.labelConnectionState.Enabled = false;
            this.labelConnectionState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnectionState.Image = global::Notensystem.Properties.Resources.connecting;
            this.labelConnectionState.Name = "labelConnectionState";
            this.labelConnectionState.Size = new System.Drawing.Size(111, 15);
            this.labelConnectionState.Text = "ConnectionState";
            this.labelConnectionState.Click += new System.EventHandler(this.LabelConnectionState_OnClick);
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.Image = ((System.Drawing.Image)(resources.GetObject("labelCurrentUser.Image")));
            this.labelCurrentUser.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(86, 15);
            this.labelCurrentUser.Text = "CurrentUser";
            // 
            // panelPlaceHolder
            // 
            this.panelPlaceHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlaceHolder.Location = new System.Drawing.Point(331, 35);
            this.panelPlaceHolder.Name = "panelPlaceHolder";
            this.panelPlaceHolder.Size = new System.Drawing.Size(775, 504);
            this.panelPlaceHolder.TabIndex = 5;
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_OnDoWork);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // environmentBindingSource
            // 
            this.environmentBindingSource.DataSource = typeof(Notensystem.Core.ApplicationEnvironment);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 570);
            this.Controls.Add(this.tableLayoutPanel);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.environmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem itemFile;
        private System.Windows.Forms.ToolStripMenuItem itemEdit;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel labelCurrentUser;
        private System.Windows.Forms.BindingSource environmentBindingSource;
        private System.Windows.Forms.Panel panelPlaceHolder;
        private System.Windows.Forms.ToolStripMenuItem abcToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel labelConnectionState;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.ToolStripMenuItem itemSettings;
        private System.Windows.Forms.ToolStripMenuItem itemPreferences;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
    }
}