namespace Notensystem.Controls
{
    partial class BaseDialog
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
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 3;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelButtons.Controls.Add(this.buttonOk, 2, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonCancel, 1, 0);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(0, 320);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 1;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(677, 28);
            this.tableLayoutPanelButtons.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCancel.Image = global::Notensystem.Properties.Resources.cancel;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(380, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(144, 22);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_OnClick);
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonOk.Image = global::Notensystem.Properties.Resources.ok;
            this.buttonOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOk.Location = new System.Drawing.Point(530, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(144, 22);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_OnClick);
            // 
            // BaseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(677, 348);
            this.Controls.Add(this.tableLayoutPanelButtons);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(316, 192);
            this.Name = "BaseDialog";
            this.Text = "BaseDialog";
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}