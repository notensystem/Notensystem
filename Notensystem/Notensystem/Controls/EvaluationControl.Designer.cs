namespace Notensystem.Controls
{
    partial class EvaluationControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.evaluationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reachedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Student,
            this.LastName,
            this.reachedDataGridViewTextBoxColumn,
            this.evaluationTypeDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.evaluationBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(721, 556);
            this.dataGridView.TabIndex = 0;
            // 
            // evaluationBindingSource
            // 
            this.evaluationBindingSource.DataSource = typeof(Notensystem.Domain.Evaluation);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // Student
            // 
            this.Student.DataPropertyName = "Student.FirstName";
            this.Student.HeaderText = "FirstName";
            this.Student.Name = "Student";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "Student";
            this.LastName.HeaderText = "Student";
            this.LastName.Name = "LastName";
            // 
            // reachedDataGridViewTextBoxColumn
            // 
            this.reachedDataGridViewTextBoxColumn.DataPropertyName = "Reached";
            this.reachedDataGridViewTextBoxColumn.HeaderText = "Reached";
            this.reachedDataGridViewTextBoxColumn.Name = "reachedDataGridViewTextBoxColumn";
            // 
            // evaluationTypeDataGridViewTextBoxColumn
            // 
            this.evaluationTypeDataGridViewTextBoxColumn.DataPropertyName = "EvaluationType";
            this.evaluationTypeDataGridViewTextBoxColumn.HeaderText = "EvaluationType";
            this.evaluationTypeDataGridViewTextBoxColumn.Name = "evaluationTypeDataGridViewTextBoxColumn";
            // 
            // EvaluationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EvaluationControl";
            this.Size = new System.Drawing.Size(721, 556);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource evaluationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn reachedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluationTypeDataGridViewTextBoxColumn;
    }
}
