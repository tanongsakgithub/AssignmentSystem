
namespace WindowsFormsApp1
{
    partial class ProjectEditor
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
            this.txtprojectname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbbTeam = new System.Windows.Forms.ComboBox();
            this.tblteamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAssignDB = new WindowsFormsApp1.DataSetAssignDB();
            this.tblteamTableAdapter = new WindowsFormsApp1.DataSetAssignDBTableAdapters.tblteamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblteamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAssignDB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อโปรเจค";
            // 
            // txtprojectname
            // 
            this.txtprojectname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtprojectname.Location = new System.Drawing.Point(97, 16);
            this.txtprojectname.MaxLength = 100;
            this.txtprojectname.Name = "txtprojectname";
            this.txtprojectname.Size = new System.Drawing.Size(200, 26);
            this.txtprojectname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ทีม";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(184, 82);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(113, 30);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "บันทึก";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbbTeam
            // 
            this.cbbTeam.DataSource = this.tblteamBindingSource;
            this.cbbTeam.DisplayMember = "teamname";
            this.cbbTeam.FormattingEnabled = true;
            this.cbbTeam.Location = new System.Drawing.Point(97, 51);
            this.cbbTeam.Name = "cbbTeam";
            this.cbbTeam.Size = new System.Drawing.Size(200, 24);
            this.cbbTeam.TabIndex = 7;
            this.cbbTeam.ValueMember = "teamid";
            // 
            // tblteamBindingSource
            // 
            this.tblteamBindingSource.DataMember = "tblteam";
            this.tblteamBindingSource.DataSource = this.dataSetAssignDB;
            // 
            // dataSetAssignDB
            // 
            this.dataSetAssignDB.DataSetName = "DataSetAssignDB";
            this.dataSetAssignDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblteamTableAdapter
            // 
            this.tblteamTableAdapter.ClearBeforeFill = true;
            // 
            // ProjectEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 132);
            this.Controls.Add(this.cbbTeam);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtprojectname);
            this.Controls.Add(this.label1);
            this.Name = "ProjectEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectEditor";
            this.Load += new System.EventHandler(this.ProjectEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblteamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAssignDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprojectname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbbTeam;
        private System.Windows.Forms.BindingSource tblteamBindingSource;
        private DataSetAssignDB dataSetAssignDB;
        private DataSetAssignDBTableAdapters.tblteamTableAdapter tblteamTableAdapter;
    }
}