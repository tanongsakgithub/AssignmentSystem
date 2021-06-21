
namespace WindowsFormsApp1
{
    partial class ToDoTeam
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddtodoteam = new System.Windows.Forms.Button();
            this.btnEdittodoteam = new System.Windows.Forms.Button();
            this.btnDeletetodoteam = new System.Windows.Forms.Button();
            this.btnreportproject = new System.Windows.Forms.Button();
            this.btnstatusodoteam = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbltaskteamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAssignDB = new WindowsFormsApp1.DataSetAssignDB();
            this.tbltaskteamTableAdapter = new WindowsFormsApp1.DataSetAssignDBTableAdapters.tbltaskteamTableAdapter();
            this.taskteamidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltaskteamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAssignDB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "งาน";
            // 
            // btnAddtodoteam
            // 
            this.btnAddtodoteam.Location = new System.Drawing.Point(437, 12);
            this.btnAddtodoteam.Name = "btnAddtodoteam";
            this.btnAddtodoteam.Size = new System.Drawing.Size(113, 30);
            this.btnAddtodoteam.TabIndex = 8;
            this.btnAddtodoteam.Text = "เพิ่ม";
            this.btnAddtodoteam.UseVisualStyleBackColor = true;
            this.btnAddtodoteam.Click += new System.EventHandler(this.btnAddtodoteam_Click);
            // 
            // btnEdittodoteam
            // 
            this.btnEdittodoteam.Location = new System.Drawing.Point(556, 12);
            this.btnEdittodoteam.Name = "btnEdittodoteam";
            this.btnEdittodoteam.Size = new System.Drawing.Size(113, 30);
            this.btnEdittodoteam.TabIndex = 7;
            this.btnEdittodoteam.Text = "แก้ไข";
            this.btnEdittodoteam.UseVisualStyleBackColor = true;
            this.btnEdittodoteam.Click += new System.EventHandler(this.btnEdittodoteam_Click);
            // 
            // btnDeletetodoteam
            // 
            this.btnDeletetodoteam.Location = new System.Drawing.Point(675, 12);
            this.btnDeletetodoteam.Name = "btnDeletetodoteam";
            this.btnDeletetodoteam.Size = new System.Drawing.Size(113, 30);
            this.btnDeletetodoteam.TabIndex = 6;
            this.btnDeletetodoteam.Text = "ลบ";
            this.btnDeletetodoteam.UseVisualStyleBackColor = true;
            this.btnDeletetodoteam.Click += new System.EventHandler(this.btnDeletetodoteam_Click);
            // 
            // btnreportproject
            // 
            this.btnreportproject.Location = new System.Drawing.Point(12, 408);
            this.btnreportproject.Name = "btnreportproject";
            this.btnreportproject.Size = new System.Drawing.Size(113, 30);
            this.btnreportproject.TabIndex = 9;
            this.btnreportproject.Text = "รายงาน";
            this.btnreportproject.UseVisualStyleBackColor = true;
            this.btnreportproject.Click += new System.EventHandler(this.btnreportproject_Click);
            // 
            // btnstatusodoteam
            // 
            this.btnstatusodoteam.Location = new System.Drawing.Point(675, 408);
            this.btnstatusodoteam.Name = "btnstatusodoteam";
            this.btnstatusodoteam.Size = new System.Drawing.Size(113, 30);
            this.btnstatusodoteam.TabIndex = 10;
            this.btnstatusodoteam.Text = "เสร็จแล้ว";
            this.btnstatusodoteam.UseVisualStyleBackColor = true;
            this.btnstatusodoteam.Click += new System.EventHandler(this.btnDeletetodome_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskteamidDataGridViewTextBoxColumn,
            this.projectidDataGridViewTextBoxColumn,
            this.datetimeDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.detailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbltaskteamBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 354);
            this.dataGridView1.TabIndex = 11;
            // 
            // tbltaskteamBindingSource
            // 
            this.tbltaskteamBindingSource.DataMember = "tbltaskteam";
            this.tbltaskteamBindingSource.DataSource = this.dataSetAssignDB;
            // 
            // dataSetAssignDB
            // 
            this.dataSetAssignDB.DataSetName = "DataSetAssignDB";
            this.dataSetAssignDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbltaskteamTableAdapter
            // 
            this.tbltaskteamTableAdapter.ClearBeforeFill = true;
            // 
            // taskteamidDataGridViewTextBoxColumn
            // 
            this.taskteamidDataGridViewTextBoxColumn.DataPropertyName = "taskteamid";
            this.taskteamidDataGridViewTextBoxColumn.HeaderText = "taskteamid";
            this.taskteamidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taskteamidDataGridViewTextBoxColumn.Name = "taskteamidDataGridViewTextBoxColumn";
            this.taskteamidDataGridViewTextBoxColumn.ReadOnly = true;
            this.taskteamidDataGridViewTextBoxColumn.Visible = false;
            this.taskteamidDataGridViewTextBoxColumn.Width = 125;
            // 
            // projectidDataGridViewTextBoxColumn
            // 
            this.projectidDataGridViewTextBoxColumn.DataPropertyName = "projectid";
            this.projectidDataGridViewTextBoxColumn.HeaderText = "projectid";
            this.projectidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectidDataGridViewTextBoxColumn.Name = "projectidDataGridViewTextBoxColumn";
            this.projectidDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectidDataGridViewTextBoxColumn.Visible = false;
            this.projectidDataGridViewTextBoxColumn.Width = 125;
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "datetime";
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "วันที่สร้าง";
            this.datetimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            this.datetimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.datetimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "userid";
            this.useridDataGridViewTextBoxColumn.HeaderText = "userid";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            this.useridDataGridViewTextBoxColumn.Visible = false;
            this.useridDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "ชื่อ";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "สกุล";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // detailDataGridViewTextBoxColumn
            // 
            this.detailDataGridViewTextBoxColumn.DataPropertyName = "detail";
            this.detailDataGridViewTextBoxColumn.HeaderText = "รายละเอียด";
            this.detailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detailDataGridViewTextBoxColumn.Name = "detailDataGridViewTextBoxColumn";
            this.detailDataGridViewTextBoxColumn.ReadOnly = true;
            this.detailDataGridViewTextBoxColumn.Width = 125;
            // 
            // ToDoTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnstatusodoteam);
            this.Controls.Add(this.btnreportproject);
            this.Controls.Add(this.btnAddtodoteam);
            this.Controls.Add(this.btnEdittodoteam);
            this.Controls.Add(this.btnDeletetodoteam);
            this.Controls.Add(this.label1);
            this.Name = "ToDoTeam";
            this.Text = "ToDoTeam";
            this.Load += new System.EventHandler(this.ToDoTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltaskteamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAssignDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddtodoteam;
        private System.Windows.Forms.Button btnEdittodoteam;
        private System.Windows.Forms.Button btnDeletetodoteam;
        private System.Windows.Forms.Button btnreportproject;
        private System.Windows.Forms.Button btnstatusodoteam;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tbltaskteamBindingSource;
        private DataSetAssignDB dataSetAssignDB;
        private DataSetAssignDBTableAdapters.tbltaskteamTableAdapter tbltaskteamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskteamidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailDataGridViewTextBoxColumn;
    }
}