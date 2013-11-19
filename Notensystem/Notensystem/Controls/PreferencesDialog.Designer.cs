namespace Notensystem.Controls
{
    partial class PreferencesDialog
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
            this.tableLayoutPanelDatabase = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.dbConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelServer = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpDatabase = new System.Windows.Forms.GroupBox();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.labelCulture = new System.Windows.Forms.Label();
            this.comboBoxCulture = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbConnectionBindingSource)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.grpDatabase.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.tableLayoutPanelGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelDatabase
            // 
            this.tableLayoutPanelDatabase.ColumnCount = 2;
            this.tableLayoutPanelDatabase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelDatabase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDatabase.Controls.Add(this.textBoxServer, 1, 0);
            this.tableLayoutPanelDatabase.Controls.Add(this.labelServer, 0, 0);
            this.tableLayoutPanelDatabase.Controls.Add(this.labelPort, 0, 1);
            this.tableLayoutPanelDatabase.Controls.Add(this.textBoxPort, 1, 1);
            this.tableLayoutPanelDatabase.Controls.Add(this.labelDatabase, 0, 2);
            this.tableLayoutPanelDatabase.Controls.Add(this.labelUser, 0, 3);
            this.tableLayoutPanelDatabase.Controls.Add(this.labelPassword, 0, 4);
            this.tableLayoutPanelDatabase.Controls.Add(this.textBoxDatabase, 1, 2);
            this.tableLayoutPanelDatabase.Controls.Add(this.textBoxUser, 1, 3);
            this.tableLayoutPanelDatabase.Controls.Add(this.textBoxPassword, 1, 4);
            this.tableLayoutPanelDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDatabase.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanelDatabase.Name = "tableLayoutPanelDatabase";
            this.tableLayoutPanelDatabase.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanelDatabase.RowCount = 5;
            this.tableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDatabase.Size = new System.Drawing.Size(332, 209);
            this.tableLayoutPanelDatabase.TabIndex = 0;
            // 
            // textBoxServer
            // 
            this.textBoxServer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dbConnectionBindingSource, "Ip", true));
            this.textBoxServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxServer.Location = new System.Drawing.Point(85, 11);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(236, 22);
            this.textBoxServer.TabIndex = 1;
            // 
            // dbConnectionBindingSource
            // 
            this.dbConnectionBindingSource.DataSource = typeof(Notensystem.DataAccess.DatabaseConnection);
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(11, 8);
            this.labelServer.Name = "labelServer";
            this.labelServer.Padding = new System.Windows.Forms.Padding(6);
            this.labelServer.Size = new System.Drawing.Size(50, 25);
            this.labelServer.TabIndex = 0;
            this.labelServer.Text = "Server";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(11, 36);
            this.labelPort.Name = "labelPort";
            this.labelPort.Padding = new System.Windows.Forms.Padding(6);
            this.labelPort.Size = new System.Drawing.Size(40, 25);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "Port";
            // 
            // textBoxPort
            // 
            this.textBoxPort.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dbConnectionBindingSource, "Port", true));
            this.textBoxPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxPort.Location = new System.Drawing.Point(85, 39);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(236, 22);
            this.textBoxPort.TabIndex = 3;
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Location = new System.Drawing.Point(11, 64);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Padding = new System.Windows.Forms.Padding(6);
            this.labelDatabase.Size = new System.Drawing.Size(67, 25);
            this.labelDatabase.TabIndex = 4;
            this.labelDatabase.Text = "Database";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(11, 92);
            this.labelUser.Name = "labelUser";
            this.labelUser.Padding = new System.Windows.Forms.Padding(6);
            this.labelUser.Size = new System.Drawing.Size(42, 25);
            this.labelUser.TabIndex = 6;
            this.labelUser.Text = "User";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(11, 120);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Padding = new System.Windows.Forms.Padding(6);
            this.labelPassword.Size = new System.Drawing.Size(68, 25);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Password";
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dbConnectionBindingSource, "Database", true));
            this.textBoxDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxDatabase.Location = new System.Drawing.Point(85, 67);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(236, 22);
            this.textBoxDatabase.TabIndex = 5;
            // 
            // textBoxUser
            // 
            this.textBoxUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dbConnectionBindingSource, "User", true));
            this.textBoxUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxUser.Location = new System.Drawing.Point(85, 95);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(236, 22);
            this.textBoxUser.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dbConnectionBindingSource, "Password", true));
            this.textBoxPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxPassword.Location = new System.Drawing.Point(85, 123);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(236, 22);
            this.textBoxPassword.TabIndex = 9;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.grpDatabase, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.grpGeneral, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.45918F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.54082F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(699, 402);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // grpDatabase
            // 
            this.grpDatabase.Controls.Add(this.tableLayoutPanelDatabase);
            this.grpDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDatabase.Location = new System.Drawing.Point(8, 8);
            this.grpDatabase.Name = "grpDatabase";
            this.grpDatabase.Size = new System.Drawing.Size(338, 230);
            this.grpDatabase.TabIndex = 0;
            this.grpDatabase.TabStop = false;
            this.grpDatabase.Text = "Database";
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.tableLayoutPanelGeneral);
            this.grpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGeneral.Location = new System.Drawing.Point(352, 8);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(339, 230);
            this.grpGeneral.TabIndex = 1;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // tableLayoutPanelGeneral
            // 
            this.tableLayoutPanelGeneral.ColumnCount = 2;
            this.tableLayoutPanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGeneral.Controls.Add(this.labelCulture, 0, 0);
            this.tableLayoutPanelGeneral.Controls.Add(this.comboBoxCulture, 1, 0);
            this.tableLayoutPanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGeneral.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanelGeneral.Name = "tableLayoutPanelGeneral";
            this.tableLayoutPanelGeneral.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanelGeneral.RowCount = 1;
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanelGeneral.Size = new System.Drawing.Size(333, 209);
            this.tableLayoutPanelGeneral.TabIndex = 1;
            // 
            // labelCulture
            // 
            this.labelCulture.AutoSize = true;
            this.labelCulture.Location = new System.Drawing.Point(11, 8);
            this.labelCulture.Name = "labelCulture";
            this.labelCulture.Padding = new System.Windows.Forms.Padding(6);
            this.labelCulture.Size = new System.Drawing.Size(57, 25);
            this.labelCulture.TabIndex = 0;
            this.labelCulture.Text = "Culture";
            // 
            // comboBoxCulture
            // 
            this.comboBoxCulture.DisplayMember = "DisplayName";
            this.comboBoxCulture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCulture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCulture.FormattingEnabled = true;
            this.comboBoxCulture.Location = new System.Drawing.Point(74, 11);
            this.comboBoxCulture.Name = "comboBoxCulture";
            this.comboBoxCulture.Size = new System.Drawing.Size(248, 21);
            this.comboBoxCulture.TabIndex = 1;
            this.comboBoxCulture.ValueMember = "Name";
            // 
            // PreferencesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 430);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "PreferencesDialog";
            this.Text = "PreferencesDialog";
            this.Controls.SetChildIndex(this.tableLayoutPanelMain, 0);
            this.tableLayoutPanelDatabase.ResumeLayout(false);
            this.tableLayoutPanelDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbConnectionBindingSource)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.grpDatabase.ResumeLayout(false);
            this.grpGeneral.ResumeLayout(false);
            this.tableLayoutPanelGeneral.ResumeLayout(false);
            this.tableLayoutPanelGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDatabase;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox grpDatabase;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGeneral;
        private System.Windows.Forms.Label labelCulture;
        private System.Windows.Forms.ComboBox comboBoxCulture;
        private System.Windows.Forms.BindingSource dbConnectionBindingSource;
    }
}