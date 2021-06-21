
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSetAssignDB = new WindowsFormsApp1.DataSetAssignDB();
            this.tblprojectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblprojectTableAdapter = new WindowsFormsApp1.DataSetAssignDBTableAdapters.tblprojectTableAdapter();
            this.projectidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAssignDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprojectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectidDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.teamidDataGridViewTextBoxColumn,
            this.projectnameDataGridViewTextBoxColumn,
            this.teamnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblprojectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSetAssignDB
            // 
            this.dataSetAssignDB.DataSetName = "DataSetAssignDB";
            this.dataSetAssignDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblprojectBindingSource
            // 
            this.tblprojectBindingSource.DataMember = "tblproject";
            this.tblprojectBindingSource.DataSource = this.dataSetAssignDB;
            // 
            // tblprojectTableAdapter
            // 
            this.tblprojectTableAdapter.ClearBeforeFill = true;
            // 
            // projectidDataGridViewTextBoxColumn
            // 
            this.projectidDataGridViewTextBoxColumn.DataPropertyName = "projectid";
            this.projectidDataGridViewTextBoxColumn.HeaderText = "projectid";
            this.projectidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectidDataGridViewTextBoxColumn.Name = "projectidDataGridViewTextBoxColumn";
            this.projectidDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectidDataGridViewTextBoxColumn.Width = 125;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "userid";
            this.useridDataGridViewTextBoxColumn.HeaderText = "userid";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.Width = 125;
            // 
            // teamidDataGridViewTextBoxColumn
            // 
            this.teamidDataGridViewTextBoxColumn.DataPropertyName = "teamid";
            this.teamidDataGridViewTextBoxColumn.HeaderText = "teamid";
            this.teamidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teamidDataGridViewTextBoxColumn.Name = "teamidDataGridViewTextBoxColumn";
            this.teamidDataGridViewTextBoxColumn.Width = 125;
            // 
            // projectnameDataGridViewTextBoxColumn
            // 
            this.projectnameDataGridViewTextBoxColumn.DataPropertyName = "projectname";
            this.projectnameDataGridViewTextBoxColumn.HeaderText = "projectname";
            this.projectnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectnameDataGridViewTextBoxColumn.Name = "projectnameDataGridViewTextBoxColumn";
            this.projectnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // teamnameDataGridViewTextBoxColumn
            // 
            this.teamnameDataGridViewTextBoxColumn.DataPropertyName = "teamname";
            this.teamnameDataGridViewTextBoxColumn.HeaderText = "teamname";
            this.teamnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teamnameDataGridViewTextBoxColumn.Name = "teamnameDataGridViewTextBoxColumn";
            this.teamnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAssignDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprojectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblprojectBindingSource;
        private DataSetAssignDB dataSetAssignDB;
        private DataSetAssignDBTableAdapters.tblprojectTableAdapter tblprojectTableAdapter;
    }
}