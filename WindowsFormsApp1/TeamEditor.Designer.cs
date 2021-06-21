
namespace WindowsFormsApp1
{
    partial class TeamEditor
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
            this.txtteamname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbluserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAssignDB = new WindowsFormsApp1.DataSetAssignDB();
            this.tbluserTableAdapter = new WindowsFormsApp1.DataSetAssignDBTableAdapters.tbluserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAssignDB)).BeginInit();
            this.SuspendLayout();
            // 
            // txtteamname
            // 
            this.txtteamname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtteamname.Location = new System.Drawing.Point(72, 28);
            this.txtteamname.MaxLength = 100;
            this.txtteamname.Name = "txtteamname";
            this.txtteamname.Size = new System.Drawing.Size(278, 26);
            this.txtteamname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ชื่อทีม";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(378, 27);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(113, 30);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "บันทึก";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbluserBindingSource
            // 
            this.tbluserBindingSource.DataMember = "tbluser";
            this.tbluserBindingSource.DataSource = this.dataSetAssignDB;
            // 
            // dataSetAssignDB
            // 
            this.dataSetAssignDB.DataSetName = "DataSetAssignDB";
            this.dataSetAssignDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbluserTableAdapter
            // 
            this.tbluserTableAdapter.ClearBeforeFill = true;
            // 
            // TeamEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 83);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtteamname);
            this.Controls.Add(this.label1);
            this.Name = "TeamEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeamEditor";
            this.Load += new System.EventHandler(this.TeamEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbluserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAssignDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtteamname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private DataSetAssignDB dataSetAssignDB;
        private System.Windows.Forms.BindingSource tbluserBindingSource;
        private DataSetAssignDBTableAdapters.tbluserTableAdapter tbluserTableAdapter;
    }
}